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
    public partial class SignOutPrompt : Form
    {
        public static AdminLoginPage adminPage = new AdminLoginPage();
        public static LoginDesign login = new LoginDesign();
        public SignOutPrompt()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Close();
            login.Show();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
