using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigisCakesAndPastries;

namespace GigisCakesAndPastriesGUI
{
    public partial class ManualAddPage : Form
    {

        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static ManualAddInfo manageInfo = new ManualAddInfo();

        public ManualAddPage()
        {
            InitializeComponent();
            mnlCreateAccPassBox.UseSystemPasswordChar = true;
            mnlConfirmPassBox.UseSystemPasswordChar = true;
        }

        private void mnlExitIcon_Click_1(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void mnlMonthPicker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (mnlMonthPicker.Text == "February")
            {
                mnlDayPicker.Items.Clear();
                for (int i = 1; i < 30; i++)
                {
                    mnlDayPicker.Items.Add(i.ToString());
                }
            }
            else if (mnlMonthPicker.Text == "April" || mnlMonthPicker.Text == "June" || mnlMonthPicker.Text == "September" || mnlMonthPicker.Text == "November")
            {
                mnlDayPicker.Items.Clear();
                for (int i = 1; i < 31; i++)
                {
                    mnlDayPicker.Items.Add(i.ToString());
                }
            }
            else
            {
                mnlDayPicker.Items.Clear();
                for (int i = 1; i < 32; i++)
                {
                    mnlDayPicker.Items.Add(i.ToString());
                }
            }
        }

        private void ManualAddPage_Load_1(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            int date = int.Parse(n.ToString("yyyy"));

            for (int i = 1950; i <= date; i++)
            {
                mnlYearPicker.Items.Add(i.ToString());
            }
        }

        private void mnlStepOneNextBtn_Click_1(object sender, EventArgs e)
        {
            ComboBox[] comboBox = { mnlMonthPicker, mnlDayPicker, mnlYearPicker };


            if (string.IsNullOrEmpty(mnlCreateAccUserBox.Text) && string.IsNullOrEmpty(mnlCreateAccPassBox.Text))
            {
                MessageBox.Show("Please fill in username and password");
            }
            else if (string.IsNullOrEmpty(mnlCreateAccUserBox.Text))
            {
                MessageBox.Show("Please fill in username");
            }
            else if (string.IsNullOrEmpty(mnlCreateAccPassBox.Text))
            {
                MessageBox.Show("Please fill in password");
            }

            foreach (ComboBox cb in comboBox)
            {
                if (cb.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a value on month / day / year");
                    break;
                }
            }

            if (string.IsNullOrEmpty(mnlCreateAccUserBox.Text) == false && string.IsNullOrEmpty(mnlCreateAccPassBox.Text) == false)
            {
                if (mnlMonthPicker.SelectedIndex >= 0 && mnlDayPicker.SelectedIndex >= 0 && mnlYearPicker.SelectedIndex >= 0)
                {
                    DateTime now = DateTime.Now;
                    int date = int.Parse(now.ToString("yyyy"));
                    int finalDate = date - 18;
                    int selectedDate = int.Parse(mnlYearPicker.SelectedItem.ToString());

                    string username = mnlCreateAccUserBox.Text;

                    if (username.Length < 3)
                    {
                        MessageBox.Show("Username length must not be less than 3 characters");
                    }
                    else if (username.Length >= 14)
                    {
                        MessageBox.Show("Username length must not be more than 14 characters");
                    }
                    else if (!Regex.IsMatch(username, "[A-Za-z0-9_]$"))
                    {
                        MessageBox.Show("Invalid Username");
                    }
                    else if (mnlCreateAccPassBox.Text.Length < 3)
                    {
                        MessageBox.Show("Password length must not be less than 3 characters");
                    }
                    else if (mnlCreateAccPassBox.Text.Length > 14)
                    {
                        MessageBox.Show("Password length must not be more than 14 characters");
                    }
                    else if (mnlCreateAccPassBox.Text != mnlConfirmPassBox.Text)
                    {
                        MessageBox.Show("Password doesn't match.");
                    }
                    else if (selectedDate > finalDate)
                    {
                        MessageBox.Show("You're not eligible for account creation, please ask an adult to assist you.");
                    }
                    else
                    {
                        manageInfo.usernameHide.Text = mnlCreateAccUserBox.Text;
                        manageInfo.passwordHide.Text = mnlCreateAccPassBox.Text;
                        manageInfo.birthMonthHide.Text = mnlMonthPicker.SelectedItem.ToString();
                        manageInfo.birthDateHide.Text = mnlDayPicker.SelectedItem.ToString();
                        manageInfo.birthYearHide.Text = mnlYearPicker.SelectedItem.ToString();
                        mnlCreateAccUserBox.Clear();
                        mnlCreateAccPassBox.Clear();
                        mnlMonthPicker.SelectedIndex = 0;
                        mnlYearPicker.SelectedIndex = 0;
                        mnlDayPicker.SelectedIndex = 0;
                        if (manageInfo.ShowDialog() == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        Visible = false;
                    }
                }
            }
        }

        private void mnlShowPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mnlShowPassCBox.Checked)
            {
                mnlCreateAccPassBox.UseSystemPasswordChar = false;
                mnlConfirmPassBox.UseSystemPasswordChar = false;
            }
            else
            {
                mnlCreateAccPassBox.UseSystemPasswordChar = true;
                mnlConfirmPassBox.UseSystemPasswordChar = true;
            }
        }

        private void mnlCreateAccUserBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                mnlCreateAccPassBox.Focus();
            }
        }

        private void mnlCreateAccPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                mnlConfirmPassBox.Focus();
            }
        }

        private void mnlConfirmPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                mnlMonthPicker.Focus();
            }
        }

        private void mnlYearPicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mnlStepOneNextBtn_Click_1(sender, e);
            }
        }
    }
}
