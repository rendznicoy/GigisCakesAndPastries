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
    public partial class EditProduct : Form
    {
        public EditProduct()
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
            TextBox[] textBox = { prdNameBox, prdPriceBox, prdQtyBox, prdVarBox };
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
                int priceInp = int.Parse(prdPriceBox.Text);
                bool validPriceInput = IsIntegerInputValid(priceInp);
                int qtyInp = int.Parse(prdQtyBox.Text);
                bool validQtyInput = IsIntegerInputValid(qtyInp);
                if (validPriceInput == false)
                {
                    MessageBox.Show("Invalid Price Input, must be an integer");
                }
                else if (validQtyInput == false)
                {
                    MessageBox.Show("Invalid Quantity Input, must be an integer");
                }
                string price = prdPriceBox.Text;
                string qty = prdQtyBox.Text;
                string productName = prdNameBox.Text;
                int productPrice = int.Parse(prdPriceBox.Text);
                int productQuantity = int.Parse(prdQtyBox.Text);
                string productVariant = prdVarBox.Text;

                foreach (Products p in Database.Product)
                {
                    if (label5hide.Text == p.ProductID)
                    {
                        p.ProductName = productName;
                        p.Price = productPrice;
                        p.Quantity = productQuantity;
                        p.Variant = productVariant;
                    }
                }
                Database.SerializeProduct();
                Database.UploadProductList();
            }
            prdNameBox.Clear();
            prdPriceBox.Clear();
            prdQtyBox.Clear();
            prdVarBox.Clear();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void prdNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                prdPriceBox.Focus();
            }
        }

        private void prdPriceBox_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                prdVarBox.Focus();
            }
        }

        private void prdVarBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mnlStepTwoNextBtn_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
