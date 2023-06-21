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
    public partial class InventoryView : Form
    {
        public static AdminLoginPage aLP = new AdminLoginPage();
        public static ProductInventory pI = new ProductInventory();
        public static IngredientInventory iI = new IngredientInventory();
        public InventoryView()
        {
            InitializeComponent();
        }

        private void loginExitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
            aLP.Show();
        }

        private void customerListIcn_Click(object sender, EventArgs e)
        {
            Visible = false;
            pI.Show();
        }

        private void customerLstBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            pI.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            iI.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            iI.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
