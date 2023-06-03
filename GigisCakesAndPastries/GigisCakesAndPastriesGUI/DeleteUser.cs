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
    public partial class DeleteUser : Form
    {
        public static DeleteConfirmationPage deleteConfirmationPage = new DeleteConfirmationPage();
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(idBox.Text))
            {
                MessageBox.Show("Please enter the customer ID");
            }

            else
            {
                foreach (User u in Database.Customers)
                {
                    if (u.ID == idBox.Text)
                    {
                        MessageBox.Show("Customer Information Found");
                        deleteConfirmationPage.Show();
                        deleteConfirmationPage.idHide.Text = idBox.Text;
                        deleteConfirmationPage.fNameHolder.Text = u.Firstname;
                        deleteConfirmationPage.mNameHolder.Text = u.MiddleName;
                        deleteConfirmationPage.sNameHolder.Text = u.Surname;
                        deleteConfirmationPage.emailHolder.Text = u.Email;
                        deleteConfirmationPage.pNumHolder.Text = u.PhoneNumber;
                        deleteConfirmationPage.addressHolder.Text = u.Address;
                        Visible = false;
                    }
                }
            }
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
