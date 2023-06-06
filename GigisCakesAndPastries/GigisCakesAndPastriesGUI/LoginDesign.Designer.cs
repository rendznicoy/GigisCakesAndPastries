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
            this.Logo = new PictureBox();
            this.signInLabel = new Label();
            this.usernameBox = new TextBox();
            this.passwordBox = new TextBox();
            this.passwordLabel = new Label();
            this.showPassCBox = new CheckBox();
            this.signInBtn = new Button();
            this.signUpLabel = new Label();
            this.signUpLink = new Label();
            this.loginExitIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.loginExitIcon).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = Color.Transparent;
            this.Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            this.Logo.BackgroundImageLayout = ImageLayout.Stretch;
            this.Logo.Location = new Point(150, -160);
            this.Logo.Name = "Logo";
            this.Logo.Size = new Size(500, 500);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.signInLabel.ForeColor = Color.Black;
            this.signInLabel.Location = new Point(225, 160);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new Size(172, 16);
            this.signInLabel.TabIndex = 1;
            this.signInLabel.Text = "SIGN IN WITH ACCOUNT NAME";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = Color.White;
            this.usernameBox.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.usernameBox.Location = new Point(225, 180);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PlaceholderText = "Enter Username";
            this.usernameBox.Size = new Size(350, 27);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = Color.White;
            this.passwordBox.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.passwordBox.Location = new Point(225, 275);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceholderText = "Enter Password";
            this.passwordBox.Size = new Size(350, 27);
            this.passwordBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.passwordLabel.ForeColor = Color.Black;
            this.passwordLabel.Location = new Point(225, 255);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new Size(72, 16);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // showPassCBox
            // 
            this.showPassCBox.AutoSize = true;
            this.showPassCBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.showPassCBox.ForeColor = Color.Black;
            this.showPassCBox.Location = new Point(225, 325);
            this.showPassCBox.Name = "showPassCBox";
            this.showPassCBox.Size = new Size(126, 24);
            this.showPassCBox.TabIndex = 5;
            this.showPassCBox.Text = "Show Password";
            this.showPassCBox.UseVisualStyleBackColor = true;
            this.showPassCBox.CheckedChanged += showPassCBox_CheckedChanged;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = FlatStyle.Flat;
            this.signInBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.signInBtn.ForeColor = Color.White;
            this.signInBtn.Location = new Point(253, 375);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new Size(300, 50);
            this.signInBtn.TabIndex = 6;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += signInBtn_Click;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.signUpLabel.ForeColor = Color.Black;
            this.signUpLabel.Location = new Point(203, 452);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new Size(194, 24);
            this.signUpLabel.TabIndex = 7;
            this.signUpLabel.Text = "Don't have an account?";
            // 
            // signUpLink
            // 
            this.signUpLink.AutoSize = true;
            this.signUpLink.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            this.signUpLink.ForeColor = Color.Black;
            this.signUpLink.Location = new Point(424, 452);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new Size(151, 24);
            this.signUpLink.TabIndex = 10;
            this.signUpLink.Text = "Create an account";
            this.signUpLink.Click += signUpLink_Click;
            // 
            // loginExitIcon
            // 
            this.loginExitIcon.BackgroundImage = (Image)resources.GetObject("loginExitIcon.BackgroundImage");
            this.loginExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.loginExitIcon.Location = new Point(763, 12);
            this.loginExitIcon.Name = "loginExitIcon";
            this.loginExitIcon.Size = new Size(25, 25);
            this.loginExitIcon.TabIndex = 11;
            this.loginExitIcon.TabStop = false;
            this.loginExitIcon.Click += loginExitIcon_Click;
            // 
            // LoginDesign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 510);
            Controls.Add(this.loginExitIcon);
            Controls.Add(this.signUpLink);
            Controls.Add(this.signUpLabel);
            Controls.Add(this.signInBtn);
            Controls.Add(this.showPassCBox);
            Controls.Add(this.passwordLabel);
            Controls.Add(this.passwordBox);
            Controls.Add(this.usernameBox);
            Controls.Add(this.signInLabel);
            Controls.Add(this.Logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginDesign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.loginExitIcon).EndInit();
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