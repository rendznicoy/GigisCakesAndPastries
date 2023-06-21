using GigisCakesAndPastries;
using Newtonsoft.Json;
using System.Configuration;
using System.Numerics;

namespace GigisCakesAndPastriesGUI
{
    public partial class LoginDesign : Form
    {
        public static AdminLoginPage adminPage = new AdminLoginPage();
        public static CreateAccountPage createAccountPage = new CreateAccountPage();
        public string usernameHidee;
        private const string ConfigFilePath = "Config.gcp";
        private Config config;
        public LoginDesign()
        {
            InitializeComponent();
            passwordBox.UseSystemPasswordChar = true;
        }

        private void LoadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                string jsonData = File.ReadAllText(ConfigFilePath);
                config = JsonConvert.DeserializeObject<Config>(jsonData);
            }
            else
            {
                config = new Config { IsFirstTimeInstallation = true };
                SaveConfig();
            }
        }
        private void SaveConfig()
        {
            string jsonData = JsonConvert.SerializeObject(config);
            File.WriteAllText(ConfigFilePath, jsonData);
        }
        private bool ValidateDefaultCredentials(string username, string password)
        {
            return username == "admin" && password == "admin";
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

        /*private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text))
            {
                usernameBox.BackColor = Color.Red;
            }
            else
            {
                usernameBox.BackColor = SystemColors.Window;
            }
        }*/

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
                    /*if (usernameBox.Text == "admin" && passwordBox.Text == "admin")
                    {
                        EditLogin eL = new EditLogin(this);
                        if (eL.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Welcome Admin!");
                            usernameBox.Clear();
                            passwordBox.Clear();
                            adminPage.Show();
                            break;
                        //}
                    }
                    else
                    {*/
                    MessageBox.Show("Welcome Admin!");
                    usernameBox.Clear();
                    passwordBox.Clear();
                    adminPage.Show();
                    break;
                    //}
                }
                else if (u is Customer)
                {
                    CustomerView cV = new CustomerView(this);
                    this.usernameHidee = usernameBox.Text;
                    //UserContext.UsersCntxt.Add(usernameBox.Text);
                    cV.usernameHidee = this.usernameHidee;
                    string retrievedName = u.Firstname;
                    MessageBox.Show($"Welcome {retrievedName}!");
                    usernameBox.Clear();
                    passwordBox.Clear();
                    cV.Show();
                    break;
                }
            }
            if (!successfulLogin)
            {
                MessageBox.Show("The password you've entered is incorrect.");
            }
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                this.signInBtn_Click(sender, e);
            }
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TextBox currTextBox = (TextBox)sender;
                passwordBox.Focus();
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginDesign_Load(object sender, EventArgs e)
        {
            LoadConfig();
            if (config.IsFirstTimeInstallation)
            {
                EditLogin eL = new EditLogin(this);
                if(eL.ShowDialog() == DialogResult.OK) 
                {
                    config.IsFirstTimeInstallation = false;
                    SaveConfig();
                }
            }
            else
            {
                this.Show();
            }
        }
    }
}