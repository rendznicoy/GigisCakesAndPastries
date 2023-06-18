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
    public partial class OrderConfirmation : Form
    {
        public OrderConfirmation()
        {
            InitializeComponent();
        }

        private void mnlExitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
