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
    public partial class DeliveredPrompt : Form
    {
        public Form parentForm;
        public string rowID = "";
        public DeliveredPrompt(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            Orders order = Database.Order.Find(o => o.OrderID.Equals(rowID));
            foreach (Orders o in Database.Order)
            {
                if (o.OrderID == rowID)
                {
                    o.OrderStatus = "Delivered";
                }
            }
            Database.SerializeOrder();
            Database.UploadOrderList();
        }
    }
}
