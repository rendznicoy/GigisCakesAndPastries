namespace GigisCakesAndPastriesGUI
{
    partial class InfoFillPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoFillPage));
            exitIcon = new PictureBox();
            FillInfoLabel = new Label();
            firstNameBox = new TextBox();
            middleNameBox = new TextBox();
            lastNameBox = new TextBox();
            firstNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            phoneNumberBox = new TextBox();
            label5 = new Label();
            addressBox = new TextBox();
            stepTwoNextBtn = new Button();
            usernameHide = new Label();
            passwordHide = new Label();
            birthMonthHide = new Label();
            birthDateHide = new Label();
            birthYearHide = new Label();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            SuspendLayout();
            // 
            // exitIcon
            // 
            exitIcon.BackgroundImage = (Image)resources.GetObject("exitIcon.BackgroundImage");
            exitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            exitIcon.Location = new Point(12, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(25, 25);
            exitIcon.TabIndex = 13;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // FillInfoLabel
            // 
            FillInfoLabel.AutoSize = true;
            FillInfoLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            FillInfoLabel.ForeColor = Color.Black;
            FillInfoLabel.Location = new Point(90, 80);
            FillInfoLabel.Name = "FillInfoLabel";
            FillInfoLabel.Size = new Size(378, 46);
            FillInfoLabel.TabIndex = 14;
            FillInfoLabel.Text = "Fill In Your Information";
            // 
            // firstNameBox
            // 
            firstNameBox.BackColor = Color.White;
            firstNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameBox.Location = new Point(100, 160);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(350, 30);
            firstNameBox.TabIndex = 15;
            firstNameBox.KeyPress += firstNameBox_KeyPress;
            // 
            // middleNameBox
            // 
            middleNameBox.BackColor = Color.White;
            middleNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            middleNameBox.Location = new Point(100, 212);
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Size = new Size(350, 30);
            middleNameBox.TabIndex = 20;
            middleNameBox.KeyPress += middleNameBox_KeyPress;
            // 
            // lastNameBox
            // 
            lastNameBox.BackColor = Color.White;
            lastNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameBox.Location = new Point(100, 264);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(350, 30);
            lastNameBox.TabIndex = 21;
            lastNameBox.KeyPress += lastNameBox_KeyPress;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.Black;
            firstNameLabel.Location = new Point(100, 141);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(63, 16);
            firstNameLabel.TabIndex = 22;
            firstNameLabel.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 193);
            label1.Name = "label1";
            label1.Size = new Size(74, 16);
            label1.TabIndex = 23;
            label1.Text = "Middle Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(101, 245);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 24;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(101, 297);
            label3.Name = "label3";
            label3.Size = new Size(35, 16);
            label3.TabIndex = 25;
            label3.Text = "Email";
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.White;
            emailBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailBox.Location = new Point(101, 316);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "example@email.com";
            emailBox.Size = new Size(350, 30);
            emailBox.TabIndex = 26;
            emailBox.KeyPress += emailBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(101, 349);
            label4.Name = "label4";
            label4.Size = new Size(85, 16);
            label4.TabIndex = 27;
            label4.Text = "Phone Number";
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.BackColor = Color.White;
            phoneNumberBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberBox.Location = new Point(100, 368);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.PlaceholderText = "XXXX-XXX-XXXX";
            phoneNumberBox.Size = new Size(350, 30);
            phoneNumberBox.TabIndex = 28;
            phoneNumberBox.KeyPress += phoneNumberBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(101, 401);
            label5.Name = "label5";
            label5.Size = new Size(73, 16);
            label5.TabIndex = 29;
            label5.Text = "Full Address";
            // 
            // addressBox
            // 
            addressBox.BackColor = Color.White;
            addressBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressBox.Location = new Point(101, 420);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(350, 30);
            addressBox.TabIndex = 30;
            addressBox.KeyPress += addressBox_KeyPress;
            // 
            // stepTwoNextBtn
            // 
            stepTwoNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            stepTwoNextBtn.FlatAppearance.BorderSize = 0;
            stepTwoNextBtn.FlatStyle = FlatStyle.Flat;
            stepTwoNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            stepTwoNextBtn.ForeColor = Color.White;
            stepTwoNextBtn.Location = new Point(100, 470);
            stepTwoNextBtn.Name = "stepTwoNextBtn";
            stepTwoNextBtn.Size = new Size(350, 50);
            stepTwoNextBtn.TabIndex = 31;
            stepTwoNextBtn.Text = "Sign Up";
            stepTwoNextBtn.UseVisualStyleBackColor = false;
            stepTwoNextBtn.Click += stepTwoNextBtn_Click;
            // 
            // usernameHide
            // 
            usernameHide.AutoSize = true;
            usernameHide.Location = new Point(233, 101);
            usernameHide.Name = "usernameHide";
            usernameHide.Size = new Size(50, 20);
            usernameHide.TabIndex = 32;
            usernameHide.Text = "label6";
            // 
            // passwordHide
            // 
            passwordHide.AutoSize = true;
            passwordHide.Location = new Point(289, 101);
            passwordHide.Name = "passwordHide";
            passwordHide.Size = new Size(50, 20);
            passwordHide.TabIndex = 33;
            passwordHide.Text = "label6";
            // 
            // birthMonthHide
            // 
            birthMonthHide.AutoSize = true;
            birthMonthHide.Location = new Point(101, 106);
            birthMonthHide.Name = "birthMonthHide";
            birthMonthHide.Size = new Size(50, 20);
            birthMonthHide.TabIndex = 34;
            birthMonthHide.Text = "label6";
            // 
            // birthDateHide
            // 
            birthDateHide.AutoSize = true;
            birthDateHide.Location = new Point(168, 106);
            birthDateHide.Name = "birthDateHide";
            birthDateHide.Size = new Size(50, 20);
            birthDateHide.TabIndex = 35;
            birthDateHide.Text = "label6";
            // 
            // birthYearHide
            // 
            birthYearHide.AutoSize = true;
            birthYearHide.Location = new Point(250, 106);
            birthYearHide.Name = "birthYearHide";
            birthYearHide.Size = new Size(50, 20);
            birthYearHide.TabIndex = 36;
            birthYearHide.Text = "label6";
            // 
            // InfoFillPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 575);
            Controls.Add(stepTwoNextBtn);
            Controls.Add(addressBox);
            Controls.Add(label5);
            Controls.Add(phoneNumberBox);
            Controls.Add(label4);
            Controls.Add(emailBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameBox);
            Controls.Add(middleNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(FillInfoLabel);
            Controls.Add(exitIcon);
            Controls.Add(usernameHide);
            Controls.Add(passwordHide);
            Controls.Add(birthMonthHide);
            Controls.Add(birthDateHide);
            Controls.Add(birthYearHide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoFillPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoFillPage";
            Load += InfoFillPage_Load;
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox exitIcon;
        private Label FillInfoLabel;
        private TextBox firstNameBox;
        private TextBox middleNameBox;
        private TextBox lastNameBox;
        private Label firstNameLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emailBox;
        private Label label4;
        private TextBox phoneNumberBox;
        private Label label5;
        private TextBox addressBox;
        private Button stepTwoNextBtn;
        public Label usernameHide;
        public Label passwordHide;
        public Label birthMonthHide;
        public Label birthDateHide;
        public Label birthYearHide;
    }
}