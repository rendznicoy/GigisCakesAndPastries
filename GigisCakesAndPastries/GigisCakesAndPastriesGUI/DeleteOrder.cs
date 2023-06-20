using GigisCakesAndPastries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{
    public partial class DeleteOrder : Form
    {
        public Form newForm;
        public string rowID = "";
        public DeleteOrder(Form newForm)
        {
            InitializeComponent();
            this.newForm = newForm;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            ManageOrders mO = new ManageOrders(this);
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.rowID = mO.rowID;
            Orders order = Database.Order.Find(o => o.OrderID.Equals(rowID));
            Database.Order.Remove(order);
            Database.SerializeOrder();
            Database.UploadOrderList();
        }
    }
}
