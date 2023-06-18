using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{
    public partial class CustomerView : Form
    {
        public static CSignOut cSO = new CSignOut();
        public static LoginDesign lD = new LoginDesign();
        public static ProductList pL = new ProductList();
        public static Cart cart = new Cart();
        public static Notifications notif = new Notifications();
        public static Messages msg = new Messages();
        public static Favourites fvr = new Favourites();
        public static Verification ver = new Verification();
        public static Profile prf = new Profile();

        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            SetCircularPictureBox(cVLogo);
            SetEllipticalButton(signOutBtn);
        }

        private void SetCircularPictureBox(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath circularPath = new System.Drawing.Drawing2D.GraphicsPath();
            circularPath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            pictureBox.Region = new Region(circularPath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cVLogo_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromArgb(170, 184, 194);
        }

        private void cVLogo_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.BackColor = Color.Transparent;
        }
        private void SetEllipticalButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Region = new System.Drawing.Region(new Rectangle(0, 0, button.Width, button.Height));
        }

        private void cVLogo_Click(object sender, EventArgs e)
        {

        }

        private void cVHomeLogo_Click(object sender, EventArgs e)
        {

        }

        private void cVHomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void searchPicBox_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (cSO.ShowDialog() == DialogResult.OK)
            {
                this.Close();
                lD.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Visible = false;
            pL.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Visible = false;
            pL.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            cart.Show();*/
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            cart.Show();*/
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            notif.Show();*/
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            notif.Show();*/
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            msg.Show();*/
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            msg.Show();*/
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            fvr.Show();*/
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            fvr.Show();*/
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            ver.Show();*/
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            ver.Show();*/
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            prf.Show();*/
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under construction.");
            /*Visible = false;
            prf.Show();*/
        }
    }
}
