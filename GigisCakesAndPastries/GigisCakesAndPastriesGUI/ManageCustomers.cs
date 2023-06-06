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
        public static DeleteUser deleteUser = new DeleteUser();
        public static ManualAddInfo manualAddInfo = new ManualAddInfo();
        public static DeletePrompt deletePrompt = new DeletePrompt();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteUser.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadCustomerList();
            Database.DeserializeCustomers();
            cstmrGrid.DataSource = Database.Customers;
            MessageBox.Show("Page Refreshed");
        }

        public void update()
        {
            cstmrGrid.DataSource = null;
            cstmrGrid.DataSource = Database.Customers;
            MessageBox.Show("User Account Deletion Complete!");
        }

        private void cstmrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cstmrGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int row = e.RowIndex;
                deletePrompt.idHidee.Text = Convert.ToString(cstmrGrid[1, row].Value);
                deletePrompt.Show();
            }
        }

        private void mnlEdtBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
