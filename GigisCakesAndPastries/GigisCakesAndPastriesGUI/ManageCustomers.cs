using GigisCakesAndPastries;
using Microsoft.VisualBasic.Logging;
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
        public static EditForm eF = new EditForm();
        public string rowID = "";
        public string newFName = "";
        public string newMName = "";
        public string newSName = "";
        public string newEmail = "";
        public string newPNumber = "";
        public string newAddress = "";
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
            foreach (Customer c in Database.Customers)
            {
                this.cstmrGrid.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, c.AccountDateCreatead);
            }
        }

        private void mnlAddBtn_Click(object sender, EventArgs e)
        {
            if (manualAddPage.ShowDialog() == DialogResult.OK)
            {
                this.refreshBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadCustomerList();
            Database.DeserializeCustomers();
            cstmrGrid.Rows.Clear();
            foreach (Customer c in Database.Customers)
            {
                this.cstmrGrid.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, c.AccountDateCreatead);
            }
            //cstmrGrid.DataSource = Database.Customers;
            //MessageBox.Show("Page Refreshed");
        }

        public void update()
        {
            int removeIndex = cstmrGrid.Rows.Count - 1;
            if (removeIndex >= 0 && removeIndex < cstmrGrid.Rows.Count)
            {
                cstmrGrid.Rows.RemoveAt(removeIndex);
                cstmrGrid.DataSource = null;
                foreach (Customer c in Database.Customers)
                {
                    this.cstmrGrid.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, c.AccountDateCreatead);
                }
            }
        }

        private void cstmrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Delete"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                CopyRow(sR);
                rowID = sR.Cells["ID"].Value.ToString();
                deletePrompt.idHidee.Text = rowID;
                if (deletePrompt.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Edit"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                CopyRow(sR);
                rowID = sR.Cells["ID"].Value.ToString();
                eF.usernameHide.Text = rowID;
                if (eF.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
        }

        private void mnlEdtBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string searchString = searchBox.Text.ToLower();
                if (searchString.Length > 0)
                {
                    cstmrGrid.Rows.Clear();
                    foreach (Customer c in Database.Customers)
                    {
                        if (c.ID.ToLower().Contains(searchString))
                        {
                            this.cstmrGrid.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, c.AccountDateCreatead);
                        }
                    }
                }
                else
                {
                    cstmrGrid.Rows.Clear();
                    foreach (Customer c in Database.Customers)
                    {

                        this.cstmrGrid.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, c.AccountDateCreatead);
                    }
                }
            }
        }

        private void CopyRow(DataGridViewRow sR)
        {
            eF.firstNameBox.Text = sR.Cells["FirstName"].Value.ToString();
            eF.middleNameBox.Text = sR.Cells["MiddleName"].Value.ToString();
            eF.lastNameBox.Text = sR.Cells["Surname"].Value.ToString();
            eF.emailBox.Text = sR.Cells["Email"].Value.ToString();
            eF.phoneNumberBox.Text = sR.Cells["PhoneNumber"].Value.ToString();
            eF.addressBox.Text = sR.Cells["Address"].Value.ToString();
        }

        private void searchPicBox_Click(object sender, EventArgs e)
        {
            string searchString = searchBox.Text.ToLower();
            if (searchString.Length > 0)
            {
                cstmrGrid.Rows.Clear();
                foreach (Customer c in Database.Customers)
                {
                    if (c.ID.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, c.AccountDateCreatead);
                    }
                }
            }
            else
            {
                cstmrGrid.Rows.Clear();
                foreach (Customer c in Database.Customers)
                {
                    this.cstmrGrid.Rows.Add(c.LoyaltyPoints, c.ID, c.Surname, c.Firstname, c.MiddleName, c.Email, c.Username, c.PhoneNumber, c.Address, c.BirthMonth, c.BirthDate, c.BirthYear, c.AccountDateCreatead);
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (manualAddPage.ShowDialog() == DialogResult.OK)
            {
                this.refreshBtn_Click(sender, e);
            }
        }
    }
}
