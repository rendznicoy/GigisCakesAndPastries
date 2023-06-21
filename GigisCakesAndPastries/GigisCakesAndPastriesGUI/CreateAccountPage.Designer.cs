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
            createAccLabel = new Label();
            createAccUserBox = new TextBox();
            createAccPassBox = new TextBox();
            birthDateLabel = new Label();
            birthdateLabel2 = new Label();
            stepOneNextBtn = new Button();
            createAccLogo = new PictureBox();
            exitIcon = new PictureBox();
            monthPicker = new ComboBox();
            dayPicker = new ComboBox();
            yearPicker = new ComboBox();
            confirmPassBox = new TextBox();
            showPassCBox = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)createAccLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // createAccLabel
            // 
            createAccLabel.AutoSize = true;
            createAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            createAccLabel.ForeColor = Color.Black;
            createAccLabel.Location = new Point(100, 132);
            createAccLabel.Name = "createAccLabel";
            createAccLabel.Size = new Size(336, 46);
            createAccLabel.TabIndex = 1;
            createAccLabel.Text = "Create your account";
            // 
            // createAccUserBox
            // 
            createAccUserBox.BackColor = Color.White;
            createAccUserBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createAccUserBox.Location = new Point(100, 202);
            createAccUserBox.Name = "createAccUserBox";
            createAccUserBox.PlaceholderText = "Enter Username";
            createAccUserBox.Size = new Size(350, 30);
            createAccUserBox.TabIndex = 3;
            createAccUserBox.KeyPress += createAccUserBox_KeyPress;
            // 
            // createAccPassBox
            // 
            createAccPassBox.BackColor = Color.White;
            createAccPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createAccPassBox.Location = new Point(100, 262);
            createAccPassBox.Name = "createAccPassBox";
            createAccPassBox.PlaceholderText = "Enter Password";
            createAccPassBox.Size = new Size(350, 30);
            createAccPassBox.TabIndex = 4;
            createAccPassBox.KeyPress += createAccPassBox_KeyPress;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            birthDateLabel.ForeColor = Color.Black;
            birthDateLabel.Location = new Point(100, 382);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(74, 22);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birthdate";
            // 
            // birthdateLabel2
            // 
            birthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            birthdateLabel2.ForeColor = Color.DimGray;
            birthdateLabel2.Location = new Point(100, 402);
            birthdateLabel2.Name = "birthdateLabel2";
            birthdateLabel2.Size = new Size(365, 37);
            birthdateLabel2.TabIndex = 6;
            birthdateLabel2.Text = "Confirm your age, even if this account is for a business, pet, or any other non-person entity.";
            // 
            // stepOneNextBtn
            // 
            stepOneNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            stepOneNextBtn.FlatAppearance.BorderSize = 0;
            stepOneNextBtn.FlatStyle = FlatStyle.Flat;
            stepOneNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            stepOneNextBtn.ForeColor = Color.White;
            stepOneNextBtn.Location = new Point(100, 502);
            stepOneNextBtn.Name = "stepOneNextBtn";
            stepOneNextBtn.Size = new Size(350, 50);
            stepOneNextBtn.TabIndex = 10;
            stepOneNextBtn.Text = "Next";
            stepOneNextBtn.UseVisualStyleBackColor = false;
            stepOneNextBtn.Click += stepOneNextBtn_Click;
            // 
            // createAccLogo
            // 
            createAccLogo.BackgroundImage = (Image)resources.GetObject("createAccLogo.BackgroundImage");
            createAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            createAccLogo.Location = new Point(225, 32);
            createAccLogo.Name = "createAccLogo";
            createAccLogo.Size = new Size(110, 108);
            createAccLogo.TabIndex = 11;
            createAccLogo.TabStop = false;
            // 
            // exitIcon
            // 
            exitIcon.BackgroundImage = (Image)resources.GetObject("exitIcon.BackgroundImage");
            exitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            exitIcon.Location = new Point(12, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(25, 25);
            exitIcon.TabIndex = 12;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // monthPicker
            // 
            monthPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            monthPicker.FormattingEnabled = true;
            monthPicker.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthPicker.Location = new Point(100, 442);
            monthPicker.Name = "monthPicker";
            monthPicker.Size = new Size(100, 30);
            monthPicker.TabIndex = 13;
            monthPicker.Text = "Month";
            monthPicker.SelectedIndexChanged += monthPicker_SelectedIndexChanged;
            // 
            // dayPicker
            // 
            dayPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dayPicker.FormattingEnabled = true;
            dayPicker.Items.AddRange(new object[] { "" });
            dayPicker.Location = new Point(225, 442);
            dayPicker.Name = "dayPicker";
            dayPicker.Size = new Size(100, 30);
            dayPicker.TabIndex = 14;
            dayPicker.Text = "Day";
            // 
            // yearPicker
            // 
            yearPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            yearPicker.FormattingEnabled = true;
            yearPicker.Items.AddRange(new object[] { "" });
            yearPicker.Location = new Point(350, 442);
            yearPicker.Name = "yearPicker";
            yearPicker.Size = new Size(100, 30);
            yearPicker.TabIndex = 15;
            yearPicker.Text = "Year";
            yearPicker.KeyPress += yearPicker_KeyPress;
            // 
            // confirmPassBox
            // 
            confirmPassBox.BackColor = Color.White;
            confirmPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPassBox.Location = new Point(100, 322);
            confirmPassBox.Name = "confirmPassBox";
            confirmPassBox.PlaceholderText = "Confirm Password";
            confirmPassBox.Size = new Size(350, 30);
            confirmPassBox.TabIndex = 16;
            confirmPassBox.KeyPress += confirmPassBox_KeyPress;
            // 
            // showPassCBox
            // 
            showPassCBox.AutoSize = true;
            showPassCBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            showPassCBox.ForeColor = Color.Black;
            showPassCBox.Location = new Point(100, 358);
            showPassCBox.Name = "showPassCBox";
            showPassCBox.Size = new Size(126, 24);
            showPassCBox.TabIndex = 17;
            showPassCBox.Text = "Show Password";
            showPassCBox.UseVisualStyleBackColor = true;
            showPassCBox.CheckedChanged += showPassCBox_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(513, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CreateAccountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(pictureBox1);
            Controls.Add(showPassCBox);
            Controls.Add(confirmPassBox);
            Controls.Add(yearPicker);
            Controls.Add(dayPicker);
            Controls.Add(monthPicker);
            Controls.Add(exitIcon);
            Controls.Add(stepOneNextBtn);
            Controls.Add(birthdateLabel2);
            Controls.Add(birthDateLabel);
            Controls.Add(createAccPassBox);
            Controls.Add(createAccUserBox);
            Controls.Add(createAccLabel);
            Controls.Add(createAccLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateAccountPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccountPage";
            Load += CreateAccountPage_Load;
            ((System.ComponentModel.ISupportInitialize)createAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}