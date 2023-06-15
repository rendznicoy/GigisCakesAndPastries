using GigisCakesAndPastries;
using Google.Apis.Upload;
using Microsoft.VisualBasic.Logging;
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
    public partial class EditForm : Form
    {
        public static ManageCustomers manageCustomers = new ManageCustomers();

        public EditForm()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
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

        private void stepTwoNextBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { lastNameBox, firstNameBox, middleNameBox, emailBox, phoneNumberBox, addressBox };
            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please complete filling up all the information");
                    break;
                }
            }

            if (string.IsNullOrEmpty(lastNameBox.Text) == false && string.IsNullOrEmpty(firstNameBox.Text) == false && string.IsNullOrEmpty(middleNameBox.Text) == false && string.IsNullOrEmpty(emailBox.Text) == false && string.IsNullOrEmpty(phoneNumberBox.Text) == false && string.IsNullOrEmpty(addressBox.Text) == false)
            {
                bool validEmail = IsValidEmail(emailBox.Text);
                bool validPNum = IsValidPNumber(phoneNumberBox.Text);
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
                    foreach (Customer c in Database.Customers)
                    {
                        if (usernameHide.Text == c.ID)
                        {
                            c.Firstname = firstNameBox.Text;
                            c.MiddleName = middleNameBox.Text;
                            c.Surname = lastNameBox.Text;
                            c.Email = emailBox.Text;
                            c.PhoneNumber = phoneNumberBox.Text;
                            c.Address = addressBox.Text;
                        }
                    }
                    Database.SerializeCustomers();
                    Database.UploadCustomerList();
                    lastNameBox.Clear();
                    firstNameBox.Clear();
                    middleNameBox.Clear();
                    emailBox.Clear();
                    phoneNumberBox.Clear();
                    addressBox.Clear();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
