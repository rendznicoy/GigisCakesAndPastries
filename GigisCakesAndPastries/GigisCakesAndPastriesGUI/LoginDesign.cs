namespace GigisCakesAndPastriesGUI
{
    public partial class LoginDesign : Form
    {
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
            CreateAccountPage createAccountPage = new CreateAccountPage();
            createAccountPage.Show();
            Visible = false;
        }

        private void loginExitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { usernameBox, passwordBox };

            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please enter username / password");
                    break;
                }
            }
        }
    }
}