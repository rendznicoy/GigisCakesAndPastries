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
            this.Hide();
        }
        private void InfoFillPage_Load(object sender, EventArgs e)
        {

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
                Customer customers = new Customer("", lastNameBox.Text, firstNameBox.Text, middleNameBox.Text, emailBox.Text, usernameHide.Text, passwordHide.Text, phoneNumberBox.Text, addressBox.Text, birthMonthHide.Text, birthDateHide.Text, birthYearHide.Text, DateTime.Now);
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
