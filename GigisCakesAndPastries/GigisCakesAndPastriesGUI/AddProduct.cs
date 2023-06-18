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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public static string GenUnqID()
        {
            string lblID;
            string numbers = "0123456789";
            string characters = numbers;
            characters += numbers;
            int length = 5;
            string id = string.Empty;
            do
            {
                for (int i = 0; i < length; i++)
                {
                    string character = string.Empty;
                    do
                    {
                        int index = new Random().Next(0, characters.Length);
                        character = characters.ToCharArray()[index].ToString();
                    } while (id.IndexOf(character) != -1);
                    id += character;
                }
                lblID = "00-" + id;
            } while (IsIDExistsInDatabase(lblID));

            return lblID;
        }
        private static bool IsIDExistsInDatabase(string ID)
        {
            foreach (Products p in Database.Product)
            {
                if (ID == p.ProductID)
                    return true;
            }
            return false;
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
            ComboBox[] comboBox = { prdTypePicker, prdSizePicker };
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
                foreach (ComboBox cb in comboBox)
                {
                    if (cb.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please select a value on type / size");
                        break;
                    }
                }
                if (validPriceInput == false)
                {
                    MessageBox.Show("Invalid Price Input, must be an integer");
                }
                else if (validQtyInput == false)
                {
                    MessageBox.Show("Invalid Quantity Input, must be an integer");
                }
                else if (prdTypePicker.SelectedIndex >= 0 && prdSizePicker.SelectedIndex >= 0)
                {
                    idHidee.Text = prdTypePicker.SelectedItem.ToString();
                    sizeHidee.Text = prdSizePicker.SelectedItem.ToString();
                    string price = prdPriceBox.Text;
                    string qty = prdQtyBox.Text;
                    string productName = prdNameBox.Text;
                    string productType = prdTypePicker.SelectedItem.ToString();
                    string productSize = prdSizePicker.SelectedItem.ToString();
                    int productPrice = int.Parse(prdPriceBox.Text);
                    int productQuantity = int.Parse(prdQtyBox.Text);
                    string productVariant = prdVarBox.Text;

                    bool itemExists = false;

                    foreach (Products p in Database.Product)
                    {
                        if (p.ProductName == productName && p.Type == productType && p.Size == productSize && p.Price == productPrice && p.Variant == productVariant)
                        {
                            p.Quantity += productQuantity;
                            itemExists = true;
                            break;
                        }
                    }
                    if (!itemExists)
                    {
                        string lblID = GenUnqID();
                        Products product = new Products(lblID, productName, productType, productSize, productPrice, productQuantity, productVariant);
                        Database.Product.Add(product);
                    }
                    Database.SerializeProduct();
                    Database.UploadProductList();
                }
                prdNameBox.Clear();
                prdPriceBox.Clear();
                prdQtyBox.Clear();
                prdVarBox.Clear();
                prdTypePicker.SelectedIndex = 0;
                prdSizePicker.SelectedIndex = 0;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                prdTypePicker.Focus();
            }
        }

        private void prdSizePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mnlStepTwoNextBtn_Click(sender, e);
            }
        }
    }
}
