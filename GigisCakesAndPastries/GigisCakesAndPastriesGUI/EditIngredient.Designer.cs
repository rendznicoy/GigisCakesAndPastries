namespace GigisCakesAndPastriesGUI
{
    partial class EditIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIngredient));
            mnlExitIcon = new PictureBox();
            mnlStepTwoNextBtn = new Button();
            prdQtyBox = new TextBox();
            label2 = new Label();
            prdVarBox = new TextBox();
            label1 = new Label();
            prdNameBox = new TextBox();
            mnlFirstNameLabel = new Label();
            mnlCreateAccLabel = new Label();
            mnlCreateAccLogo = new PictureBox();
            idHidee = new Label();
            sizeHidee = new Label();
            label3hide = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mnlExitIcon
            // 
            mnlExitIcon.BackgroundImage = (Image)resources.GetObject("mnlExitIcon.BackgroundImage");
            mnlExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            mnlExitIcon.Location = new Point(12, 12);
            mnlExitIcon.Name = "mnlExitIcon";
            mnlExitIcon.Size = new Size(25, 25);
            mnlExitIcon.TabIndex = 88;
            mnlExitIcon.TabStop = false;
            mnlExitIcon.Click += mnlExitIcon_Click;
            // 
            // mnlStepTwoNextBtn
            // 
            mnlStepTwoNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            mnlStepTwoNextBtn.FlatAppearance.BorderSize = 0;
            mnlStepTwoNextBtn.FlatStyle = FlatStyle.Flat;
            mnlStepTwoNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            mnlStepTwoNextBtn.ForeColor = Color.White;
            mnlStepTwoNextBtn.Location = new Point(100, 468);
            mnlStepTwoNextBtn.Name = "mnlStepTwoNextBtn";
            mnlStepTwoNextBtn.Size = new Size(350, 50);
            mnlStepTwoNextBtn.TabIndex = 84;
            mnlStepTwoNextBtn.Text = "Save";
            mnlStepTwoNextBtn.UseVisualStyleBackColor = false;
            mnlStepTwoNextBtn.Click += mnlStepTwoNextBtn_Click;
            // 
            // prdQtyBox
            // 
            prdQtyBox.BackColor = Color.White;
            prdQtyBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdQtyBox.Location = new Point(97, 400);
            prdQtyBox.Name = "prdQtyBox";
            prdQtyBox.Size = new Size(350, 30);
            prdQtyBox.TabIndex = 83;
            prdQtyBox.KeyPress += prdQtyBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(97, 381);
            label2.Name = "label2";
            label2.Size = new Size(110, 16);
            label2.TabIndex = 82;
            label2.Text = "Ingredient Quantity";
            // 
            // prdVarBox
            // 
            prdVarBox.BackColor = Color.White;
            prdVarBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdVarBox.Location = new Point(97, 319);
            prdVarBox.Name = "prdVarBox";
            prdVarBox.Size = new Size(350, 30);
            prdVarBox.TabIndex = 81;
            prdVarBox.KeyPress += prdVarBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(97, 300);
            label1.Name = "label1";
            label1.Size = new Size(102, 16);
            label1.TabIndex = 80;
            label1.Text = "Ingredient Variant";
            // 
            // prdNameBox
            // 
            prdNameBox.BackColor = Color.White;
            prdNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdNameBox.Location = new Point(97, 243);
            prdNameBox.Name = "prdNameBox";
            prdNameBox.Size = new Size(350, 30);
            prdNameBox.TabIndex = 79;
            prdNameBox.KeyPress += prdNameBox_KeyPress;
            // 
            // mnlFirstNameLabel
            // 
            mnlFirstNameLabel.AutoSize = true;
            mnlFirstNameLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnlFirstNameLabel.ForeColor = Color.Black;
            mnlFirstNameLabel.Location = new Point(97, 225);
            mnlFirstNameLabel.Name = "mnlFirstNameLabel";
            mnlFirstNameLabel.Size = new Size(94, 16);
            mnlFirstNameLabel.TabIndex = 78;
            mnlFirstNameLabel.Text = "Ingredient Name";
            // 
            // mnlCreateAccLabel
            // 
            mnlCreateAccLabel.AutoSize = true;
            mnlCreateAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mnlCreateAccLabel.ForeColor = Color.Black;
            mnlCreateAccLabel.Location = new Point(95, 132);
            mnlCreateAccLabel.Name = "mnlCreateAccLabel";
            mnlCreateAccLabel.Size = new Size(365, 46);
            mnlCreateAccLabel.TabIndex = 77;
            mnlCreateAccLabel.Text = "Edit Ingredient Details";
            // 
            // mnlCreateAccLogo
            // 
            mnlCreateAccLogo.BackgroundImage = (Image)resources.GetObject("mnlCreateAccLogo.BackgroundImage");
            mnlCreateAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            mnlCreateAccLogo.Location = new Point(225, 29);
            mnlCreateAccLogo.Name = "mnlCreateAccLogo";
            mnlCreateAccLogo.Size = new Size(100, 100);
            mnlCreateAccLogo.TabIndex = 76;
            mnlCreateAccLogo.TabStop = false;
            // 
            // idHidee
            // 
            idHidee.AutoSize = true;
            idHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idHidee.ForeColor = Color.Black;
            idHidee.Location = new Point(225, 107);
            idHidee.Name = "idHidee";
            idHidee.Size = new Size(51, 22);
            idHidee.TabIndex = 89;
            idHidee.Text = "label1";
            // 
            // sizeHidee
            // 
            sizeHidee.AutoSize = true;
            sizeHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sizeHidee.ForeColor = Color.Black;
            sizeHidee.Location = new Point(274, 107);
            sizeHidee.Name = "sizeHidee";
            sizeHidee.Size = new Size(51, 22);
            sizeHidee.TabIndex = 90;
            sizeHidee.Text = "label1";
            // 
            // label3hide
            // 
            label3hide.AutoSize = true;
            label3hide.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3hide.ForeColor = Color.Black;
            label3hide.Location = new Point(225, 73);
            label3hide.Name = "label3hide";
            label3hide.Size = new Size(51, 22);
            label3hide.TabIndex = 91;
            label3hide.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(513, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 92;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EditIngredient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(pictureBox1);
            Controls.Add(mnlExitIcon);
            Controls.Add(mnlStepTwoNextBtn);
            Controls.Add(prdQtyBox);
            Controls.Add(label2);
            Controls.Add(prdVarBox);
            Controls.Add(label1);
            Controls.Add(prdNameBox);
            Controls.Add(mnlFirstNameLabel);
            Controls.Add(mnlCreateAccLabel);
            Controls.Add(mnlCreateAccLogo);
            Controls.Add(idHidee);
            Controls.Add(sizeHidee);
            Controls.Add(label3hide);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditIngredient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditIngredient";
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mnlExitIcon;
        private Button mnlStepTwoNextBtn;
        private Label label2;
        private Label label1;
        private Label mnlFirstNameLabel;
        private Label mnlCreateAccLabel;
        private PictureBox mnlCreateAccLogo;
        public Label idHidee;
        public Label sizeHidee;
        public Label label3hide;
        public TextBox prdQtyBox;
        public TextBox prdVarBox;
        public TextBox prdNameBox;
        private PictureBox pictureBox1;
    }
}