namespace GigisCakesAndPastriesGUI
{
    partial class LoginDesign
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDesign));
            Logo = new PictureBox();
            signInLabel = new Label();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            passwordLabel = new Label();
            showPassCBox = new CheckBox();
            signInBtn = new Button();
            signUpLabel = new Label();
            signUpLink = new Label();
            loginExitIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.Location = new Point(150, -160);
            Logo.Name = "Logo";
            Logo.Size = new Size(500, 500);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // signInLabel
            // 
            signInLabel.AutoSize = true;
            signInLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            signInLabel.ForeColor = Color.Black;
            signInLabel.Location = new Point(225, 160);
            signInLabel.Name = "signInLabel";
            signInLabel.Size = new Size(172, 16);
            signInLabel.TabIndex = 1;
            signInLabel.Text = "SIGN IN WITH ACCOUNT NAME";
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.White;
            usernameBox.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            usernameBox.Location = new Point(225, 180);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Enter Username";
            usernameBox.Size = new Size(350, 27);
            usernameBox.TabIndex = 2;
            usernameBox.KeyPress += usernameBox_KeyPress;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.White;
            passwordBox.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            passwordBox.Location = new Point(225, 275);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Enter Password";
            passwordBox.Size = new Size(350, 27);
            passwordBox.TabIndex = 3;
            passwordBox.KeyDown += passwordBox_KeyDown;
            passwordBox.KeyPress += passwordBox_KeyPress;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(225, 255);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(72, 16);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "PASSWORD";
            // 
            // showPassCBox
            // 
            showPassCBox.AutoSize = true;
            showPassCBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            showPassCBox.ForeColor = Color.Black;
            showPassCBox.Location = new Point(225, 325);
            showPassCBox.Name = "showPassCBox";
            showPassCBox.Size = new Size(126, 24);
            showPassCBox.TabIndex = 5;
            showPassCBox.Text = "Show Password";
            showPassCBox.UseVisualStyleBackColor = true;
            showPassCBox.CheckedChanged += showPassCBox_CheckedChanged;
            // 
            // signInBtn
            // 
            signInBtn.BackColor = Color.FromArgb(15, 129, 240);
            signInBtn.FlatAppearance.BorderSize = 0;
            signInBtn.FlatStyle = FlatStyle.Flat;
            signInBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            signInBtn.ForeColor = Color.White;
            signInBtn.Location = new Point(253, 375);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(300, 50);
            signInBtn.TabIndex = 6;
            signInBtn.Text = "Sign In";
            signInBtn.UseVisualStyleBackColor = false;
            signInBtn.Click += signInBtn_Click;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signUpLabel.ForeColor = Color.Black;
            signUpLabel.Location = new Point(203, 452);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(194, 24);
            signUpLabel.TabIndex = 7;
            signUpLabel.Text = "Don't have an account?";
            // 
            // signUpLink
            // 
            signUpLink.AutoSize = true;
            signUpLink.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            signUpLink.ForeColor = Color.Black;
            signUpLink.Location = new Point(424, 452);
            signUpLink.Name = "signUpLink";
            signUpLink.Size = new Size(151, 24);
            signUpLink.TabIndex = 10;
            signUpLink.Text = "Create an account";
            signUpLink.Click += signUpLink_Click;
            // 
            // loginExitIcon
            // 
            loginExitIcon.BackgroundImage = (Image)resources.GetObject("loginExitIcon.BackgroundImage");
            loginExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            loginExitIcon.Location = new Point(763, 12);
            loginExitIcon.Name = "loginExitIcon";
            loginExitIcon.Size = new Size(25, 25);
            loginExitIcon.TabIndex = 11;
            loginExitIcon.TabStop = false;
            loginExitIcon.Click += loginExitIcon_Click;
            // 
            // LoginDesign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 510);
            Controls.Add(loginExitIcon);
            Controls.Add(signUpLink);
            Controls.Add(signUpLabel);
            Controls.Add(signInBtn);
            Controls.Add(showPassCBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(signInLabel);
            Controls.Add(Logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginDesign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label signInLabel;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label passwordLabel;
        private CheckBox showPassCBox;
        private Button signInBtn;
        private Label signUpLabel;
        private Label signUpLink;
        private PictureBox loginExitIcon;
    }
}