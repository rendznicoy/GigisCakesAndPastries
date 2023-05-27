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
            this.createAccUserBox = new TextBox();
            this.createAccPassBox = new TextBox();
            this.birthDateLabel = new Label();
            this.birthdateLabel2 = new Label();
            this.stepOneNextBtn = new Button();
            this.createAccLogo = new PictureBox();
            this.exitIcon = new PictureBox();
            this.monthPicker = new ComboBox();
            this.dayPicker = new ComboBox();
            this.yearPicker = new ComboBox();
            this.confirmPassBox = new TextBox();
            this.showPassCBox = new CheckBox();
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
            // createAccUserBox
            // 
            this.createAccUserBox.BackColor = Color.White;
            this.createAccUserBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.createAccUserBox.Location = new Point(100, 170);
            this.createAccUserBox.Name = "createAccUserBox";
            this.createAccUserBox.PlaceholderText = "Enter Username";
            this.createAccUserBox.Size = new Size(350, 30);
            this.createAccUserBox.TabIndex = 3;
            // 
            // createAccPassBox
            // 
            this.createAccPassBox.BackColor = Color.White;
            this.createAccPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.createAccPassBox.Location = new Point(100, 230);
            this.createAccPassBox.Name = "createAccPassBox";
            this.createAccPassBox.PlaceholderText = "Enter Password";
            this.createAccPassBox.Size = new Size(350, 30);
            this.createAccPassBox.TabIndex = 4;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.birthDateLabel.ForeColor = Color.Black;
            this.birthDateLabel.Location = new Point(100, 350);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new Size(74, 22);
            this.birthDateLabel.TabIndex = 5;
            this.birthDateLabel.Text = "Birthdate";
            // 
            // birthdateLabel2
            // 
            this.birthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.birthdateLabel2.ForeColor = Color.DimGray;
            this.birthdateLabel2.Location = new Point(100, 370);
            this.birthdateLabel2.Name = "birthdateLabel2";
            this.birthdateLabel2.Size = new Size(365, 37);
            this.birthdateLabel2.TabIndex = 6;
            this.birthdateLabel2.Text = "Confirm your age, even if this account is for a business, pet, or any other non-person entity.";
            // 
            // stepOneNextBtn
            // 
            this.stepOneNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.stepOneNextBtn.FlatAppearance.BorderSize = 0;
            this.stepOneNextBtn.FlatStyle = FlatStyle.Flat;
            this.stepOneNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.stepOneNextBtn.ForeColor = Color.White;
            this.stepOneNextBtn.Location = new Point(100, 470);
            this.stepOneNextBtn.Name = "stepOneNextBtn";
            this.stepOneNextBtn.Size = new Size(350, 50);
            this.stepOneNextBtn.TabIndex = 10;
            this.stepOneNextBtn.Text = "Next";
            this.stepOneNextBtn.UseVisualStyleBackColor = false;
            this.stepOneNextBtn.Click += stepOneNextBtn_Click;
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
            // monthPicker
            // 
            this.monthPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.monthPicker.FormattingEnabled = true;
            this.monthPicker.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            this.monthPicker.Location = new Point(100, 410);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new Size(100, 30);
            this.monthPicker.TabIndex = 13;
            this.monthPicker.Text = "Month";
            this.monthPicker.SelectedIndexChanged += monthPicker_SelectedIndexChanged;
            // 
            // dayPicker
            // 
            this.dayPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.dayPicker.FormattingEnabled = true;
            this.dayPicker.Items.AddRange(new object[] { "" });
            this.dayPicker.Location = new Point(225, 410);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new Size(100, 30);
            this.dayPicker.TabIndex = 14;
            this.dayPicker.Text = "Day";
            // 
            // yearPicker
            // 
            this.yearPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.yearPicker.FormattingEnabled = true;
            this.yearPicker.Items.AddRange(new object[] { "" });
            this.yearPicker.Location = new Point(350, 410);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new Size(100, 30);
            this.yearPicker.TabIndex = 15;
            this.yearPicker.Text = "Year";
            // 
            // confirmPassBox
            // 
            this.confirmPassBox.BackColor = Color.White;
            this.confirmPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.confirmPassBox.Location = new Point(100, 290);
            this.confirmPassBox.Name = "confirmPassBox";
            this.confirmPassBox.PlaceholderText = "Confirm Password";
            this.confirmPassBox.Size = new Size(350, 30);
            this.confirmPassBox.TabIndex = 16;
            // 
            // showPassCBox
            // 
            this.showPassCBox.AutoSize = true;
            this.showPassCBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.showPassCBox.ForeColor = Color.Black;
            this.showPassCBox.Location = new Point(100, 326);
            this.showPassCBox.Name = "showPassCBox";
            this.showPassCBox.Size = new Size(126, 24);
            this.showPassCBox.TabIndex = 17;
            this.showPassCBox.Text = "Show Password";
            this.showPassCBox.UseVisualStyleBackColor = true;
            this.showPassCBox.CheckedChanged += showPassCBox_CheckedChanged;
            // 
            // CreateAccountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 575);
            Controls.Add(this.showPassCBox);
            Controls.Add(this.confirmPassBox);
            Controls.Add(this.yearPicker);
            Controls.Add(this.dayPicker);
            Controls.Add(this.monthPicker);
            Controls.Add(this.exitIcon);
            Controls.Add(this.stepOneNextBtn);
            Controls.Add(this.birthdateLabel2);
            Controls.Add(this.birthDateLabel);
            Controls.Add(this.createAccPassBox);
            Controls.Add(this.createAccUserBox);
            Controls.Add(this.createAccLabel);
            Controls.Add(this.createAccLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccountPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccountPage";
            Load += CreateAccountPage_Load;
            ((System.ComponentModel.ISupportInitialize)this.createAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createAccLabel;
        private Label birthDateLabel;
        private Label birthdateLabel2;
        private Button stepOneNextBtn;
        private PictureBox createAccLogo;
        private PictureBox exitIcon;
        public TextBox createAccUserBox;
        public TextBox createAccPassBox;
        public ComboBox monthPicker;
        public ComboBox dayPicker;
        public ComboBox yearPicker;
        public TextBox confirmPassBox;
        private CheckBox showPassCBox;
    }
}