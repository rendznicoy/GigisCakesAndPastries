using GigisCakesAndPastries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{

    public partial class IngredientInventory : Form
    {
        public static InventoryView iV = new InventoryView();
        public static AddIngredient aI = new AddIngredient();
        public static EditIngredient eI = new EditIngredient();
        public static DeleteIngredient dI = new DeleteIngredient();
        public string rowID = "";
        public string newFName = "";
        public string newMName = "";
        public string newSName = "";
        public string newEmail = "";
        public string newPNumber = "";
        public string newAddress = "";
        public IngredientInventory()
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
                foreach (Ingredients i in Database.Ingredient)
                {
                    if (i.IngredientID.ToLower().Contains(searchString) || i.Name.ToLower().Contains(searchString))
                    {
                        this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
                    }
                }
            }
            else
            {
                cstmrGrid.Rows.Clear();
                foreach (Ingredients i in Database.Ingredient)
                {
                    this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
                }
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
                    foreach (Ingredients i in Database.Ingredient)
                    {
                        if (i.IngredientID.ToLower().Contains(searchString) || i.Name.ToLower().Contains(searchString))
                        {
                            this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
                        }
                    }
                }
                else
                {
                    cstmrGrid.Rows.Clear();
                    foreach (Ingredients i in Database.Ingredient)
                    {
                        this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (aI.ShowDialog() == DialogResult.OK)
            {
                this.refreshBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Database.DownloadIngredientList();
            Database.DeserializeIngredient();

            cstmrGrid.Rows.Clear();

            foreach (Ingredients i in Database.Ingredient)
            {
                this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
            }
        }

        private void mnlAddBtn_Click(object sender, EventArgs e)
        {
            if (aI.ShowDialog() == DialogResult.OK)
            {
                this.refreshBtn_Click(sender, e);
            }
        }

        private void IngredientInventory_Load(object sender, EventArgs e)
        {
            Database.DownloadIngredientList();
            Database.DeserializeIngredient();
            foreach (Ingredients i in Database.Ingredient)
            {
                this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Database.DownloadIngredientList();
            Database.DeserializeIngredient();

            cstmrGrid.Rows.Clear();

            foreach (Ingredients i in Database.Ingredient)
            {
                this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
            }
        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            Database.DownloadIngredientList();
            Database.DeserializeIngredient();

            cstmrGrid.Rows.Clear();

            foreach (Ingredients i in Database.Ingredient)
            {
                this.cstmrGrid.Rows.Add(i.IngredientID, i.Name, i.Variant, i.Type, i.Quantity, i.Unit);
            }
        }

        private void cstmrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CopyRow(DataGridViewRow sR)
        {
            eI.prdNameBox.Text = sR.Cells["IngredientName"].Value.ToString();
            eI.prdVarBox.Text = sR.Cells["Variant"].Value.ToString();
            eI.prdQtyBox.Text = sR.Cells["Quantity"].Value.ToString();
        }

        private void cstmrGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Delete"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                CopyRow(sR);
                rowID = sR.Cells["ProductID"].Value.ToString();
                dI.idHidee.Text = rowID;
                if (dI.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == cstmrGrid.Columns["Edit"].Index)
            {
                DataGridViewRow sR = cstmrGrid.Rows[e.RowIndex];
                CopyRow(sR);
                rowID = sR.Cells["ProductID"].Value.ToString();
                eI.label3hide.Text = rowID;
                if (eI.ShowDialog() == DialogResult.OK)
                {
                    this.refreshBtn_Click(sender, e);
                }
            }
        }
    }
}
