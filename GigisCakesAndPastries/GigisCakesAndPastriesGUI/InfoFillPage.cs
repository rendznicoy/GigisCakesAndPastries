﻿using GigisCakesAndPastries;
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
    public partial class InfoFillPage : Form
    {
        public static LoginDesign login = new LoginDesign();
        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static CreateAccountPage createAccountPage = new CreateAccountPage();

        public InfoFillPage()
        {
            InitializeComponent();
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
            foreach (Products p in Database.Product)
            {
                if (ID == p.ProductID)
                    return true;
            }
            return false;
        }
        private void exitIcon_Click(object sender, EventArgs e)
        {
            createAccountPage.createAccUserBox.Text = usernameHide.Text;
            createAccountPage.createAccPassBox.Text = passwordHide.Text;
            createAccountPage.confirmPassBox.Text = passwordHide.Text;
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
                    string lblID = GenUnqID();
                    Customer customers = new Customer(lblID, lastNameBox.Text, firstNameBox.Text, middleNameBox.Text, emailBox.Text, usernameHide.Text, passwordHide.Text, phoneNumberBox.Text, addressBox.Text, birthMonthHide.Text, birthDateHide.Text, birthYearHide.Text, DateTime.Now);
                    Database.Customers.Add(customers);
                    Database.SerializeCustomers();
                    Database.UploadCustomerList();
                    MessageBox.Show("Registration Complete!");
                    lastNameBox.Clear();
                    firstNameBox.Clear();
                    middleNameBox.Clear();
                    emailBox.Clear();
                    phoneNumberBox.Clear();
                    addressBox.Clear();
                    Database.DownloadCustomerList();
                    Database.DeserializeCustomers();
                    login.Show();
                    Visible = false;
                }
            }
        }

        private void addressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.stepTwoNextBtn_Click(sender, e);
            }
        }

        private void firstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                middleNameBox.Focus();
            }
        }

        private void middleNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                lastNameBox.Focus();
            }
        }

        private void lastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                emailBox.Focus();
            }
        }

        private void emailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                phoneNumberBox.Focus();
            }
        }

        private void phoneNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                addressBox.Focus();
            }
        }
    }
}
