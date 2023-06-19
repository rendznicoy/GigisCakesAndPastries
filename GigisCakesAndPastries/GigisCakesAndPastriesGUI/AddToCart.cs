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
        public static ProductList pL = new ProductList();
        public static OrderConfirmation oC = new OrderConfirmation();
        public static EditRecipient eR = new EditRecipient();
        private static string downloadPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string directoryID = "1FoUNLVuYJa7tXE6iBYGgEWEKZkgsag3x";
        public static string cCWSPath = "1HEPocOGKY_wXeW6elJIPcop_X4HWxepB";
        public static string oCPath = "10Wxb2RULOzl_DT0c26QCII-4dQJSLtO0";
        public static string bCPath = "1rrh0j2VjXJ8Q1ZDsijZkkFuPkKnxm7_3";
        string FileID;

        public AddToCart()
        {
            InitializeComponent();
        }

        private void AddToCart_Load(object sender, EventArgs e)
        {
            usernameHide.Text = UserContext.UserCntxt;
            foreach (Customer c in Database.Customers)
            {
                if (c.Username == usernameHide.Text)
                {
                    cstmrDetails.Text = c.Firstname + " " + c.MiddleName + " " + c.Surname + " " + c.PhoneNumber + "\n" + c.Address;
                }
                else
                {
                    cstmrDetails.Text = null;
                }
            }

            if (nameHide.Text == "Chocolate Cake With Strawberries")
            {
                FileID = cCWSPath;
            }
            else if (nameHide.Text == "Oatmeal Cookies")
            {
                FileID = oCPath;
            }
            else if (nameHide.Text == "Banana Cake")
            {
                FileID = bCPath;
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
            this.SetUser(usernameHide.Text);
            //this.Close();
        }

        private void cstmrDetails_TextChanged(object sender, EventArgs e)
        {
            cstmrDetails.MaximumSize = new Size(ClientSize.Width - cstmrDetails.Left, 0);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            foreach (Customer c in Database.Customers)
            {
                if (c.Username == usernameHide.Text)
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
                this.refreshBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadIngredientList();
            Database.DeserializeIngredient();

            cstmrDetails.Text = "";

            foreach (Customer c in Database.Customers)
            {
                if (c.Username == usernameHide.Text)
                {
                    cstmrDetails.Text = c.Firstname + " " + c.MiddleName + " " + c.Surname + " " + c.PhoneNumber + "\n" + c.Address;
                }
            }
        }
        public void SetUser(string username)
        {
            usernameHide.Text = username;
        }
    }
}
