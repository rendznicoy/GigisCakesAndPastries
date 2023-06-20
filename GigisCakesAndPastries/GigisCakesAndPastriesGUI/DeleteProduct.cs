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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void noBtn_Click_1(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void yesBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            string prdID = idHidee.Text;
            Products product = Database.Product.Find(p => p.ProductID.Equals(prdID));
            Database.Product.Remove(product);
            Database.SerializeProduct();
            Database.UploadProductList();
        }
    }
}
