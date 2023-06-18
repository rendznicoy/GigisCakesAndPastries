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
    public partial class ProductInventory : Form
    {
        public static InventoryView iV = new InventoryView();
        public static AddProduct aP = new AddProduct();
        public static EditProduct eP = new EditProduct();
        public static DeleteProduct dP = new DeleteProduct();
        public string rowID = "";
        public string newFName = "";
        public string newMName = "";
        public string newSName = "";
        public string newEmail = "";
        public string newPNumber = "";
        public string newAddress = "";
        public ProductInventory()
        {
            InitializeComponent();
        }
        private void backBtn2_Click(object sender, EventArgs e)
        {
            Visible = false;
            iV.Show();
        }

        private void searchPicBox_Click(object sender, EventArgs e)
        {
            string searchString = searchBox.Text.ToLower();
            if (searchString.Length > 0)
            {
                cstmrGrid.Rows.Clear();
                foreach (Products p in Database.Product)
                {
                    if (p.ProductID.ToLower().Contains(searchString) || p.ProductName.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
                    }
                }
            }
            else
            {
                cstmrGrid.Rows.Clear();
                foreach (Products p in Database.Product)
                {
                    this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (aP.ShowDialog() == DialogResult.OK)
            {
                this.refreshBtn_Click(sender, e);
            }
        }

        private void mnlAddBtn_Click(object sender, EventArgs e)
        {
            if (aP.ShowDialog() == DialogResult.OK)
            {
                this.refreshBtn_Click(sender, e);
            }
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadProductList();
            Database.DeserializeProduct();

            cstmrGrid.Rows.Clear();

            foreach (Products p in Database.Product)
            {
                this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
            }
        }

        private void ProductInventory_Load(object sender, EventArgs e)
        {
            Database.DownloadProductList();
            Database.DeserializeProduct();
            foreach (Products p in Database.Product)
            {
                this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
            }
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string searchString = searchBox.Text.ToLower();
                if (searchString.Length > 0)
                {
                    cstmrGrid.Rows.Clear();
                    foreach (Products p in Database.Product)
                    {
                        if (p.ProductID.ToLower().Contains(searchString) || p.ProductName.ToLower().Contains(searchString))
                        {
                            this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
                        }
                    }
                }
                else
                {
                    cstmrGrid.Rows.Clear();
                    foreach (Products p in Database.Product)
                    {
                        this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
                    }
                }
            }
        }

        private void cstmrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Delete"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                CopyRow(sR);
                rowID = sR.Cells["ProductID"].Value.ToString();
                dP.idHidee.Text = rowID;
                if (dP.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Edit"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                CopyRow(sR);
                rowID = sR.Cells["ProductID"].Value.ToString();
                eP.label5hide.Text = rowID;
                if (eP.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
        }
        private void CopyRow(DataGridViewRow sR)
        {
            eP.prdNameBox.Text = sR.Cells["ProductName"].Value.ToString();
            eP.prdPriceBox.Text = sR.Cells["Price"].Value.ToString();
            eP.prdQtyBox.Text = sR.Cells["Quantity"].Value.ToString();
            eP.prdVarBox.Text = sR.Cells["Variant"].Value.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Database.DownloadProductList();
            Database.DeserializeProduct();

            cstmrGrid.Rows.Clear();

            foreach (Products p in Database.Product)
            {
                this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
            }
        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            Database.DownloadProductList();
            Database.DeserializeProduct();

            cstmrGrid.Rows.Clear();

            foreach (Products p in Database.Product)
            {
                this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
            }
        }
    }
}