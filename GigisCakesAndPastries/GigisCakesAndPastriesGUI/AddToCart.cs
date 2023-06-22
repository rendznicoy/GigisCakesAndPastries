using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.IO;
using System.Net;
using GigisCakesAndPastries.Properties;
using Google.Apis.Download;
using GigisCakesAndPastries;

namespace GigisCakesAndPastriesGUI
{
    public partial class AddToCart : Form
    {
        private static string downloadPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string directoryID = "1FoUNLVuYJa7tXE6iBYGgEWEKZkgsag3x";
        public static string cCWSPath = "1HEPocOGKY_wXeW6elJIPcop_X4HWxepB";
        public static string oCPath = "10Wxb2RULOzl_DT0c26QCII-4dQJSLtO0";
        public static string bCPath = "1rrh0j2VjXJ8Q1ZDsijZkkFuPkKnxm7_3";
        string FileID;
        public string usernameHidee;
        public string productName;
        public double productPrice;
        public string productSize;
        public string orderType;
        public string paymentMethod;
        public int productQty;
        public string productCount;
        public double productCost;
        public double productTotal;
        public string cstmrName;
        public string cstmrPNum;
        public string cstmrAdd;
        public string lblID;
        public string orderStatus = "Unconfirmed";
        public DateTime orderDate = DateTime.Now;
        public Form parentForm;
        public AddToCart(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            qtyPicker.Minimum = 0;
            qtyPicker.Maximum = 1000;
            qtyPicker.Increment = 1;
        }

        private void AddToCart_Load(object sender, EventArgs e)
        {
            bool customerFound = false;

            foreach (Customer c in Database.Customers)
            {
                if (c.Username == this.usernameHidee)
                {
                    cstmrDetails.Text = c.Firstname + " " + c.MiddleName + " " + c.Surname + " " + c.PhoneNumber + "\n" + c.Address;
                    customerFound = true;
                    break;
                }
            }
            if (!customerFound)
            {
                cstmrDetails.Text = null;
            }
            if (productName == "Chocolate Cake With Strawberries")
            {
                FileID = cCWSPath;
                prdLbl.Text = productName;
            }
            else if (productName == "Oatmeal Cookies")
            {
                FileID = oCPath;
                prdLbl.Text = productName;
            }
            else if (productName == "Banana Cake")
            {
                FileID = bCPath;
                prdLbl.Text = productName;
            }
            LoadImageFromDatabase(FileID);
        }
        private void LoadImageFromDatabase(string fileID)
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(fileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                {
                    request.Download(stream);

                    if (aTCLogo.BackgroundImage != null)
                    {
                        aTCLogo.BackgroundImage.Dispose();
                        aTCLogo.BackgroundImage = null;
                    }

                    using (var fileStream = new FileStream(Path.Combine(downloadPath, fileID), FileMode.Create, FileAccess.Write))
                    {
                        stream.Position = 0;
                        stream.CopyTo(fileStream);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
            if (File.Exists(fileID))
            {
                Image image = Image.FromFile(fileID);
                aTCLogo.BackgroundImage = image;
                aTCLogo.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                aTCLogo.Image = null;
            }
        }
        public static string GenUnqID()
        {
            string lblID;
            string numbers = "0123456789";
            string characters = numbers;
            characters += numbers;
            int length = 5;
            string id = string.Empty;
            do
            {
                for (int i = 0; i < length; i++)
                {
                    string character = string.Empty;
                    do
                    {
                        int index = new Random().Next(0, characters.Length);
                        character = characters.ToCharArray()[index].ToString();
                    } while (id.IndexOf(character) != -1);
                    id += character;
                }
                lblID = "00-" + id;
            } while (IsIDExistsInDatabase(lblID));

            return lblID;
        }
        private static bool IsIDExistsInDatabase(string ID)
        {
            foreach (Orders o in Database.Order)
            {
                if (ID == o.OrderID)
                    return true;
            }
            return false;
        }
        private void mnlExitIcon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void cstmrDetails_TextChanged(object sender, EventArgs e)
        {
            cstmrDetails.MaximumSize = new Size(ClientSize.Width - cstmrDetails.Left, 0);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditRecipient eR = new EditRecipient(this);
            eR.usernameHidee = this.usernameHidee;
            Visible = false;
            foreach (Customer c in Database.Customers)
            {
                if (c.Username == this.usernameHidee)
                {
                    eR.firstNameBox.Text = c.Firstname;
                    eR.middleNameBox.Text = c.MiddleName;
                    eR.lastNameBox.Text = c.Surname;
                    eR.phoneNumberBox.Text = c.PhoneNumber;
                    eR.addressBox.Text = c.Address;
                }
            }
            if (eR.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
                this.refreshBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadCustomerList();
            Database.DeserializeCustomers();

            cstmrDetails.Text = "";

            foreach (Customer c in Database.Customers)
            {
                if (c.Username == usernameHidee)
                {
                    cstmrDetails.Text = c.Firstname + " " + c.MiddleName + " " + c.Surname + " " + c.PhoneNumber + "\n" + c.Address;
                }
            }
        }

        private void sizePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizePicker.SelectedIndex == 0)
            {
                this.productSize = "Small";

            }
            else if (sizePicker.SelectedIndex == 1)
            {
                this.productSize = "Medium";
            }
            else if (sizePicker.SelectedIndex == 2)
            {
                this.productSize = "Large";
            }
        }

        /*private void priceRefresh_Click(object sender, EventArgs e)
        {
            Database.DownloadProductList();
            Database.DeserializeProduct();

            prcLbl.Text = "";

            foreach (Products p in Database.Product)
            {
                if (p.ProductName == productName && p.Size == productSize)
                {
                    productPrice = p.Price;
                    prcLbl.Text = productPrice.ToString();
                    break;
                }
                else if (productName.Contains(p.ProductName) && productName.Contains(p.Variant) && p.Size == productSize)
                {
                    productPrice = p.Price;
                    prcLbl.Text = productPrice.ToString();
                    break;
                }
            }
        }*/

        private void ordPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordPicker.SelectedIndex == 0)
            {
                orderType = "Delivery";
            }
        }

