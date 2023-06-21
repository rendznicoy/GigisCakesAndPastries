namespace GigisCakesAndPastriesGUI
{
    partial class EditRecipient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecipient));
            stepTwoNextBtn = new Button();
            addressBox = new TextBox();
            label5 = new Label();
            phoneNumberBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            firstNameLabel = new Label();
            lastNameBox = new TextBox();
            middleNameBox = new TextBox();
            firstNameBox = new TextBox();
            FillInfoLabel = new Label();
            exitIcon = new PictureBox();
            usernameHide = new Label();
            passwordHide = new Label();
            birthMonthHide = new Label();
            birthDateHide = new Label();
            birthYearHide = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            stepTwoNextBtn.TabIndex = 71;
            stepTwoNextBtn.Text = "Save";
            stepTwoNextBtn.UseVisualStyleBackColor = false;
            stepTwoNextBtn.Click += stepTwoNextBtn_Click;
            // 
            // addressBox
            // 
            addressBox.BackColor = Color.White;
            addressBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressBox.Location = new Point(99, 400);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(350, 30);
            addressBox.TabIndex = 70;
            addressBox.KeyPress += addressBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(100, 381);
            label5.Name = "label5";
            label5.Size = new Size(73, 16);
            label5.TabIndex = 69;
            label5.Text = "Full Address";
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.BackColor = Color.White;
            phoneNumberBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberBox.Location = new Point(99, 340);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.PlaceholderText = "XXXX-XXX-XXXX";
            phoneNumberBox.Size = new Size(350, 30);
            phoneNumberBox.TabIndex = 68;
            phoneNumberBox.KeyPress += phoneNumberBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(100, 321);
            label4.Name = "label4";
            label4.Size = new Size(85, 16);
            label4.TabIndex = 67;
            label4.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(100, 261);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 64;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 201);
            label1.Name = "label1";
            label1.Size = new Size(74, 16);
            label1.TabIndex = 63;
            label1.Text = "Middle Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.Black;
            firstNameLabel.Location = new Point(100, 141);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(63, 16);
            firstNameLabel.TabIndex = 62;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameBox
            // 
            lastNameBox.BackColor = Color.White;
            lastNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameBox.Location = new Point(100, 280);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(350, 30);
            lastNameBox.TabIndex = 61;
            lastNameBox.KeyPress += lastNameBox_KeyPress;
            // 
            // middleNameBox
            // 
            middleNameBox.BackColor = Color.White;
            middleNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            middleNameBox.Location = new Point(100, 220);
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Size = new Size(350, 30);
            middleNameBox.TabIndex = 60;
            middleNameBox.KeyPress += middleNameBox_KeyPress;
            // 
            // firstNameBox
            // 
            firstNameBox.BackColor = Color.White;
            firstNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameBox.Location = new Point(100, 160);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(350, 30);
            firstNameBox.TabIndex = 59;
            firstNameBox.KeyPress += firstNameBox_KeyPress;
            // 
            // FillInfoLabel
            // 
            FillInfoLabel.AutoSize = true;
            FillInfoLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            FillInfoLabel.ForeColor = Color.Black;
            FillInfoLabel.Location = new Point(95, 80);
            FillInfoLabel.Name = "FillInfoLabel";
            FillInfoLabel.Size = new Size(354, 46);
            FillInfoLabel.TabIndex = 58;
            FillInfoLabel.Text = "Edit Recipient Details";
            // 
            // exitIcon
            // 
            exitIcon.BackgroundImage = (Image)resources.GetObject("exitIcon.BackgroundImage");
            exitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            exitIcon.Location = new Point(12, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(25, 25);
            exitIcon.TabIndex = 57;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // usernameHide
            // 
            usernameHide.AutoSize = true;
            usernameHide.Location = new Point(202, 106);
            usernameHide.Name = "usernameHide";
            usernameHide.Size = new Size(50, 20);
            usernameHide.TabIndex = 72;
            usernameHide.Text = "label6";
            // 
            // passwordHide
            // 
            passwordHide.AutoSize = true;
            passwordHide.Location = new Point(314, 106);
            passwordHide.Name = "passwordHide";
            passwordHide.Size = new Size(50, 20);
            passwordHide.TabIndex = 73;
            passwordHide.Text = "label6";
            // 
            // birthMonthHide
            // 
            birthMonthHide.AutoSize = true;
            birthMonthHide.Location = new Point(90, 106);
            birthMonthHide.Name = "birthMonthHide";
            birthMonthHide.Size = new Size(50, 20);
            birthMonthHide.TabIndex = 74;
            birthMonthHide.Text = "label6";
            // 
            // birthDateHide
            // 
            birthDateHide.AutoSize = true;
            birthDateHide.Location = new Point(146, 101);
            birthDateHide.Name = "birthDateHide";
            birthDateHide.Size = new Size(50, 20);
            birthDateHide.TabIndex = 75;
            birthDateHide.Text = "label6";
            // 
            // birthYearHide
            // 
            birthYearHide.AutoSize = true;
            birthYearHide.Location = new Point(258, 106);
            birthYearHide.Name = "birthYearHide";
            birthYearHide.Size = new Size(50, 20);
            birthYearHide.TabIndex = 76;
            birthYearHide.Text = "label6";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(513, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EditRecipient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 575);
            Controls.Add(pictureBox1);
            Controls.Add(stepTwoNextBtn);
            Controls.Add(addressBox);
            Controls.Add(label5);
            Controls.Add(phoneNumberBox);
            Controls.Add(label4);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditRecipient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditRecipient";
            Load += EditRecipient_Load;
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stepTwoNextBtn;
        public TextBox addressBox;
        private Label label5;
        public TextBox phoneNumberBox;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label firstNameLabel;
        public TextBox lastNameBox;
        public TextBox middleNameBox;
        public TextBox firstNameBox;
        private Label FillInfoLabel;
        private PictureBox exitIcon;
        public Label usernameHide;
        public Label passwordHide;
        public Label birthMonthHide;
        public Label birthDateHide;
        public Label birthYearHide;
        private PictureBox pictureBox1;
    }
}