using GigisCakesAndPastries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            
            if(manualAddPage.ShowDialog() == DialogResult.OK)
            {
                this.refreshBtn_Click(sender, e);
            }
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
            int removeIndex = cstmrGrid.Rows.Count - 1;
            if (removeIndex >= 0 && removeIndex < cstmrGrid.Rows.Count)
            {
                cstmrGrid.Rows.RemoveAt(removeIndex);
                cstmrGrid.DataSource = null;
                cstmrGrid.DataSource = Database.Customers;
                MessageBox.Show("User Account Deletion Complete!");
            }
        }

        private void cstmrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cstmrGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int row = e.RowIndex;
                if (row >= 0 && row < cstmrGrid.Rows.Count)
                {
                    deletePrompt.idHidee.Text = Convert.ToString(cstmrGrid[1, row].Value);
                    deletePrompt.Show();
                }
            }
        }

        private void mnlEdtBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                MessageBox.Show("Please enter the customer ID");
            }

            else
            {
                /*foreach (User u in Database.Customers)
                {
                    if (u.ID == searchBox.Text)
                    {
                        MessageBox.Show("Customer Information Found");
                        Visible = false;
                    }
                }*/
                List<Customer> cstmr = Database.Customers;
                DataTable dt = new DataTable();
                dt.Columns.Add("Loyalty Points");
                dt.Columns.Add("ID");
                dt.Columns.Add("Surname");
                dt.Columns.Add("FirstName");
                dt.Columns.Add("MiddleName");
                dt.Columns.Add("Email");
                dt.Columns.Add("Username");
                dt.Columns.Add("PhoneNumber");
                dt.Columns.Add("Address");
                dt.Columns.Add("BirthMonth");
                dt.Columns.Add("BirthDate");
                dt.Columns.Add("BirthYear");
                dt.Columns.Add("AccountDateCreated");

                foreach (Customer c in cstmr)
                {
                    string dateVal = c.AccountDateCreatead.ToString("yyyy-MM-dd HH:mm");
                    dt.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, dateVal);
                }

                string searchVal = searchBox.Text;
                cstmrGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                cstmrGrid.ClearSelection();
                try
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = $"ID = '{searchVal}'";

                    cstmrGrid.DataSource = dv;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

            
    }
}
