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
    public partial class InfoFillPage : Form
    {
        public InfoFillPage()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            CreateAccountPage cap = new CreateAccountPage();
            cap.Show();
            this.Close();
        }
    }
}
