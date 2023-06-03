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
        public static DeleteConfirmationPage deleteConfirmationPage = new DeleteConfirmationPage();
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
            foreach (User u in Database.Customers)
            {
                
                if(u.ID == idHidee.Text)
                {
                    
                    Database.SerializeCustomers();
                    Database.UploadCustomerList();
                    MessageBox.Show("User Account Deletion Complete!");
                    Database.DownloadCustomerList();
                    Database.DeserializeCustomers();
                    manageCustomers.cstmrGrid.DataSource = Database.Customers;
                    deleteConfirmationPage.Close();
                    manageCustomers.Show();
                    Visible = false;
                }
            }
        }
    }
}
