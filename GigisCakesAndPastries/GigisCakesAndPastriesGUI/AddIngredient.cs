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
    public partial class AddIngredient : Form
    {
        public AddIngredient()
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

        private void prdTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prdTypePicker.Text == "Solid")
            {
                prdUnitPicker.Items.Add("Kilograms");
                prdUnitPicker.Items.Add("Grams");
            }
            else
            {
                prdUnitPicker.Items.Clear();
                prdUnitPicker.Items.Add("Liters");
                prdUnitPicker.Items.Add("Milliliters");
            }
        }

        private void mnlStepTwoNextBtn_Click(object sender, EventArgs e)
        {
            bool allFieldsFilled = true;
            TextBox[] textBox = { prdNameBox, prdVarBox, prdQtyBox, };
            ComboBox[] comboBox = { prdTypePicker, prdUnitPicker };
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
                foreach (ComboBox cb in comboBox)
                {
                    if (cb.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please select a value on type / unit");
                        break;
                    }
                }
                if (validQtyInput == false)
                {
                    MessageBox.Show("Invalid Quantity Input, must be an integer");
                }
                else if (prdTypePicker.SelectedIndex >= 0 && prdUnitPicker.SelectedIndex >= 0)
                {
                    idHidee.Text = prdTypePicker.SelectedItem.ToString();
                    sizeHidee.Text = prdUnitPicker.SelectedItem.ToString();
                    string qty = prdQtyBox.Text;
                    string productName = prdNameBox.Text;
                    string productType = prdTypePicker.SelectedItem.ToString();
                    string productUnit = prdUnitPicker.SelectedItem.ToString();
                    int productQuantity = int.Parse(prdQtyBox.Text);
                    string productVariant = prdVarBox.Text;

                    bool itemExists = false;

                    foreach (Ingredients i in Database.Ingredient)
                    {
                        if (i.Name == productName && i.Variant == productVariant)
                        {
                            if (productType == "Solid")
                            {
                                i.Type = productType;
                                if (productUnit == "Kilograms")
                                {
                                    i.Unit = productUnit;
                                    i.Quantity += productQuantity;
                                    itemExists = true;
                                    break;
                                }
                                else if (productUnit == "Grams")
                                {
                                    i.Unit = "Kilograms";
                                    double quantityInKilograms = productQuantity / 1000.0;
                                    i.Quantity += quantityInKilograms;
                                    itemExists = true;
                                    break;
                                }
                            }
                            else if (productType == "Liquid")
                            {
                                i.Type = productType;
                                if (productUnit == "Liters")
                                {
                                    i.Unit = productUnit;
                                    i.Quantity += productQuantity;
                                    itemExists = true;
                                    break;
                                }
                                else if (productUnit == "Milliliters")
                                {
                                    i.Unit = "Liters";
                                    double quantityInLiter = productQuantity / 1000.0;
                                    i.Quantity += quantityInLiter;
                                    itemExists = true;
                                    break;
                                }
                            }

                        }
                    }
                    if (!itemExists)
                    {
                        string lblID = GenUnqID();
                        Ingredients ingredient = new Ingredients(lblID, productName, productVariant, idHidee.Text, productQuantity, productUnit);
                        Database.Ingredient.Add(ingredient);
                    }
                    Database.SerializeIngredient();
                    Database.UploadIngredientList();
                }
                prdNameBox.Clear();
                prdVarBox.Clear();
                prdQtyBox.Clear();
                prdTypePicker.SelectedIndex = 0;
                prdUnitPicker.SelectedIndex = 0;
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
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                prdTypePicker.Focus();
            }
        }

        private void prdUnitPicker_KeyPress(object sender, KeyPressEventArgs e)
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
