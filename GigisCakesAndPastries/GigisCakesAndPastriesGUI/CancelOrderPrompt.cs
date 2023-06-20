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
    public partial class CancelOrderPrompt : Form
    {
        public Form parentForm;
        public string rowID = "";
        public CancelOrderPrompt(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageOrders mO = new ManageOrders(this);
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.rowID = mO.rowID;
            Orders order = Database.Order.Find(o => o.OrderID.Equals(rowID));
            foreach (Orders o in Database.Order)
            {
                if (o.OrderID == rowID)
                {
                    o.OrderStatus = "Canceled";
                }
            }
            Database.SerializeOrder();
            Database.UploadOrderList();
        }
    }
}
