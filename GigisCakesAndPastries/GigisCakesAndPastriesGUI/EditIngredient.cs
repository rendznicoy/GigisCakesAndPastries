using GigisCakesAndPastries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{
    public partial class EditIngredient : Form
    {
        public EditIngredient()
        {
            InitializeComponent();
        }

        private void mnlExitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        private static bool IsIntegerInputValid(int input)
        {
            string inp = input.ToString();
            return Regex.IsMatch(inp, @"^\d+$");
        }
        private void mnlStepTwoNextBtn_Click(object sender, EventArgs e)
        {
            bool allFieldsFilled = true;
            TextBox[] textBox = { prdNameBox, prdVarBox, prdQtyBox, };
            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please complete filling up all the information");
                    allFieldsFilled = false;
                    break;
                }
            }
            if (allFieldsFilled)
            {
                int qtyInp = int.Parse(prdQtyBox.Text);
                bool validQtyInput = IsIntegerInputValid(qtyInp);
                if (validQtyInput == false)
                {
                    MessageBox.Show("Invalid Quantity Input, must be an integer");
                }
                string qty = prdQtyBox.Text;
                string productName = prdNameBox.Text;
                int productQuantity = int.Parse(prdQtyBox.Text);
                string productVariant = prdVarBox.Text;

                foreach (Ingredients i in Database.Ingredient)
                {
                    if (label3hide.Text == i.IngredientID)
                    {
                        i.Name = productName;
                        i.Variant = productVariant;
                        i.Quantity = productQuantity;
                    }
                }
                Database.SerializeIngredient();
                Database.UploadIngredientList();
            }
            prdNameBox.Clear();
            prdVarBox.Clear();
            prdQtyBox.Clear();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void prdNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                prdVarBox.Focus();
            }
        }

        private void prdVarBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                prdQtyBox.Focus();
            }
        }

        private void prdQtyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mnlStepTwoNextBtn_Click(sender, e);
            }
        }
    }
}
