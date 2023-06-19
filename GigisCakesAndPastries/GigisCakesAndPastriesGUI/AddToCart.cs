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
        public static OrderConfirmation oC = new OrderConfirmation();
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

        private void mnlExitIcon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
                this.priceRefresh_Click(sender, e);
            }
            else if (sizePicker.SelectedIndex == 1)
            {
                this.productSize = "Medium";
                this.priceRefresh_Click(sender, e);
            }
            else if (sizePicker.SelectedIndex == 2)
            {
                this.productSize = "Large";
                this.priceRefresh_Click(sender, e);
            }
        }

        private void priceRefresh_Click(object sender, EventArgs e)
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
        }

        private void ordPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordPicker.SelectedIndex == 0)
            {
                orderType = "Pick-Up";
            }
            else if (ordPicker.SelectedIndex == 1)
            {
                orderType = "Delivery";
            }
        }

        private void payPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payPicker.SelectedIndex == 0)
            {
                paymentMethod = "COD";
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
                        productTotal = productPrice * productCost;
                        prcLbl.Text = productTotal.ToString();
                        break;
                    }
                }
            }
        }

        private void stepTwoNextBtn_Click(object sender, EventArgs e)
        {

        }
        /*public void SetUser(string username)
{
usernameHide.Text = username;
}*/
    }
}
