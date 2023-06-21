namespace GigisCakesAndPastriesGUI
{
    partial class ManualAddPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualAddPage));
            mnlShowPassCBox = new CheckBox();
            mnlConfirmPassBox = new TextBox();
            mnlYearPicker = new ComboBox();
            mnlDayPicker = new ComboBox();
            mnlMonthPicker = new ComboBox();
            mnlExitIcon = new PictureBox();
            mnlStepOneNextBtn = new Button();
            mnlBirthdateLabel2 = new Label();
            mnlBirthDateLabel = new Label();
            mnlCreateAccPassBox = new TextBox();
            mnlCreateAccUserBox = new TextBox();
            mnlCreateAccLabel = new Label();
            mnlCreateAccLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mnlShowPassCBox
            // 
            mnlShowPassCBox.AutoSize = true;
            mnlShowPassCBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mnlShowPassCBox.ForeColor = Color.Black;
            mnlShowPassCBox.Location = new Point(100, 358);
            mnlShowPassCBox.Name = "mnlShowPassCBox";
            mnlShowPassCBox.Size = new Size(126, 24);
            mnlShowPassCBox.TabIndex = 30;
            mnlShowPassCBox.Text = "Show Password";
            mnlShowPassCBox.UseVisualStyleBackColor = true;
            mnlShowPassCBox.CheckedChanged += mnlShowPassCBox_CheckedChanged;
            // 
            // mnlConfirmPassBox
            // 
            mnlConfirmPassBox.BackColor = Color.White;
            mnlConfirmPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnlConfirmPassBox.Location = new Point(100, 322);
            mnlConfirmPassBox.Name = "mnlConfirmPassBox";
            mnlConfirmPassBox.PlaceholderText = "Confirm Password";
            mnlConfirmPassBox.Size = new Size(350, 30);
            mnlConfirmPassBox.TabIndex = 29;
            mnlConfirmPassBox.KeyPress += mnlConfirmPassBox_KeyPress;
            // 
            // mnlYearPicker
            // 
            mnlYearPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mnlYearPicker.FormattingEnabled = true;
            mnlYearPicker.Items.AddRange(new object[] { "" });
            mnlYearPicker.Location = new Point(350, 442);
            mnlYearPicker.Name = "mnlYearPicker";
            mnlYearPicker.Size = new Size(100, 30);
            mnlYearPicker.TabIndex = 28;
            mnlYearPicker.Text = "Year";
            mnlYearPicker.KeyPress += mnlYearPicker_KeyPress;
            // 
            // mnlDayPicker
            // 
            mnlDayPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mnlDayPicker.FormattingEnabled = true;
            mnlDayPicker.Items.AddRange(new object[] { "" });
            mnlDayPicker.Location = new Point(225, 442);
            mnlDayPicker.Name = "mnlDayPicker";
            mnlDayPicker.Size = new Size(100, 30);
            mnlDayPicker.TabIndex = 27;
            mnlDayPicker.Text = "Day";
            // 
            // mnlMonthPicker
            // 
            mnlMonthPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mnlMonthPicker.FormattingEnabled = true;
            mnlMonthPicker.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            mnlMonthPicker.Location = new Point(100, 442);
            mnlMonthPicker.Name = "mnlMonthPicker";
            mnlMonthPicker.Size = new Size(100, 30);
            mnlMonthPicker.TabIndex = 26;
            mnlMonthPicker.Text = "Month";
            mnlMonthPicker.SelectedIndexChanged += mnlMonthPicker_SelectedIndexChanged_1;
            // 
            // mnlExitIcon
            // 
            mnlExitIcon.BackgroundImage = (Image)resources.GetObject("mnlExitIcon.BackgroundImage");
            mnlExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            mnlExitIcon.Location = new Point(12, 12);
            mnlExitIcon.Name = "mnlExitIcon";
            mnlExitIcon.Size = new Size(25, 25);
            mnlExitIcon.TabIndex = 25;
            mnlExitIcon.TabStop = false;
            mnlExitIcon.Click += mnlExitIcon_Click_1;
            // 
            // mnlStepOneNextBtn
            // 
            mnlStepOneNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            mnlStepOneNextBtn.FlatAppearance.BorderSize = 0;
            mnlStepOneNextBtn.FlatStyle = FlatStyle.Flat;
            mnlStepOneNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            mnlStepOneNextBtn.ForeColor = Color.White;
            mnlStepOneNextBtn.Location = new Point(100, 502);
            mnlStepOneNextBtn.Name = "mnlStepOneNextBtn";
            mnlStepOneNextBtn.Size = new Size(350, 50);
            mnlStepOneNextBtn.TabIndex = 23;
            mnlStepOneNextBtn.Text = "Next";
            mnlStepOneNextBtn.UseVisualStyleBackColor = false;
            mnlStepOneNextBtn.Click += mnlStepOneNextBtn_Click_1;
            // 
            // mnlBirthdateLabel2
            // 
            mnlBirthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnlBirthdateLabel2.ForeColor = Color.DimGray;
            mnlBirthdateLabel2.Location = new Point(100, 402);
            mnlBirthdateLabel2.Name = "mnlBirthdateLabel2";
            mnlBirthdateLabel2.Size = new Size(365, 37);
            mnlBirthdateLabel2.TabIndex = 22;
            mnlBirthdateLabel2.Text = "Confirm your age, even if this account is for a business, pet, or any other non-person entity.";
            // 
            // mnlBirthDateLabel
            // 
            mnlBirthDateLabel.AutoSize = true;
            mnlBirthDateLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mnlBirthDateLabel.ForeColor = Color.Black;
            mnlBirthDateLabel.Location = new Point(100, 382);
            mnlBirthDateLabel.Name = "mnlBirthDateLabel";
            mnlBirthDateLabel.Size = new Size(74, 22);
            mnlBirthDateLabel.TabIndex = 21;
            mnlBirthDateLabel.Text = "Birthdate";
            // 
            // mnlCreateAccPassBox
            // 
            mnlCreateAccPassBox.BackColor = Color.White;
            mnlCreateAccPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnlCreateAccPassBox.Location = new Point(100, 262);
            mnlCreateAccPassBox.Name = "mnlCreateAccPassBox";
            mnlCreateAccPassBox.PlaceholderText = "Enter Password";
            mnlCreateAccPassBox.Size = new Size(350, 30);
            mnlCreateAccPassBox.TabIndex = 20;
            mnlCreateAccPassBox.KeyPress += mnlCreateAccPassBox_KeyPress;
            // 
            // mnlCreateAccUserBox
            // 
            mnlCreateAccUserBox.BackColor = Color.White;
            mnlCreateAccUserBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnlCreateAccUserBox.Location = new Point(100, 202);
            mnlCreateAccUserBox.Name = "mnlCreateAccUserBox";
            mnlCreateAccUserBox.PlaceholderText = "Enter Username";
            mnlCreateAccUserBox.Size = new Size(350, 30);
            mnlCreateAccUserBox.TabIndex = 19;
            mnlCreateAccUserBox.KeyPress += mnlCreateAccUserBox_KeyPress;
            // 
            // mnlCreateAccLabel
            // 
            mnlCreateAccLabel.AutoSize = true;
            mnlCreateAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mnlCreateAccLabel.ForeColor = Color.Black;
            mnlCreateAccLabel.Location = new Point(100, 132);
            mnlCreateAccLabel.Name = "mnlCreateAccLabel";
            mnlCreateAccLabel.Size = new Size(336, 46);
            mnlCreateAccLabel.TabIndex = 18;
            mnlCreateAccLabel.Text = "Create your account";
            // 
            // mnlCreateAccLogo
            // 
            mnlCreateAccLogo.BackgroundImage = (Image)resources.GetObject("mnlCreateAccLogo.BackgroundImage");
            mnlCreateAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            mnlCreateAccLogo.Location = new Point(225, 32);
            mnlCreateAccLogo.Name = "mnlCreateAccLogo";
            mnlCreateAccLogo.Size = new Size(110, 108);
            mnlCreateAccLogo.TabIndex = 24;
            mnlCreateAccLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(513, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ManualAddPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(pictureBox1);
            Controls.Add(mnlShowPassCBox);
            Controls.Add(mnlConfirmPassBox);
            Controls.Add(mnlYearPicker);
            Controls.Add(mnlDayPicker);
            Controls.Add(mnlMonthPicker);
            Controls.Add(mnlExitIcon);
            Controls.Add(mnlStepOneNextBtn);
            Controls.Add(mnlBirthdateLabel2);
            Controls.Add(mnlBirthDateLabel);
            Controls.Add(mnlCreateAccPassBox);
            Controls.Add(mnlCreateAccUserBox);
            Controls.Add(mnlCreateAccLabel);
            Controls.Add(mnlCreateAccLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManualAddPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManualAddPage";
            Load += ManualAddPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox mnlShowPassCBox;
        public TextBox mnlConfirmPassBox;
        public ComboBox mnlYearPicker;
        public ComboBox mnlDayPicker;
        public ComboBox mnlMonthPicker;
        private PictureBox mnlExitIcon;
        private Button mnlStepOneNextBtn;
        private Label mnlBirthdateLabel2;
        private Label mnlBirthDateLabel;
        public TextBox mnlCreateAccPassBox;
        public TextBox mnlCreateAccUserBox;
        private Label mnlCreateAccLabel;
        private PictureBox mnlCreateAccLogo;
        private PictureBox pictureBox1;
    }
}