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
}
