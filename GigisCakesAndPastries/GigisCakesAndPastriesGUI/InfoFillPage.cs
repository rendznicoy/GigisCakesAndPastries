using GigisCakesAndPastries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void stepTwoNextBtn_Click(object sender, EventArgs e)
        {
            Customer customers = new Customer("", lastNameBox.Text, firstNameBox.Text, middleNameBox.Text, emailBox.Text, createAccountPage.createAccUserBox.Text, createAccountPage.createAccPassBox.Text, phoneNumberBox.Text, addressBox.Text, createAccountPage.monthPicker.SelectedIndex, createAccountPage.dayPicker.SelectedIndex, createAccountPage.yearPicker.SelectedIndex, DateTime.Now);
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
