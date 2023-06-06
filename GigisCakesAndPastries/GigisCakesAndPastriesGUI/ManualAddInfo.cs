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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GigisCakesAndPastriesGUI
{
    public partial class ManualAddInfo : Form
    {
        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static ManualAddPage managePage = new ManualAddPage();

        public ManualAddInfo()
        {
            InitializeComponent();
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool IsValidPNumber(string pNumber)
        {
            if (pNumber != null)
                return Regex.IsMatch(pNumber, @"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            else
                return false;
        }

        private void mnlExitIcon_Click_1(object sender, EventArgs e)
        {
            managePage.Show();
            Visible = false;
        }

        private void mnlStepTwoNextBtn_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBox = { mnlLastNameBox, mnlFirstNameBox, mnlMiddleNameBox, mnlEmailBox, mnlPhoneNumberBox, mnlAddressBox };
            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please complete filling up all the information");
                    break;
                }
            }

            if (string.IsNullOrEmpty(mnlLastNameBox.Text) == false && string.IsNullOrEmpty(mnlFirstNameBox.Text) == false && string.IsNullOrEmpty(mnlMiddleNameBox.Text) == false && string.IsNullOrEmpty(mnlEmailBox.Text) == false && string.IsNullOrEmpty(mnlPhoneNumberBox.Text) == false && string.IsNullOrEmpty(mnlAddressBox.Text) == false)
            {
                bool validEmail = IsValidEmail(mnlEmailBox.Text);
                bool validPNum = IsValidPNumber(mnlPhoneNumberBox.Text);
                if (validEmail == false)
                {
                    MessageBox.Show("Invalid Email Address");
                }
                else if (validPNum == false)
                {
                    MessageBox.Show("Invalid Phone Number");
                }
                else
                {
                    string numbers = "0123456789";
                    string characters = numbers;
                    characters += numbers;
                    int length = 5;
                    string id = string.Empty;
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
                    string lblID = "00-" + id;

                    Customer customers = new Customer(lblID, mnlLastNameBox.Text, mnlFirstNameBox.Text, mnlMiddleNameBox.Text, mnlEmailBox.Text, usernameHide.Text, passwordHide.Text, mnlPhoneNumberBox.Text, mnlAddressBox.Text, birthMonthHide.Text, birthDateHide.Text, birthYearHide.Text, DateTime.Now);
                    Database.Customers.Add(customers);
                    Database.SerializeCustomers();
                    Database.UploadCustomerList();
                    MessageBox.Show("Registration Complete!");
                    mnlLastNameBox.Clear();
                    mnlFirstNameBox.Clear();
                    mnlMiddleNameBox.Clear();
                    mnlEmailBox.Clear();
                    mnlPhoneNumberBox.Clear();
                    mnlAddressBox.Clear();
                    Visible = false;
                }
            }
        }
    }
}
