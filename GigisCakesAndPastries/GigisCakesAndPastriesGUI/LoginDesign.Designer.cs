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
            this.logoBox = new PictureBox();
            this.signInLabel = new Label();
            this.usernameBox = new TextBox();
            this.passwordBox = new TextBox();
            this.passwordLabel = new Label();
            this.showPassCBox = new CheckBox();
            this.signInBtn = new Button();
            this.signUpLabel = new Label();
            this.signUpLink = new Label();
            ((System.ComponentModel.ISupportInitialize)this.logoBox).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.BackColor = Color.Transparent;
            this.logoBox.BackgroundImage = (Image)resources.GetObject("logoBox.BackgroundImage");
            this.logoBox.BackgroundImageLayout = ImageLayout.Stretch;
            this.logoBox.Location = new Point(150, -160);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new Size(500, 500);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
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
            this.usernameBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            this.usernameBox.Location = new Point(225, 180);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new Size(350, 30);
            this.usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = Color.White;
            this.passwordBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            this.passwordBox.Location = new Point(225, 275);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new Size(350, 30);
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
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = Color.Black;
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
            this.signUpLink.Location = new Point(414, 452);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new Size(182, 24);
            this.signUpLink.TabIndex = 8;
            this.signUpLink.Text = "Create a Free Account";
            // 
            // LoginDesign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 510);
            Controls.Add(this.signUpLink);
            Controls.Add(this.signUpLabel);
            Controls.Add(this.signInBtn);
            Controls.Add(this.showPassCBox);
            Controls.Add(this.passwordLabel);
            Controls.Add(this.passwordBox);
            Controls.Add(this.usernameBox);
            Controls.Add(this.signInLabel);
            Controls.Add(this.logoBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginDesign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoBox;
        private Label signInLabel;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label passwordLabel;
        private CheckBox showPassCBox;
        private Button signInBtn;
        private Label signUpLabel;
        private Label signUpLink;
    }
}