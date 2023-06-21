namespace GigisCakesAndPastriesGUI
{
    partial class EditLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLogin));
            showPassCBox = new CheckBox();
            confirmPassBox = new TextBox();
            stepOneNextBtn = new Button();
            createAccPassBox = new TextBox();
            createAccUserBox = new TextBox();
            createAccLabel = new Label();
            createAccLogo = new PictureBox();
            birthdateLabel2 = new Label();
            pictureBox1 = new PictureBox();
            loginExitIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)createAccLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).BeginInit();
            SuspendLayout();
            // 
            // showPassCBox
            // 
            showPassCBox.AutoSize = true;
            showPassCBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            showPassCBox.ForeColor = Color.Black;
            showPassCBox.Location = new Point(100, 358);
            showPassCBox.Name = "showPassCBox";
            showPassCBox.Size = new Size(126, 24);
            showPassCBox.TabIndex = 30;
            showPassCBox.Text = "Show Password";
            showPassCBox.UseVisualStyleBackColor = true;
            showPassCBox.CheckedChanged += showPassCBox_CheckedChanged;
            // 
            // confirmPassBox
            // 
            confirmPassBox.BackColor = Color.White;
            confirmPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPassBox.Location = new Point(100, 322);
            confirmPassBox.Name = "confirmPassBox";
            confirmPassBox.PlaceholderText = "Confirm Password";
            confirmPassBox.Size = new Size(350, 30);
            confirmPassBox.TabIndex = 29;
            confirmPassBox.KeyPress += confirmPassBox_KeyPress;
            // 
            // stepOneNextBtn
            // 
            stepOneNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            stepOneNextBtn.FlatAppearance.BorderSize = 0;
            stepOneNextBtn.FlatStyle = FlatStyle.Flat;
            stepOneNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            stepOneNextBtn.ForeColor = Color.White;
            stepOneNextBtn.Location = new Point(100, 450);
            stepOneNextBtn.Name = "stepOneNextBtn";
            stepOneNextBtn.Size = new Size(350, 50);
            stepOneNextBtn.TabIndex = 23;
            stepOneNextBtn.Text = "Next";
            stepOneNextBtn.UseVisualStyleBackColor = false;
            stepOneNextBtn.Click += stepOneNextBtn_Click;
            // 
            // createAccPassBox
            // 
            createAccPassBox.BackColor = Color.White;
            createAccPassBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createAccPassBox.Location = new Point(100, 262);
            createAccPassBox.Name = "createAccPassBox";
            createAccPassBox.PlaceholderText = "Enter Password";
            createAccPassBox.Size = new Size(350, 30);
            createAccPassBox.TabIndex = 20;
            createAccPassBox.KeyPress += createAccPassBox_KeyPress;
            // 
            // createAccUserBox
            // 
            createAccUserBox.BackColor = Color.White;
            createAccUserBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createAccUserBox.Location = new Point(100, 202);
            createAccUserBox.Name = "createAccUserBox";
            createAccUserBox.PlaceholderText = "Enter Username";
            createAccUserBox.Size = new Size(350, 30);
            createAccUserBox.TabIndex = 19;
            createAccUserBox.KeyPress += createAccUserBox_KeyPress;
            // 
            // createAccLabel
            // 
            createAccLabel.AutoSize = true;
            createAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            createAccLabel.ForeColor = Color.Black;
            createAccLabel.Location = new Point(71, 132);
            createAccLabel.Name = "createAccLabel";
            createAccLabel.Size = new Size(407, 46);
            createAccLabel.TabIndex = 18;
            createAccLabel.Text = "Create Login Credentials";
            // 
            // createAccLogo
            // 
            createAccLogo.BackgroundImage = (Image)resources.GetObject("createAccLogo.BackgroundImage");
            createAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            createAccLogo.Location = new Point(225, 32);
            createAccLogo.Name = "createAccLogo";
            createAccLogo.Size = new Size(110, 108);
            createAccLogo.TabIndex = 24;
            createAccLogo.TabStop = false;
            // 
            // birthdateLabel2
            // 
            birthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            birthdateLabel2.ForeColor = Color.DimGray;
            birthdateLabel2.Location = new Point(100, 400);
            birthdateLabel2.Name = "birthdateLabel2";
            birthdateLabel2.Size = new Size(350, 37);
            birthdateLabel2.TabIndex = 51;
            birthdateLabel2.Text = "You are required create login credentials before you can use the application";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(482, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // loginExitIcon
            // 
            loginExitIcon.BackgroundImage = (Image)resources.GetObject("loginExitIcon.BackgroundImage");
            loginExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            loginExitIcon.Location = new Point(513, 12);
            loginExitIcon.Name = "loginExitIcon";
            loginExitIcon.Size = new Size(25, 25);
            loginExitIcon.TabIndex = 52;
            loginExitIcon.TabStop = false;
            loginExitIcon.Click += loginExitIcon_Click;
            // 
            // EditLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(pictureBox1);
            Controls.Add(loginExitIcon);
            Controls.Add(birthdateLabel2);
            Controls.Add(showPassCBox);
            Controls.Add(confirmPassBox);
            Controls.Add(stepOneNextBtn);
            Controls.Add(createAccPassBox);
            Controls.Add(createAccUserBox);
            Controls.Add(createAccLabel);
            Controls.Add(createAccLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditLogin";
            ((System.ComponentModel.ISupportInitialize)createAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox showPassCBox;
        public TextBox confirmPassBox;
        private Button stepOneNextBtn;
        public TextBox createAccPassBox;
        public TextBox createAccUserBox;
        private Label createAccLabel;
        private PictureBox createAccLogo;
        private Label birthdateLabel2;
        private PictureBox pictureBox1;
        private PictureBox loginExitIcon;
    }
}