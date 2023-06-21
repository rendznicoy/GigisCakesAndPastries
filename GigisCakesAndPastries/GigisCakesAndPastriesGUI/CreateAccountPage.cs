using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigisCakesAndPastries;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GigisCakesAndPastriesGUI
{
    public partial class CreateAccountPage : Form
    {
        public static InfoFillPage ifp = new InfoFillPage();
        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static LoginDesign loginDesign = new LoginDesign();
        private TextBox tb;
        private bool isSelectionCompleted = false;

        public CreateAccountPage()
        {
            InitializeComponent();
            createAccPassBox.UseSystemPasswordChar = true;
            confirmPassBox.UseSystemPasswordChar = true;
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            loginDesign.Show();
            Visible = false;
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDayPickerItems();
        }

        private void UpdateDayPickerItems()
        {
            string selectedMonth = monthPicker.Text;
            dayPicker.Items.Clear();
            if (selectedMonth == "February")
            {
                dayPicker.Items.Clear();
                for (int i = 1; i < 30; i++)
                {
                    dayPicker.Items.Add(i.ToString());
                }
            }
            else if (selectedMonth == "April" || selectedMonth == "June" || selectedMonth == "September" || selectedMonth == "November")
            {
                dayPicker.Items.Clear();
                for (int i = 1; i < 31; i++)
                {
                    dayPicker.Items.Add(i.ToString());
                }
            }
            else
            {
                dayPicker.Items.Clear();
                for (int i = 1; i < 32; i++)
                {
                    dayPicker.Items.Add(i.ToString());
                }
            }
        }

        private void CreateAccountPage_Load(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            int date = int.Parse(n.ToString("yyyy"));

            for (int i = 1950; i <= date; i++)
            {
                yearPicker.Items.Add(i.ToString());
            }
        }

        private void stepOneNextBtn_Click(object sender, EventArgs e)
        {
            if (monthPicker.SelectedIndex < 0 && dayPicker.SelectedIndex < 0 && yearPicker.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a value for month, day, and year");
            }
            else if (monthPicker.SelectedIndex < 0 && dayPicker.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a value for month and day");
            }
            else if (monthPicker.SelectedIndex < 0 && yearPicker.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a value for month and year");
            }
            else if (dayPicker.SelectedIndex < 0 && yearPicker.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a value for day and year");
            }
            else if (monthPicker.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a value for month");
            }
            else if (dayPicker.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a value for day");
            }
            else if (yearPicker.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a value for year");
            }

            if (string.IsNullOrEmpty(createAccUserBox.Text) == false && string.IsNullOrEmpty(createAccPassBox.Text) == false)
            {
                if (monthPicker.SelectedIndex >= 0 && dayPicker.SelectedIndex >= 0 && yearPicker.SelectedIndex >= 0)
                {
                    DateTime now = DateTime.Now;
                    int date = int.Parse(now.ToString("yyyy"));
                    int finalDate = date - 18;
                    int selectedDate = int.Parse(yearPicker.SelectedItem.ToString());

                    string username = createAccUserBox.Text;

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
                    //else if ()
                    else if (createAccPassBox.Text.Length < 3)
                    {
                        MessageBox.Show("Password length must not be less than 3 characters");
                    }
                    else if (createAccPassBox.Text.Length > 14)
                    {
                        MessageBox.Show("Password length must not be more than 14 characters");
                    }
                    else if (createAccPassBox.Text != confirmPassBox.Text)
                    {
                        MessageBox.Show("Password doesn't match.");
                    }
                    else if (selectedDate > finalDate)
                    {
                        MessageBox.Show("You're not eligible for account creation, please ask an adult to assist you.");
                    }
                    else
                    {
                        ifp.usernameHide.Text = createAccUserBox.Text;
                        ifp.passwordHide.Text = createAccPassBox.Text;
                        ifp.birthMonthHide.Text = monthPicker.SelectedItem.ToString();
                        ifp.birthDateHide.Text = dayPicker.SelectedItem.ToString();
                        ifp.birthYearHide.Text = yearPicker.SelectedItem.ToString();
                        ifp.Show();
                        Visible = false;
                    }
                }
            }
        }

        private void showPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCBox.Checked)
            {
                createAccPassBox.UseSystemPasswordChar = false;
                confirmPassBox.UseSystemPasswordChar = false;
            }
            else
            {
                createAccPassBox.UseSystemPasswordChar = true;
                confirmPassBox.UseSystemPasswordChar = true;
            }
        }

        private void createAccUserBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                createAccPassBox.Focus();
            }
        }

        private void yearPicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.stepOneNextBtn_Click(sender, e);
            }
        }

        private void createAccPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                confirmPassBox.Focus();
            }
        }

        private void confirmPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                monthPicker.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
