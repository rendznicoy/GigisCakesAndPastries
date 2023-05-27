using GigisCakesAndPastries;
using Google.Apis.Upload;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{
    public partial class InfoFillPage : Form
    {
        public static LoginDesign login = new LoginDesign();
        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static CreateAccountPage createAccountPage = new CreateAccountPage();
        public InfoFillPage()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            createAccountPage.Show();
            Visible = false;
        }
        private void InfoFillPage_Load(object sender, EventArgs e)
        {

        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch(Exception e) 
            {
                return false;
            }
        }
        private void stepTwoNextBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { lastNameBox, firstNameBox, middleNameBox, emailBox, phoneNumberBox, addressBox };
            foreach(TextBox txt in textBox)
            {
                if(string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please complete filling up all the information");
                    break;
                }
            }
            
            if(string.IsNullOrEmpty(lastNameBox.Text) == false && string.IsNullOrEmpty(firstNameBox.Text) == false && string.IsNullOrEmpty(middleNameBox.Text) == false && string.IsNullOrEmpty(emailBox.Text) == false && string.IsNullOrEmpty(phoneNumberBox.Text) == false && string.IsNullOrEmpty(addressBox.Text) == false)
            {
                bool validEmail = IsValidEmail(emailBox.Text);
                if(validEmail == false) 
                {
                    MessageBox.Show("Invalid Email Address");
                }
                else
                {
                    string numbers = "0123456789";
                    string characters = numbers;
                    characters += numbers;
                    int length = 5;
                    string id = string.Empty;
                    for(int i = 0; i < length; i++)
                    {
                        string character = string.Empty;
                        do
                        {
                            int index = new Random().Next(0, characters.Length);
                            character = characters.ToCharArray()[index].ToString();
                        }while(id.IndexOf(character) != -1);
                        id += character;
                    }
                    string lblID = "00-" + id;
                    Customer customers = new Customer(lblID, lastNameBox.Text, firstNameBox.Text, middleNameBox.Text, emailBox.Text, usernameHide.Text, passwordHide.Text, phoneNumberBox.Text, addressBox.Text, birthMonthHide.Text, birthDateHide.Text, birthYearHide.Text, DateTime.Now);
                    Database.Customers.Add(customers);
                    Database.SerializeCustomers();
                    Database.UploadCustomerList();
                    MessageBox.Show("Registration Complete!");
                    Database.DownloadCustomerList();
                    Database.DeserializeCustomers();
                    manageCustomers.cstmrGrid.DataSource = Database.Customers;
                    login.Show();
                    Visible = false;
                }
                
            }  
        }
    }
}
