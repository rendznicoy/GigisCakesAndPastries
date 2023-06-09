using GigisCakesAndPastries;
using System.Numerics;

namespace GigisCakesAndPastriesGUI
{
    public partial class LoginDesign : Form
    {
        public static AdminLoginPage adminPage = new AdminLoginPage();
        public static CreateAccountPage createAccountPage = new CreateAccountPage();
        //public static DoctorForm doctorForm = new DoctorForm();
        public LoginDesign()
        {
            InitializeComponent();
            passwordBox.UseSystemPasswordChar = true;
        }

        private void showPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCBox.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void signUpLink_Click(object sender, EventArgs e)
        {
            createAccountPage.createAccUserBox.Text = string.Empty;
            createAccountPage.createAccPassBox.Text = string.Empty;
            createAccountPage.confirmPassBox.Text = string.Empty;
            createAccountPage.monthPicker.SelectedIndex = -1;
            createAccountPage.dayPicker.SelectedIndex = -1;
            createAccountPage.yearPicker.SelectedIndex = -1;
            createAccountPage.Show();
            Visible = false;
        }

        private void loginExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text) && string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Please enter your username and password");
            }
            else if (string.IsNullOrEmpty(usernameBox.Text))
            {
                MessageBox.Show("Please enter your username");
            }
            else if (string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Please enter your password.");
            }

            bool successfulLogin = false;

            foreach (User u in Database.UserMasterlist())
            {

                if (!u.CanLogin(usernameBox.Text, passwordBox.Text))
                    continue;

                successfulLogin = true;
                Visible = false;

                if (u is Admin)
                {
                    MessageBox.Show("Welcome Admin!");
                    usernameBox.Clear();
                    passwordBox.Clear();
                    adminPage.Show();
                    break;
                }
                /*else if (u is Admin)
                {
                    adminForm.Show();
                    break;
                }*/
            }
            if (!successfulLogin)
            {
                MessageBox.Show("The password you've entered is incorrect.");
            }
        }
    }
}