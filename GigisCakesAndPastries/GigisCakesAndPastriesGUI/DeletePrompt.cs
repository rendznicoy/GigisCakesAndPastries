using GigisCakesAndPastries;
using Microsoft.VisualBasic.Logging;
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
    public partial class DeletePrompt : Form
    {
        public static ManageCustomers manageCustomers = new ManageCustomers();
        public static DeleteUser deleteUser = new DeleteUser();
        public DeletePrompt()
        {
            InitializeComponent();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            string cstmrID = idHidee.Text;
            Customer customer = Database.Customers.Find(u => u.ID.Equals(cstmrID));
            Database.Customers.Remove(customer);
            Database.SerializeCustomers();
            Database.UploadCustomerList();
        }

        private void birthdateLabel2_Click(object sender, EventArgs e)
        {

        }

        private void decisionLabel_Click(object sender, EventArgs e)
        {
        }

        private void delProIcon_Click(object sender, EventArgs e)
        {
        }

        private void idHidee_Click(object sender, EventArgs e)
        {
        }

        private void indexHide_Click(object sender, EventArgs e)
        {

        }

        /*private void removeCustomer(Customer customer)
        {
            string cstmrID = idHidee.Text;
            Customer customer = Database.Customers.Find(u => u.ID.Equals(cstmrID));
            Database.Customers.Remove(customer);
            Database.SerializeCustomers();
            Database.UploadCustomerList();
            manageCustomers.update();
            Visible = false;    

            customer = null;
            string id = idHidee.Text;
            foreach (User user in Database.Customers)
            {
                user.ID = idHidee.Text;
                if (user.ID.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    customer = (Customer?)user;
                    break;
                }
            }
            if (customer != null)
            {
                Database.Customers.Remove(customer);
                Database.SerializeCustomers();
                Database.UploadCustomerList();
                MessageBox.Show("User Account Deletion Complete!");
                Visible = false;
            }
          }*/
    }
}
