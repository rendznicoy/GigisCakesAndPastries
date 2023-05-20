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
    }
}