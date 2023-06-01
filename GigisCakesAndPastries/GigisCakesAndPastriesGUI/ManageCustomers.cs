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
    public partial class ManageCustomers : Form
    {
        public static AdminLoginPage loginPage = new AdminLoginPage();
        public static ManualAddPage manualAddPage = new ManualAddPage();
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            Visible = false;
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Database.DownloadCustomerList();
            Database.DeserializeCustomers();
            cstmrGrid.DataSource = Database.Customers;
        }

        private void mnlAddBtn_Click(object sender, EventArgs e)
        {
            manualAddPage.Show();
        }
    }
}
