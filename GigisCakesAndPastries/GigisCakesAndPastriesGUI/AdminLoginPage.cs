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
    public partial class AdminLoginPage : Form
    {
        public static SignOutPrompt signOut = new SignOutPrompt();
        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static InventoryView iV = new InventoryView();
        private System.Windows.Forms.Timer refreshTimer;
        private int previousItemCount;
        private int currentItemCount;
        private bool picBox3Visible;
        public AdminLoginPage()
        {
            InitializeComponent();
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 60000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
            previousItemCount = Database.Order.Count;
            picBox3Visible = LoadBelldefVisibilty();
            pictureBox3.Visible = picBox3Visible;
        }

        private void loginExitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
            signOut.Show();
        }

        private void customerLstBtn_Click(object sender, EventArgs e)
        {
            manageCustomers.Show();
            Visible = false;
        }

        private void customerListIcn_Click(object sender, EventArgs e)
        {
            manageCustomers.Show();
            Visible = false;
        }

        private void inventoryIcn_Click(object sender, EventArgs e)
        {
            iV.Show();
            Visible = false;
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            iV.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageOrders mO = new ManageOrders(this);
            Visible = false;
            mO.Show();
            pictureBox3.Visible = false;
            bellDef.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageOrders mO = new ManageOrders(this);
            Visible = false;
            mO.Show();
            pictureBox3.Visible = false;
            bellDef.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminLoginPage_Load(object sender, EventArgs e)
        {
            int currentItemCount = Database.Order.Count;
            this.CheckItemCountChanged(currentItemCount);
        }

        private void belldef_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            currentItemCount = Database.Order.Count;
            this.CheckItemCountChanged(currentItemCount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentItemCount = 0;
        }
        private void CheckItemCountChanged(int currentItemCount)
        {
            if (currentItemCount > previousItemCount)
            {
                bellDef.Visible = false;
                pictureBox3.Visible = true;
                picBox3Visible = true;
            }
            else if (currentItemCount < previousItemCount)
            {
                bellDef.Visible = true;
                pictureBox3.Visible = false;
                picBox3Visible = false;
            }
            previousItemCount = currentItemCount;
        }
        private bool LoadBelldefVisibilty()
        {
            string visibilityVal = Properties.Settings.Default.picBox3Visibility;

            if (bool.TryParse(visibilityVal, out bool visibilty))
            {
                return visibilty;
            }
            return false;
        }
        private void SaveBelldefVisibility()
        {
            Properties.Settings.Default.picBox3Visibility = Visible.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
