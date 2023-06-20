using GigisCakesAndPastries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{
    public partial class ManageOrders : Form
    {
        public static AdminLoginPage aLP = new AdminLoginPage();
        public Form parentForm;
        public string rowID = "";
        public ManageOrders(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            Database.DownloadOrderList();
            Database.DeserializeOrder();
            foreach (Orders o in Database.Order)
            {
                this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
            }
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            Visible = false;
            aLP.Show();
        }

        private void searchPicBox_Click(object sender, EventArgs e)
        {
            string searchString = searchBox.Text.ToLower();
            if (searchString.Length > 0)
            {
                cstmrGrid.Rows.Clear();
                foreach (Orders o in Database.Order)
                {
                    if (o.OrderID.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
                    }
                }
            }
            else
            {
                cstmrGrid.Rows.Clear();
                foreach (Orders o in Database.Order)
                {
                    this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
                }
            }

        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchString = searchBox.Text.ToLower();
            if (searchString.Length > 0)
            {
                cstmrGrid.Rows.Clear();
                foreach (Orders o in Database.Order)
                {
                    if (o.OrderID.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
                    }
                }
            }
            else
            {
                cstmrGrid.Rows.Clear();
                foreach (Orders o in Database.Order)
                {
                    this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Database.DownloadOrderList();
            Database.DeserializeOrder();
            cstmrGrid.Rows.Clear();
            foreach (Orders o in Database.Order)
            {
                this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadOrderList();
            Database.DeserializeOrder();
            cstmrGrid.Rows.Clear();
            foreach (Orders o in Database.Order)
            {
                this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
            }
        }

        private void cstmrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Confirm"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                ConfirmOrderPrompt cOP = new ConfirmOrderPrompt(this);
                if (cOP.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Cancel"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                CancelOrderPrompt ccOP = new CancelOrderPrompt(this);
                if (ccOP.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Delivered"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                DeliveredPrompt dP = new DeliveredPrompt(this);
                if (dP.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Delete"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                DeleteOrder dO = new DeleteOrder(this);
                if (dO.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
        }
    }
}
