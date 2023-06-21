using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigisCakesAndPastries;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static GigisCakesAndPastriesGUI.CustomerView;

namespace GigisCakesAndPastriesGUI
{
    public partial class ProductList : Form
    {
        public static CSignOut cSO = new CSignOut();
        public static LoginDesign lD = new LoginDesign();
        public static Cart cart = new Cart();
        public static Notifications notif = new Notifications();
        public static Messages msg = new Messages();
        public static Favourites fvr = new Favourites();
        public static Verification ver = new Verification();
        public static Profile prf = new Profile();
        public static ProductList2 pL2 = new ProductList2();
        bool productFound = false;
        double minPrice = double.MaxValue;
        double maxPrice = double.MinValue;
        public string usernameHidee;
        public string productName;
        public Form parentForm;
        private System.Windows.Forms.Timer refreshTimer;

        public ProductList(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 60000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            foreach (Products p in Database.Product)
            {
                if (p.ProductName + " " + p.Variant == label1.Text && p.Quantity > 0)
                {
                    productFound = true;
                    DisplayPriceRange(p);
                    if (minPrice == double.MaxValue && maxPrice == double.MinValue)
                    {
                        label10.Text = "No price available";
                    }
                    else if (minPrice == maxPrice)
                    {
                        label10.Text = $"Price: {minPrice}";
                    }
                    else
                    {
                        label10.Text = $"Price Range: {minPrice} - {maxPrice}";
                    }
                    pictureBox20.Visible = true;
                    label2.Text = "Available";
                }
                if (p.ProductName == label12.Text && p.Quantity > 0)
                {
                    productFound = true;
                    DisplayPriceRange(p);
                    if (minPrice == double.MaxValue && maxPrice == double.MinValue)
                    {
                        label13.Text = "No price available";
                    }
                    else if (minPrice == maxPrice)
                    {
                        label13.Text = $"Price: {minPrice}";
                    }
                    else
                    {
                        label13.Text = $"Price Range: {minPrice} - {maxPrice}";
                    }
                    pictureBox23.Visible = true;
                    label14.Text = "Available";
                }
                if (p.ProductName == label15.Text && p.Quantity > 0)
                {
                    productFound = true;
                    DisplayPriceRange(p);
                    if (minPrice == double.MaxValue && maxPrice == double.MinValue)
                    {
                        label17.Text = "No price available";
                    }
                    else if (minPrice == maxPrice)
                    {
                        label17.Text = $"Price: {minPrice}";
                    }
                    else
                    {
                        label17.Text = $"Price Range: {minPrice} - {maxPrice}";
                    }
                    pictureBox24.Visible = true;
                    label16.Text = "Available";
                }
            }
            if (!productFound)
            {
                productFound = false;
                label10.Text = "Unavailable";
                label2.Text = "Unavailable";
                pictureBox20.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                label13.Text = "Unavailable";
                label14.Text = "Unavailable";
                label16.Text = "Unavailable";
                label17.Text = "Unavailable";
            }
        }
        private void DisplayPriceRange(Products p)
        {
            double price = p.Price;
            string size = p.Size;
            if (size == "Small")
            {
                minPrice = p.Price;
            }
            else if (size == "Large")
            {
                maxPrice = p.Price;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            CustomerView cV = new CustomerView(this);
            cV.usernameHidee = this.usernameHidee;
            Visible = false;
            cV.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }*/
        }

        private void searchPicBox_Click(object sender, EventArgs e)
        {

        }

        private void cVLogo_Click(object sender, EventArgs e)
        {
            CustomerView cV = new CustomerView(this);
            cV.usernameHidee = this.usernameHidee;
            Visible = false;
            cV.Show();
        }

        private void cVHomeLogo_Click(object sender, EventArgs e)
        {
            CustomerView cV = new CustomerView(this);
            cV.usernameHidee = this.usernameHidee;
            Visible = false;
            cV.Show();
        }

