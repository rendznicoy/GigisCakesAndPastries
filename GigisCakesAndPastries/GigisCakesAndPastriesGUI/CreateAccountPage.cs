using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigisCakesAndPastries;

namespace GigisCakesAndPastriesGUI
{
    public partial class CreateAccountPage : Form
    {
        public static InfoFillPage ifp = new InfoFillPage();
        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static LoginDesign loginDesign = new LoginDesign();

        public CreateAccountPage()
        {
            InitializeComponent();

            for (int i = 1950; i < 2024; i++)
            {
                yearPicker.Items.Add(i.ToString());
            }
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            loginDesign.Show();
            this.Hide();
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthPicker.Text == "February")
            {
                dayPicker.Items.Clear();
                for (int i = 1; i < 30; i++)
                {
                    dayPicker.Items.Add(i.ToString());
                }
            }
            else if (monthPicker.Text == "April" || monthPicker.Text == "June" || monthPicker.Text == "September" || monthPicker.Text == "November")
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

        }

        private void stepOneNextBtn_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBox = { monthPicker, dayPicker, yearPicker };

            if (string.IsNullOrEmpty(createAccUserBox.Text) && string.IsNullOrEmpty(createAccPassBox.Text))
            {
                MessageBox.Show("Please fill in username and password");
            }
            else if (string.IsNullOrEmpty(createAccUserBox.Text))
            {
                MessageBox.Show("Please fill in username");
            }
            else if (string.IsNullOrEmpty(createAccPassBox.Text))
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

            if (string.IsNullOrEmpty(createAccUserBox.Text) == false && string.IsNullOrEmpty(createAccPassBox.Text) == false)
            {
                if (monthPicker.SelectedIndex >= 0 && dayPicker.SelectedIndex >= 0 && yearPicker.SelectedIndex >= 0)
                {
                    ifp.usernameHide.Text = createAccUserBox.Text;
                    ifp.passwordHide.Text = createAccPassBox.Text;
                    ifp.birthMonthHide.Text = monthPicker.SelectedItem.ToString();
                    ifp.birthDateHide.Text = dayPicker.SelectedItem.ToString();
                    ifp.birthYearHide.Text = yearPicker.SelectedItem.ToString();
                    this.Hide();
                    ifp.Show();
                }
            }
        }
    }
}