        private void payPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payPicker.SelectedIndex == 0)
            {
                paymentMethod = "Cash on Delivery";
            }
        }

        private void qtyPicker_ValueChanged(object sender, EventArgs e)
        {
            productQty = Convert.ToInt32(qtyPicker.Value);
            productCount = productQty.ToString();
            qtyCount.Text = productCount;
            productCost = productQty;
            this.costRefresh_Click(sender, e);
        }

        private void costRefresh_Click(object sender, EventArgs e)
        {
            Database.DownloadProductList();
            Database.DeserializeProduct();

            prcLbl.Text = "";

            foreach (Products p in Database.Product)
            {
                if (p.ProductName == productName && p.Size == productSize)
                {
                    if (p.Quantity < productQty)
                    {
                        MessageBox.Show("The available number of " + productName + " is only " + p.Quantity.ToString());
                        qtyPicker.Value = qtyPicker.Value - 1;
                        break;
                    }
                    else
                    {
                        productPrice = p.Price;
                        productTotal = productPrice * productCost;
                        prcLbl.Text = productTotal.ToString();
                        break;
                    }
                }
                else if (productName.Contains(p.ProductName) && productName.Contains(p.Variant) && p.Size == productSize)
                {
                    if (p.Quantity < productQty)
                    {
                        MessageBox.Show("The available number of " + productName + " is only " + p.Quantity.ToString());
                        qtyPicker.Value = qtyPicker.Value - 1;
                        break;
                    }
                    else
                    {
                        productPrice = p.Price;
                        productTotal = productPrice * productCost;
                        prcLbl.Text = productTotal.ToString();
                        break;
                    }
                }
            }
        }

        private void stepTwoNextBtn_Click(object sender, EventArgs e)
        {
            bool allFieldsFilled = true;
            ComboBox[] comboBox = { sizePicker, ordPicker, payPicker };
            foreach (ComboBox cb in comboBox)
            {
                if (cb.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a value on size / order options / payment options");
                    allFieldsFilled = false;
                    break;
                }
            }
            if (qtyPicker.Value == 0)
            {
                MessageBox.Show("Quantity must be greater than 1 to place an order.");
            }
            else if (allFieldsFilled)
            {
                foreach (Customer c in Database.Customers)
                {
                    if (c.Username == this.usernameHidee)
                    {
                        this.cstmrName = c.Firstname + " " + c.MiddleName + " " + c.Surname;
                        this.cstmrPNum = c.PhoneNumber;
                        this.cstmrAdd = c.Address;
                    }

                }
                lblID = GenUnqID();
                Orders order = new Orders(lblID, cstmrName, cstmrPNum, cstmrAdd, productName, productSize, orderType, paymentMethod, productQty, productTotal, orderDate, orderStatus);
                Database.Order.Add(order);
                Database.SerializeOrder();
                Database.UploadOrderList();
                Invoice inv = new Invoice(this);
                inv.lblID = this.lblID;
                inv.cstmrName = this.cstmrName;
                inv.cstmrPNum = this.cstmrPNum;
                inv.cstmrAdd = this.cstmrAdd;
                inv.productName = this.productName;
                inv.productSize = this.productSize;
                inv.orderType = this.orderType;
                inv.paymentMethod = this.paymentMethod;
                inv.productQty = this.productCount;
                inv.productCnt = this.productQty;
                inv.productTotal = this.productTotal;
                inv.orderDate = this.orderDate;
                inv.orderStatus = this.orderStatus;
                sizePicker.SelectedIndex = -1;
                ordPicker.SelectedIndex = -1;
                payPicker.SelectedIndex = -1;
                qtyPicker.Value = 0;
                Visible = false;
                if (inv.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*public void SetUser(string username)
{
usernameHide.Text = username;
}*/
    }
}
