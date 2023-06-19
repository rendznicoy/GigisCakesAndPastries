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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            Database.DownloadOrderList();
            Database.DeserializeOrder();
            foreach (Orders o in Database.Order)
            {
                this.cstmrGrid.Rows.Add(o.OrderID, o.ProductName, o.ProductSize, o.CustomerName, o.CustomerPhoneNumber, o.CustomerAddress, o.OrderOption, o.PaymentOption, o.OrderQuantity, o.OrderTotal);
            }
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {

        }
    }
}
