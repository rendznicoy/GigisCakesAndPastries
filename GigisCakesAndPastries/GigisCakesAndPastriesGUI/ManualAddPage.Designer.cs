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
            this.mnlShowPassCBox = new CheckBox();
            this.mnlConfirmPassBox = new TextBox();
            this.mnlYearPicker = new ComboBox();
            this.mnlDayPicker = new ComboBox();
            this.mnlMonthPicker = new ComboBox();
            this.mnlExitIcon = new PictureBox();
            this.mnlStepOneNextBtn = new Button();
            this.mnlBirthdateLabel2 = new Label();
            this.mnlBirthDateLabel = new Label();
            this.mnlCreateAccPassBox = new TextBox();
            this.mnlCreateAccUserBox = new TextBox();
            this.mnlCreateAccLabel = new Label();
            this.mnlCreateAccLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.mnlExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.mnlCreateAccLogo).BeginInit();
            SuspendLayout();
            // 
            // mnlShowPassCBox
            // 
            this.mnlShowPassCBox.AutoSize = true;
            this.mnlShowPassCBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlShowPassCBox.ForeColor = Color.Black;
            this.mnlShowPassCBox.Location = new Point(100, 358);
            this.mnlShowPassCBox.Name = "mnlShowPassCBox";
            this.mnlShowPassCBox.Size = new Size(126, 24);
            this.mnlShowPassCBox.TabIndex = 30;
            this.mnlShowPassCBox.Text = "Show Password";
            this.mnlShowPassCBox.UseVisualStyleBackColor = true;
            this.mnlShowPassCBox.CheckedChanged += mnlShowPassCBox_CheckedChanged;
            // 
            // mnlConfirmPassBox
            // 
            this.mnlConfirmPassBox.BackColor = Color.White;
            this.mnlConfirmPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlConfirmPassBox.Location = new Point(100, 322);
            this.mnlConfirmPassBox.Name = "mnlConfirmPassBox";
            this.mnlConfirmPassBox.PlaceholderText = "Confirm Password";
            this.mnlConfirmPassBox.Size = new Size(350, 30);
            this.mnlConfirmPassBox.TabIndex = 29;
            // 
            // mnlYearPicker
            // 
            this.mnlYearPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.mnlYearPicker.FormattingEnabled = true;
            this.mnlYearPicker.Items.AddRange(new object[] { "" });
            this.mnlYearPicker.Location = new Point(350, 442);
            this.mnlYearPicker.Name = "mnlYearPicker";
            this.mnlYearPicker.Size = new Size(100, 30);
            this.mnlYearPicker.TabIndex = 28;
            this.mnlYearPicker.Text = "Year";
            // 
            // mnlDayPicker
            // 
            this.mnlDayPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.mnlDayPicker.FormattingEnabled = true;
            this.mnlDayPicker.Items.AddRange(new object[] { "" });
            this.mnlDayPicker.Location = new Point(225, 442);
            this.mnlDayPicker.Name = "mnlDayPicker";
            this.mnlDayPicker.Size = new Size(100, 30);
            this.mnlDayPicker.TabIndex = 27;
            this.mnlDayPicker.Text = "Day";
            // 
            // mnlMonthPicker
            // 
            this.mnlMonthPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.mnlMonthPicker.FormattingEnabled = true;
            this.mnlMonthPicker.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            this.mnlMonthPicker.Location = new Point(100, 442);
            this.mnlMonthPicker.Name = "mnlMonthPicker";
            this.mnlMonthPicker.Size = new Size(100, 30);
            this.mnlMonthPicker.TabIndex = 26;
            this.mnlMonthPicker.Text = "Month";
            this.mnlMonthPicker.SelectedIndexChanged += mnlMonthPicker_SelectedIndexChanged_1;
            // 
            // mnlExitIcon
            // 
            this.mnlExitIcon.BackgroundImage = (Image)resources.GetObject("mnlExitIcon.BackgroundImage");
            this.mnlExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.mnlExitIcon.Location = new Point(12, 12);
            this.mnlExitIcon.Name = "mnlExitIcon";
            this.mnlExitIcon.Size = new Size(25, 25);
            this.mnlExitIcon.TabIndex = 25;
            this.mnlExitIcon.TabStop = false;
            this.mnlExitIcon.Click += mnlExitIcon_Click_1;
            // 
            // mnlStepOneNextBtn
            // 
            this.mnlStepOneNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.mnlStepOneNextBtn.FlatAppearance.BorderSize = 0;
            this.mnlStepOneNextBtn.FlatStyle = FlatStyle.Flat;
            this.mnlStepOneNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlStepOneNextBtn.ForeColor = Color.White;
            this.mnlStepOneNextBtn.Location = new Point(100, 502);
            this.mnlStepOneNextBtn.Name = "mnlStepOneNextBtn";
            this.mnlStepOneNextBtn.Size = new Size(350, 50);
            this.mnlStepOneNextBtn.TabIndex = 23;
            this.mnlStepOneNextBtn.Text = "Next";
            this.mnlStepOneNextBtn.UseVisualStyleBackColor = false;
            this.mnlStepOneNextBtn.Click += mnlStepOneNextBtn_Click_1;
            // 
            // mnlBirthdateLabel2
            // 
            this.mnlBirthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlBirthdateLabel2.ForeColor = Color.DimGray;
            this.mnlBirthdateLabel2.Location = new Point(100, 402);
            this.mnlBirthdateLabel2.Name = "mnlBirthdateLabel2";
            this.mnlBirthdateLabel2.Size = new Size(365, 37);
            this.mnlBirthdateLabel2.TabIndex = 22;
            this.mnlBirthdateLabel2.Text = "Confirm your age, even if this account is for a business, pet, or any other non-person entity.";
            // 
            // mnlBirthDateLabel
            // 
            this.mnlBirthDateLabel.AutoSize = true;
            this.mnlBirthDateLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlBirthDateLabel.ForeColor = Color.Black;
            this.mnlBirthDateLabel.Location = new Point(100, 382);
            this.mnlBirthDateLabel.Name = "mnlBirthDateLabel";
            this.mnlBirthDateLabel.Size = new Size(74, 22);
            this.mnlBirthDateLabel.TabIndex = 21;
            this.mnlBirthDateLabel.Text = "Birthdate";
            // 
            // mnlCreateAccPassBox
            // 
            this.mnlCreateAccPassBox.BackColor = Color.White;
            this.mnlCreateAccPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlCreateAccPassBox.Location = new Point(100, 262);
            this.mnlCreateAccPassBox.Name = "mnlCreateAccPassBox";
            this.mnlCreateAccPassBox.PlaceholderText = "Enter Password";
            this.mnlCreateAccPassBox.Size = new Size(350, 30);
            this.mnlCreateAccPassBox.TabIndex = 20;
            // 
            // mnlCreateAccUserBox
            // 
            this.mnlCreateAccUserBox.BackColor = Color.White;
            this.mnlCreateAccUserBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlCreateAccUserBox.Location = new Point(100, 202);
            this.mnlCreateAccUserBox.Name = "mnlCreateAccUserBox";
            this.mnlCreateAccUserBox.PlaceholderText = "Enter Username";
            this.mnlCreateAccUserBox.Size = new Size(350, 30);
            this.mnlCreateAccUserBox.TabIndex = 19;
            // 
            // mnlCreateAccLabel
            // 
            this.mnlCreateAccLabel.AutoSize = true;
            this.mnlCreateAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlCreateAccLabel.ForeColor = Color.Black;
            this.mnlCreateAccLabel.Location = new Point(100, 132);
            this.mnlCreateAccLabel.Name = "mnlCreateAccLabel";
            this.mnlCreateAccLabel.Size = new Size(336, 46);
            this.mnlCreateAccLabel.TabIndex = 18;
            this.mnlCreateAccLabel.Text = "Create your account";
            // 
            // mnlCreateAccLogo
            // 
            this.mnlCreateAccLogo.BackgroundImage = (Image)resources.GetObject("mnlCreateAccLogo.BackgroundImage");
            this.mnlCreateAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            this.mnlCreateAccLogo.Location = new Point(225, 32);
            this.mnlCreateAccLogo.Name = "mnlCreateAccLogo";
            this.mnlCreateAccLogo.Size = new Size(110, 108);
            this.mnlCreateAccLogo.TabIndex = 24;
            this.mnlCreateAccLogo.TabStop = false;
            // 
            // ManualAddPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(this.mnlShowPassCBox);
            Controls.Add(this.mnlConfirmPassBox);
            Controls.Add(this.mnlYearPicker);
            Controls.Add(this.mnlDayPicker);
            Controls.Add(this.mnlMonthPicker);
            Controls.Add(this.mnlExitIcon);
            Controls.Add(this.mnlStepOneNextBtn);
            Controls.Add(this.mnlBirthdateLabel2);
            Controls.Add(this.mnlBirthDateLabel);
            Controls.Add(this.mnlCreateAccPassBox);
            Controls.Add(this.mnlCreateAccUserBox);
            Controls.Add(this.mnlCreateAccLabel);
            Controls.Add(this.mnlCreateAccLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManualAddPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManualAddPage";
            Load += ManualAddPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)this.mnlExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.mnlCreateAccLogo).EndInit();
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
    }
}