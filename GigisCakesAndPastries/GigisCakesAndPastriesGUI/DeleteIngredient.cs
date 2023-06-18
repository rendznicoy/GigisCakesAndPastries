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
    public partial class DeleteIngredient : Form
    {
        public DeleteIngredient()
        {
            InitializeComponent();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            string ingredientID = idHidee.Text;
            Ingredients ingredient = Database.Ingredient.Find(i => i.IngredientID.Equals(ingredientID));
            Database.Ingredient.Remove(ingredient);
            Database.SerializeIngredient();
            Database.UploadIngredientList();
        }
    }
}
