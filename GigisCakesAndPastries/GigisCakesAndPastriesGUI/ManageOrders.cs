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
        public string prodName = "";
        public string prodSize = "";
        public string phoneNumber = "";
        public int orderTotal = 0;
        public int totalPoints = 0;
        public int revertPoints = 0;
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
                this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal, o.OrderDate, o.OrderStatus);
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
                        this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal, o.OrderDate, o.OrderStatus);
                    }
                }
            }
            else
            {
                cstmrGrid.Rows.Clear();
                foreach (Orders o in Database.Order)
                {
                    this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal, o.OrderDate, o.OrderStatus);
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
                        this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal, o.OrderDate, o.OrderStatus);
                    }
                }
            }
            else
            {
                cstmrGrid.Rows.Clear();
                foreach (Orders o in Database.Order)
                {
                    this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal, o.OrderDate, o.OrderStatus);
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
                this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal, o.OrderDate, o.OrderStatus);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadOrderList();
            Database.DeserializeOrder();
            cstmrGrid.Rows.Clear();
            foreach (Orders o in Database.Order)
            {
                this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal, o.OrderDate, o.OrderStatus);
            }
        }

        private void cstmrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Confirm"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                this.prodName = sR.Cells["ProductOrdered"].Value.ToString();
                this.prodSize = sR.Cells["ProductSize"].Value.ToString();
                this.phoneNumber = sR.Cells["CustomerPhoneNumber"].Value.ToString();
                foreach (Orders o in Database.Order)
                {
                    if (o.OrderID == this.rowID)
                    {
                        if (o.OrderStatus == "Unconfirmed")
                        {
                            ConfirmOrderPrompt cOP = new ConfirmOrderPrompt(this);
                            cOP.rowID = this.rowID;
                            if (cOP.ShowDialog() == DialogResult.OK)
                            {
                                o.OrderStatus = "Confirmed";
                                foreach (Products p in Database.Product)
                                {
                                    if (p.ProductName == this.prodName && p.Size == this.prodSize)
                                    {
                                        p.Quantity = p.Quantity - o.OrderQuantity;
                                        foreach (Customer c in Database.Customers)
                                        {
                                            if (c.PhoneNumber == this.phoneNumber)
                                            {
                                                orderTotal = (int)o.OrderTotal;
                                                totalPoints = this.orderTotal / 1000;
                                                c.LoyaltyPoints = this.totalPoints;
                                            }
                                        }
                                    }
                                    else if (p.ProductName + " " + p.Variant == this.prodName && p.Size == this.prodSize)
                                    {
                                        p.Quantity = p.Quantity - o.OrderQuantity;
                                        foreach (Customer c in Database.Customers)
                                        {
                                            if (c.PhoneNumber == this.phoneNumber)
                                            {
                                                orderTotal = (int)o.OrderTotal;
                                                totalPoints = this.orderTotal / 1000;
                                                c.LoyaltyPoints = this.totalPoints;
                                            }
                                        }
                                    }
                                }
                                Database.SerializeOrder();
                                Database.UploadOrderList();
                                Database.SerializeProduct();
                                Database.UploadProductList();
                                this.refreshBtn_Click(sender, e);
                            }
                        }
                        else if (o.OrderStatus == "Confirmed")
                        {
                            MessageBox.Show("This order is already confirmed");
                        }
                        else if (o.OrderStatus == "Cancelled")
                        {
                            MessageBox.Show("You cannot confirm a cancelled order");
                        }
                        else if (o.OrderStatus == "Delivered")
                        {
                            MessageBox.Show("You cannot confirm a delivered order");
                        }
                    }
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Cancel"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                this.prodName = sR.Cells["ProductOrdered"].Value.ToString();
                this.prodSize = sR.Cells["ProductSize"].Value.ToString();
                foreach (Orders o in Database.Order)
                {
                    if (o.OrderID == this.rowID)
                    {
                        if (o.OrderStatus == "Unconfirmed")
                        {
                            CancelOrderPrompt ccOP = new CancelOrderPrompt(this);
                            ccOP.rowID = this.rowID;
                            if (ccOP.ShowDialog() == DialogResult.OK)
                            {
                                o.OrderStatus = "Cancelled";
                                Database.SerializeOrder();
                                Database.UploadOrderList();
                                this.refreshBtn_Click(sender, e);
                            }
                        }
                        else if (o.OrderStatus == "Confirmed")
                        {
                            CancelOrderPrompt ccOP = new CancelOrderPrompt(this);
                            ccOP.rowID = this.rowID;
                            if (ccOP.ShowDialog() == DialogResult.OK)
                            {
                                o.OrderStatus = "Cancelled";
                                foreach (Products p in Database.Product)
                                {
                                    if (p.ProductName == this.prodName && p.Size == this.prodSize)
                                    {
                                        p.Quantity = p.Quantity + o.OrderQuantity;
                                        foreach (Customer c in Database.Customers)
                                        {
                                            if (c.PhoneNumber == this.phoneNumber)
                                            {
                                                orderTotal = (int)o.OrderTotal;
                                                totalPoints = this.orderTotal / 1000;
                                                revertPoints = c.LoyaltyPoints - totalPoints;
                                                c.LoyaltyPoints = this.revertPoints;
                                            }
                                        }
                                    }
                                    else if (p.ProductName + " " + p.Variant == this.prodName && p.Size == this.prodSize)
                                    {
                                        p.Quantity = p.Quantity + o.OrderQuantity;
                                        foreach (Customer c in Database.Customers)
                                        {
                                            if (c.PhoneNumber == this.phoneNumber)
                                            {
                                                orderTotal = (int)o.OrderTotal;
                                                totalPoints = this.orderTotal / 1000;
                                                revertPoints = c.LoyaltyPoints - totalPoints;
                                                c.LoyaltyPoints = this.revertPoints;
                                            }
                                        }
                                    }
                                }
                                Database.SerializeOrder();
                                Database.UploadOrderList();
                                Database.SerializeProduct();
                                Database.UploadProductList();
                                this.refreshBtn_Click(sender, e);
                            }
                        }
                        else if (o.OrderStatus == "Cancelled")
                        {
                            MessageBox.Show("This order is already cancelled");
                        }
                        else if (o.OrderStatus == "Delivered")
                        {
                            MessageBox.Show("You cannot cancel a delivered order");
                        }
                    }
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Delivered"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                this.prodSize = sR.Cells["ProductSize"].Value.ToString();
                foreach (Orders o in Database.Order)
                {
                    if (o.OrderID == this.rowID)
                    {
                        if (o.OrderStatus == "Unconfirmed")
                        {
                            MessageBox.Show("You cannot mark an unconfirmed order as delivered");
                        }
                        else if (o.OrderStatus == "Confirmed")
                        {
                            DeliveredPrompt dP = new DeliveredPrompt(this);
                            dP.rowID = this.rowID;
                            if (dP.ShowDialog() == DialogResult.OK)
                            {
                                o.OrderStatus = "Delivered";
                                Database.SerializeOrder();
                                Database.UploadOrderList();
                                this.refreshBtn_Click(sender, e);
                            }
                        }
                        else if (o.OrderStatus == "Cancelled")
                        {
                            MessageBox.Show("You cannot mark a cancelled order as delivered");
                        }
                        else if (o.OrderStatus == "Delivered")
                        {
                            MessageBox.Show("This order is already marked as delivered");
                        }
                    }
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Delete"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                this.rowID = sR.Cells["OrderID"].Value.ToString();
                DeleteOrder dO = new DeleteOrder(this);
                dO.rowID = this.rowID;
                if (dO.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