        private void cVHomeLbl_Click(object sender, EventArgs e)
        {
            CustomerView cV = new CustomerView(this);
            cV.usernameHidee = this.usernameHidee;
            Visible = false;
            cV.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (cSO.ShowDialog() == DialogResult.OK)
            {
                this.Close();
                lD.Show();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("More Products Coming Soon!");
            /*Visible = false;
            pL2.Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Unavailable")
            {
                MessageBox.Show("This product is currently out of stock.");
            }
            else
            {
                AddToCart aTC = new AddToCart(this);
                Notice ntc = new Notice(this);
                aTC.usernameHidee = this.usernameHidee;
                this.productName = this.label1.Text;
                aTC.productName = this.productName;
                Visible = false;
                if (aTC.ShowDialog() == DialogResult.OK)
                {
                    if (ntc.ShowDialog() == DialogResult.OK)
                    {
                        Visible = true;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label14.Text == "Unavailable")
            {
                MessageBox.Show("This product is currently out of stock.");
            }
            else
            {
                AddToCart aTC = new AddToCart(this);
                Notice ntc = new Notice(this);
                aTC.usernameHidee = this.usernameHidee;
                this.productName = this.label12.Text;
                aTC.productName = this.productName;
                Visible = false;
                if (aTC.ShowDialog() == DialogResult.OK)
                {
                    if (ntc.ShowDialog() == DialogResult.OK)
                    {
                        Visible = true;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label16.Text == "Unavailable")
            {
                MessageBox.Show("This product is currently out of stock.");
            }
            else
            {
                AddToCart aTC = new AddToCart(this);
                Notice ntc = new Notice(this);
                aTC.usernameHidee = this.usernameHidee;
                this.productName = this.label15.Text;
                aTC.productName = this.productName;
                Visible = false;
                if (aTC.ShowDialog() == DialogResult.OK)
                {
                    if (ntc.ShowDialog() == DialogResult.OK)
                    {
                        Visible = true;
                    }
                }
            }
        }
        /* public void SetUser(string username)
         {
             usernameHide.Text = username;
         }*/

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //aTC.SetUser(usernameHide.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //aTC.SetUser(usernameHide.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label2.Text = ""; ;
            label13.Text = "";
            label14.Text = "";
            label16.Text = "";
            label17.Text = "";
            foreach (Products p in Database.Product)
            {
                if (p.ProductName + " " + p.Variant == label1.Text && p.Quantity > 0)
                {
                    productFound = true;
                    DisplayPriceRange(p);
                    if (minPrice == double.MaxValue && maxPrice == double.MinValue)
                    {
                        label10.Text = "No price available";
                    }
                    else if (minPrice == maxPrice)
                    {
                        label10.Text = $"Price: {minPrice}";
                    }
                    else
                    {
                        label10.Text = $"Price Range: {minPrice} - {maxPrice}";
                    }
                    pictureBox20.Visible = true;
                    label2.Text = "Available";
                }
                if (p.ProductName == label12.Text && p.Quantity > 0)
                {
                    productFound = true;
                    DisplayPriceRange(p);
                    if (minPrice == double.MaxValue && maxPrice == double.MinValue)
                    {
                        label13.Text = "No price available";
                    }
                    else if (minPrice == maxPrice)
                    {
                        label13.Text = $"Price: {minPrice}";
                    }
                    else
                    {
                        label13.Text = $"Price Range: {minPrice} - {maxPrice}";
                    }
                    pictureBox23.Visible = true;
                    label14.Text = "Available";
                }
                if (p.ProductName == label15.Text && p.Quantity > 0)
                {
                    productFound = true;
                    DisplayPriceRange(p);
                    if (minPrice == double.MaxValue && maxPrice == double.MinValue)
                    {
                        label17.Text = "No price available";
                    }
                    else if (minPrice == maxPrice)
                    {
                        label17.Text = $"Price: {minPrice}";
                    }
                    else
                    {
                        label17.Text = $"Price Range: {minPrice} - {maxPrice}";
                    }
                    pictureBox24.Visible = true;
                    label16.Text = "Available";
                }
            }
            if (!productFound)
            {
                productFound = false;
                label10.Text = "Unavailable";
                label2.Text = "Unavailable";
                pictureBox20.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                label13.Text = "Unavailable";
                label14.Text = "Unavailable";
                label16.Text = "Unavailable";
                label17.Text = "Unavailable";
            }
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            this.button5_Click(sender, e);
        }
    }
}
