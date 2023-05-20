namespace GigisCakesAndPastriesGUI
{
    partial class CreateAccountPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountPage));
            this.createAccLabel = new Label();
            this.nameBox = new TextBox();
            this.emailBox = new TextBox();
            this.birthDateLabel = new Label();
            this.birthdateLabel2 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.signInBtn = new Button();
            this.createAccLogo = new PictureBox();
            this.exitIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.createAccLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.exitIcon).BeginInit();
            SuspendLayout();
            // 
            // createAccLabel
            // 
            this.createAccLabel.AutoSize = true;
            this.createAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.createAccLabel.ForeColor = Color.Black;
            this.createAccLabel.Location = new Point(100, 100);
            this.createAccLabel.Name = "createAccLabel";
            this.createAccLabel.Size = new Size(336, 46);
            this.createAccLabel.TabIndex = 1;
            this.createAccLabel.Text = "Create your account";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = Color.White;
            this.nameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.nameBox.Location = new Point(100, 170);
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "Enter Name (Not Username)";
            this.nameBox.Size = new Size(350, 30);
            this.nameBox.TabIndex = 3;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = Color.White;
            this.emailBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.emailBox.Location = new Point(100, 230);
            this.emailBox.Name = "emailBox";
            this.emailBox.PlaceholderText = "Enter Email";
            this.emailBox.Size = new Size(350, 30);
            this.emailBox.TabIndex = 4;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.birthDateLabel.ForeColor = Color.Black;
            this.birthDateLabel.Location = new Point(100, 280);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new Size(74, 22);
            this.birthDateLabel.TabIndex = 5;
            this.birthDateLabel.Text = "Birthdate";
            // 
            // birthdateLabel2
            // 
            this.birthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.birthdateLabel2.ForeColor = Color.DimGray;
            this.birthdateLabel2.Location = new Point(100, 310);
            this.birthdateLabel2.Name = "birthdateLabel2";
            this.birthdateLabel2.Size = new Size(365, 37);
            this.birthdateLabel2.TabIndex = 6;
            this.birthdateLabel2.Text = "Confirm your age, even if this account is for a business, pet, or any other non-person entity.";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new Point(100, 360);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(350, 27);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = FlatStyle.Flat;
            this.signInBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.signInBtn.ForeColor = Color.White;
            this.signInBtn.Location = new Point(100, 470);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new Size(350, 50);
            this.signInBtn.TabIndex = 10;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = false;
            // 
            // createAccLogo
            // 
            this.createAccLogo.BackgroundImage = (Image)resources.GetObject("createAccLogo.BackgroundImage");
            this.createAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            this.createAccLogo.Location = new Point(225, 0);
            this.createAccLogo.Name = "createAccLogo";
            this.createAccLogo.Size = new Size(110, 108);
            this.createAccLogo.TabIndex = 11;
            this.createAccLogo.TabStop = false;
            // 
            // exitIcon
            // 
            this.exitIcon.BackgroundImage = (Image)resources.GetObject("exitIcon.BackgroundImage");
            this.exitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.exitIcon.Location = new Point(12, 12);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new Size(25, 25);
            this.exitIcon.TabIndex = 12;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += exitIcon_Click;
            // 
            // CreateAccountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 575);
            Controls.Add(this.exitIcon);
            Controls.Add(this.signInBtn);
            Controls.Add(this.dateTimePicker2);
            Controls.Add(this.birthdateLabel2);
            Controls.Add(this.birthDateLabel);
            Controls.Add(this.emailBox);
            Controls.Add(this.nameBox);
            Controls.Add(this.createAccLabel);
            Controls.Add(this.createAccLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccountPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccountPage";
            ((System.ComponentModel.ISupportInitialize)this.createAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createAccLabel;
        private TextBox nameBox;
        private TextBox emailBox;
        private Label birthDateLabel;
        private Label birthdateLabel2;
        private DateTimePicker dateTimePicker2;
        private Button signInBtn;
        private PictureBox createAccLogo;
        private PictureBox exitIcon;
    }
}