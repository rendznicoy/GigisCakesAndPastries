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
            this.exitIcon = new PictureBox();
            this.FillInfoLabel = new Label();
            this.firstNameBox = new TextBox();
            this.middleNameBox = new TextBox();
            this.lastNameBox = new TextBox();
            this.firstNameLabel = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.emailBox = new TextBox();
            this.label4 = new Label();
            this.phoneNumberBox = new TextBox();
            this.label5 = new Label();
            this.addressBox = new TextBox();
            this.stepTwoNextBtn = new Button();
            this.usernameHide = new Label();
            this.passwordHide = new Label();
            this.birthMonthHide = new Label();
            this.birthDateHide = new Label();
            this.birthYearHide = new Label();
            ((System.ComponentModel.ISupportInitialize)this.exitIcon).BeginInit();
            SuspendLayout();
            // 
            // exitIcon
            // 
            this.exitIcon.BackgroundImage = (Image)resources.GetObject("exitIcon.BackgroundImage");
            this.exitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.exitIcon.Location = new Point(12, 12);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new Size(25, 25);
            this.exitIcon.TabIndex = 13;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += exitIcon_Click;
            // 
            // FillInfoLabel
            // 
            this.FillInfoLabel.AutoSize = true;
            this.FillInfoLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.FillInfoLabel.ForeColor = Color.Black;
            this.FillInfoLabel.Location = new Point(90, 80);
            this.FillInfoLabel.Name = "FillInfoLabel";
            this.FillInfoLabel.Size = new Size(378, 46);
            this.FillInfoLabel.TabIndex = 14;
            this.FillInfoLabel.Text = "Fill In Your Information";
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = Color.White;
            this.firstNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.firstNameBox.Location = new Point(100, 160);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new Size(350, 30);
            this.firstNameBox.TabIndex = 15;
            // 
            // middleNameBox
            // 
            this.middleNameBox.BackColor = Color.White;
            this.middleNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.middleNameBox.Location = new Point(100, 212);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new Size(350, 30);
            this.middleNameBox.TabIndex = 20;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = Color.White;
            this.lastNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lastNameBox.Location = new Point(100, 264);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new Size(350, 30);
            this.lastNameBox.TabIndex = 21;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = Color.Black;
            this.firstNameLabel.Location = new Point(100, 141);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new Size(63, 16);
            this.firstNameLabel.TabIndex = 22;
            this.firstNameLabel.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(100, 193);
            this.label1.Name = "label1";
            this.label1.Size = new Size(74, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(101, 245);
            this.label2.Name = "label2";
            this.label2.Size = new Size(54, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(101, 297);
            this.label3.Name = "label3";
            this.label3.Size = new Size(35, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = Color.White;
            this.emailBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.emailBox.Location = new Point(101, 316);
            this.emailBox.Name = "emailBox";
            this.emailBox.PlaceholderText = "example@email.com";
            this.emailBox.Size = new Size(350, 30);
            this.emailBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(101, 349);
            this.label4.Name = "label4";
            this.label4.Size = new Size(85, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phone Number";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.BackColor = Color.White;
            this.phoneNumberBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.phoneNumberBox.Location = new Point(100, 368);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.PlaceholderText = "XXXX-XXX-XXXX";
            this.phoneNumberBox.Size = new Size(350, 30);
            this.phoneNumberBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.label5.ForeColor = Color.Black;
            this.label5.Location = new Point(101, 401);
            this.label5.Name = "label5";
            this.label5.Size = new Size(73, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Full Address";
            // 
            // addressBox
            // 
            this.addressBox.BackColor = Color.White;
            this.addressBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.addressBox.Location = new Point(101, 420);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new Size(350, 30);
            this.addressBox.TabIndex = 30;
            // 
            // stepTwoNextBtn
            // 
            this.stepTwoNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.stepTwoNextBtn.FlatAppearance.BorderSize = 0;
            this.stepTwoNextBtn.FlatStyle = FlatStyle.Flat;
            this.stepTwoNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.stepTwoNextBtn.ForeColor = Color.White;
            this.stepTwoNextBtn.Location = new Point(100, 470);
            this.stepTwoNextBtn.Name = "stepTwoNextBtn";
            this.stepTwoNextBtn.Size = new Size(350, 50);
            this.stepTwoNextBtn.TabIndex = 31;
            this.stepTwoNextBtn.Text = "Sign Up";
            this.stepTwoNextBtn.UseVisualStyleBackColor = false;
            this.stepTwoNextBtn.Click += stepTwoNextBtn_Click;
            // 
            // usernameHide
            // 
            this.usernameHide.AutoSize = true;
            this.usernameHide.Location = new Point(233, 101);
            this.usernameHide.Name = "usernameHide";
            this.usernameHide.Size = new Size(50, 20);
            this.usernameHide.TabIndex = 32;
            this.usernameHide.Text = "label6";
            // 
            // passwordHide
            // 
            this.passwordHide.AutoSize = true;
            this.passwordHide.Location = new Point(289, 101);
            this.passwordHide.Name = "passwordHide";
            this.passwordHide.Size = new Size(50, 20);
            this.passwordHide.TabIndex = 33;
            this.passwordHide.Text = "label6";
            // 
            // birthMonthHide
            // 
            this.birthMonthHide.AutoSize = true;
            this.birthMonthHide.Location = new Point(101, 106);
            this.birthMonthHide.Name = "birthMonthHide";
            this.birthMonthHide.Size = new Size(50, 20);
            this.birthMonthHide.TabIndex = 34;
            this.birthMonthHide.Text = "label6";
            // 
            // birthDateHide
            // 
            this.birthDateHide.AutoSize = true;
            this.birthDateHide.Location = new Point(168, 106);
            this.birthDateHide.Name = "birthDateHide";
            this.birthDateHide.Size = new Size(50, 20);
            this.birthDateHide.TabIndex = 35;
            this.birthDateHide.Text = "label6";
            // 
            // birthYearHide
            // 
            this.birthYearHide.AutoSize = true;
            this.birthYearHide.Location = new Point(250, 106);
            this.birthYearHide.Name = "birthYearHide";
            this.birthYearHide.Size = new Size(50, 20);
            this.birthYearHide.TabIndex = 36;
            this.birthYearHide.Text = "label6";
            // 
            // InfoFillPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 575);
            Controls.Add(this.stepTwoNextBtn);
            Controls.Add(this.addressBox);
            Controls.Add(this.label5);
            Controls.Add(this.phoneNumberBox);
            Controls.Add(this.label4);
            Controls.Add(this.emailBox);
            Controls.Add(this.label3);
            Controls.Add(this.label2);
            Controls.Add(this.label1);
            Controls.Add(this.firstNameLabel);
            Controls.Add(this.lastNameBox);
            Controls.Add(this.middleNameBox);
            Controls.Add(this.firstNameBox);
            Controls.Add(this.FillInfoLabel);
            Controls.Add(this.exitIcon);
            Controls.Add(this.usernameHide);
            Controls.Add(this.passwordHide);
            Controls.Add(this.birthMonthHide);
            Controls.Add(this.birthDateHide);
            Controls.Add(this.birthYearHide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoFillPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoFillPage";
            Load += InfoFillPage_Load;
            ((System.ComponentModel.ISupportInitialize)this.exitIcon).EndInit();
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