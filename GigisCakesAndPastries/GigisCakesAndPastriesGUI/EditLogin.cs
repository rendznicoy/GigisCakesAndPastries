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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GigisCakesAndPastriesGUI
{
    public partial class EditLogin : Form
    {
        public Form parentForm;
        public EditLogin(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            createAccPassBox.UseSystemPasswordChar = true;
            confirmPassBox.UseSystemPasswordChar = true;
        }

        private void stepOneNextBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { createAccUserBox, createAccPassBox, confirmPassBox };
            bool allFieldsFilled = true;
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
                Admin admin = new Admin("", "", "", "", "", createAccUserBox.Text, createAccPassBox.Text, "", "", "", "", "", DateTime.Now);
                Database.Admins.Add(admin);
                Database.SerializeAdmin();
                Database.UploadAdminList();
                createAccUserBox.Clear();
                createAccPassBox.Clear();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void createAccUserBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                createAccPassBox.Focus();
            }
        }

        private void createAccPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                confirmPassBox.Focus();
            }
        }

        private void confirmPassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.stepOneNextBtn_Click(sender, e);
            }
        }

        private void showPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCBox.Checked)
            {
                createAccPassBox.UseSystemPasswordChar = false;
                confirmPassBox.UseSystemPasswordChar = false;
            }
            else
            {
                createAccPassBox.UseSystemPasswordChar = true;
                confirmPassBox.UseSystemPasswordChar = true;
            }
        }

        private void loginExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
