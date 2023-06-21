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
    public partial class Notice : Form
    {
        public Form parentForm;
        public Notice(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Notice_Load(object sender, EventArgs e)
        {

        }
    }
}
