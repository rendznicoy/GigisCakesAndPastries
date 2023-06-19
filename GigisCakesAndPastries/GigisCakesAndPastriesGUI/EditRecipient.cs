using GigisCakesAndPastries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{
    public partial class EditRecipient : Form
    {
        public string usernameHidee;
        public string productName;
        public Form parentForm; 
        public EditRecipient(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void EditRecipient_Load(object sender, EventArgs e)
        {

        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
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
            TextBox[] textBox = { lastNameBox, firstNameBox, middleNameBox, phoneNumberBox, addressBox };
            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please complete filling up all the information");
                    break;
                }
            }

            if (string.IsNullOrEmpty(lastNameBox.Text) == false && string.IsNullOrEmpty(firstNameBox.Text) == false && string.IsNullOrEmpty(middleNameBox.Text) == false && string.IsNullOrEmpty(phoneNumberBox.Text) == false && string.IsNullOrEmpty(addressBox.Text) == false)
            {
                bool validPNum = IsValidPNumber(phoneNumberBox.Text);
                if (validPNum == false)
                {
                    MessageBox.Show("Invalid Phone Number");
                }
                else
                {
                    foreach (Customer c in Database.Customers)
                    {
                        if (c.Username == this.usernameHidee)
                        {
                            c.Firstname = firstNameBox.Text;
                            c.MiddleName = middleNameBox.Text;
                            c.Surname = lastNameBox.Text;
                            c.PhoneNumber = phoneNumberBox.Text;
                            c.Address = addressBox.Text;
                        }
                    }
                    Database.SerializeCustomers();
                    Database.UploadCustomerList();
                    lastNameBox.Clear();
                    firstNameBox.Clear();
                    middleNameBox.Clear();
                    phoneNumberBox.Clear();
                    addressBox.Clear();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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

        private void addressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.stepTwoNextBtn_Click(sender, e);
            }
        }
    }
}
