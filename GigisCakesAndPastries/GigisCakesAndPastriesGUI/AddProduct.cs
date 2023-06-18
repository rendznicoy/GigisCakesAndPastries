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
        private static string lastGenID = string.Empty;
        public AddProduct()
        {
            InitializeComponent();
        }

        public static string GenUnqID()
        {
            string newID;

            do
            {
                newID = GenID();
            }
            while (IsIDExistsInDatabase(newID));

            lastGenID = newID;
            return newID;
        }

        private static string GenID()
        {
            string prefix = lastGenID != string.Empty ? lastGenID + "-" : "";
            string currNum = lastGenID != string.Empty ? lastGenID.Split('-')[^1] : "0";
            int nextNum = int.Parse(currNum) + 1;
            string newNum = nextNum.ToString();

            return prefix + newNum;
        }

        private static bool IsIDExistsInDatabase(string ID)
        {
            foreach (Cakes c in Database.Cakes)
            {
                if (ID == c.ProductID)
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
                    string lblID = GenUnqID();

                    if (prdTypePicker.SelectedIndex == 0)
                    {
                        if (int.TryParse(price, out int priceInt) && int.TryParse(qty, out int qtyInt))
                        {
                            Cakes cake = new Cakes(lblID, prdNameBox.Text, idHidee.Text, sizeHidee.Text, priceInt, qtyInt, prdVarBox.Text);
                            Database.Cakes.Add(cake);
                            Database.SerializeCakes();
                            Database.UploadCakeList();
                        }
                    }
                    else if (prdTypePicker.SelectedIndex == 1)
                    {
                        if (int.TryParse(price, out int priceInt) && int.TryParse(qty, out int qtyInt))
                        {
                            Pastries pastry = new Pastries(lblID, prdNameBox.Text, idHidee.Text, sizeHidee.Text, priceInt, qtyInt, prdVarBox.Text);
                            Database.Pastry.Add(pastry);
                            Database.SerializePastry();
                            Database.UploadPastryList();
                        }
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
        }
    }
}
