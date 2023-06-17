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
    public partial class ProductInventory : Form
    {
        public static InventoryView iV = new InventoryView();
        public static AddProduct aP = new AddProduct();
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
                foreach (Cakes c in Database.Cakes)
                {
                    if (c.ProductID.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(c.ProductID, c.ProductName, c.Type, c.Size, c.Price, c.Quantity, c.Variant);
                    }
                }

                foreach (Pastries p in Database.Pastry)
                {
                    if (p.ProductID.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
                    }
                }
            }
            else
            {
                foreach (Cakes c in Database.Cakes)
                {
                    this.cstmrGrid.Rows.Add(c.ProductID, c.ProductName, c.Type, c.Size, c.Price, c.Quantity, c.Variant);
                }

                foreach (Pastries p in Database.Pastry)
                {
                    this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchString = searchBox.Text.ToLower();
            if (searchString.Length > 0)
            {
                cstmrGrid.Rows.Clear();
                foreach (Cakes c in Database.Cakes)
                {
                    if (c.ProductID.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(c.ProductID, c.ProductName, c.Type, c.Size, c.Price, c.Quantity, c.Variant);
                    }
                }

                foreach (Pastries p in Database.Pastry)
                {
                    if (p.ProductID.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
                    }
                }
            }
            else
            {
                foreach (Cakes c in Database.Cakes)
                {
                    this.cstmrGrid.Rows.Add(c.ProductID, c.ProductName, c.Type, c.Size, c.Price, c.Quantity, c.Variant);
                }

                foreach (Pastries p in Database.Pastry)
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
            Database.DownloadCakeList();
            Database.DeserializeCakes();
            Database.DownloadPastryList();
            Database.DeserializePastry();

            cstmrGrid.Rows.Clear();

            foreach (Cakes c in Database.Cakes)
            {
                this.cstmrGrid.Rows.Add(c.ProductID, c.ProductName, c.Type, c.Size, c.Price, c.Quantity, c.Variant);
            }

            //int startRowIndex = cstmrGrid.Rows.Count;

            foreach (Pastries p in Database.Pastry)
            {
                this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
            }

            /*for (int i = 0; i < startRowIndex; i++)
            {
                cstmrGrid.Rows.RemoveAt(0);
                //cstmrGrid.Rows.RemoveAt(startRowIndex - 1);
            }*/
        }

        private void ProductInventory_Load(object sender, EventArgs e)
        {
            Database.DownloadCakeList();
            Database.DeserializeCakes();
            Database.DownloadPastryList();
            Database.DeserializePastry();
            foreach (Cakes c in Database.Cakes)
            {
                this.cstmrGrid.Rows.Add(c.ProductID, c.ProductName, c.Type, c.Size, c.Price, c.Quantity, c.Variant);
            }
            foreach (Pastries p in Database.Pastry)
            {
                this.cstmrGrid.Rows.Add(p.ProductID, p.ProductName, p.Type, p.Size, p.Price, p.Quantity, p.Variant);
            }
        }
    }
}
