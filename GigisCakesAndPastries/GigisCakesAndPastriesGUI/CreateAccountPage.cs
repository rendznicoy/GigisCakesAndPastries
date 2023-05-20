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
    public partial class CreateAccountPage : Form
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            LoginDesign loginDesign = new LoginDesign();
            loginDesign.Show();
            Visible = false;
        }
    }
}
