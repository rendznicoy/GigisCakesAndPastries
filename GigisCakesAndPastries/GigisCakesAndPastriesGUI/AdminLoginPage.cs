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
        public AdminLoginPage()
        {
            InitializeComponent();
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

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
