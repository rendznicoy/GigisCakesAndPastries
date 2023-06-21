namespace GigisCakesAndPastriesGUI
{
    partial class AddIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredient));
            mnlExitIcon = new PictureBox();
            label4 = new Label();
            prdTypePicker = new ComboBox();
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
            prdUnitPicker = new ComboBox();
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
            mnlExitIcon.TabIndex = 73;
            mnlExitIcon.TabStop = false;
            mnlExitIcon.Click += mnlExitIcon_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(100, 375);
            label4.Name = "label4";
            label4.Size = new Size(229, 22);
            label4.TabIndex = 72;
            label4.Text = "Ingredient Unit of Measurement";
            // 
            // prdTypePicker
            // 
            prdTypePicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            prdTypePicker.FormattingEnabled = true;
            prdTypePicker.Items.AddRange(new object[] { "Solid", "Liquid" });
            prdTypePicker.Location = new Point(140, 400);
            prdTypePicker.Name = "prdTypePicker";
            prdTypePicker.Size = new Size(125, 30);
            prdTypePicker.TabIndex = 70;
            prdTypePicker.Text = "Type";
            prdTypePicker.SelectedIndexChanged += prdTypePicker_SelectedIndexChanged;
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
            mnlStepTwoNextBtn.TabIndex = 69;
            mnlStepTwoNextBtn.Text = "Add";
            mnlStepTwoNextBtn.UseVisualStyleBackColor = false;
            mnlStepTwoNextBtn.Click += mnlStepTwoNextBtn_Click;
            // 
            // prdQtyBox
            // 
            prdQtyBox.BackColor = Color.White;
            prdQtyBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdQtyBox.Location = new Point(100, 325);
            prdQtyBox.Name = "prdQtyBox";
            prdQtyBox.Size = new Size(350, 30);
            prdQtyBox.TabIndex = 66;
            prdQtyBox.KeyPress += prdQtyBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(100, 306);
            label2.Name = "label2";
            label2.Size = new Size(110, 16);
            label2.TabIndex = 65;
            label2.Text = "Ingredient Quantity";
            // 
            // prdVarBox
            // 
            prdVarBox.BackColor = Color.White;
            prdVarBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdVarBox.Location = new Point(100, 260);
            prdVarBox.Name = "prdVarBox";
            prdVarBox.Size = new Size(350, 30);
            prdVarBox.TabIndex = 64;
            prdVarBox.KeyPress += prdVarBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 241);
            label1.Name = "label1";
            label1.Size = new Size(102, 16);
            label1.TabIndex = 63;
            label1.Text = "Ingredient Variant";
            // 
            // prdNameBox
            // 
            prdNameBox.BackColor = Color.White;
            prdNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdNameBox.Location = new Point(100, 194);
            prdNameBox.Name = "prdNameBox";
            prdNameBox.Size = new Size(350, 30);
            prdNameBox.TabIndex = 62;
            prdNameBox.KeyPress += prdNameBox_KeyPress;
            // 
            // mnlFirstNameLabel
            // 
            mnlFirstNameLabel.AutoSize = true;
            mnlFirstNameLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnlFirstNameLabel.ForeColor = Color.Black;
            mnlFirstNameLabel.Location = new Point(100, 175);
            mnlFirstNameLabel.Name = "mnlFirstNameLabel";
            mnlFirstNameLabel.Size = new Size(94, 16);
            mnlFirstNameLabel.TabIndex = 61;
            mnlFirstNameLabel.Text = "Ingredient Name";
            // 
            // mnlCreateAccLabel
            // 
            mnlCreateAccLabel.AutoSize = true;
            mnlCreateAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mnlCreateAccLabel.ForeColor = Color.Black;
            mnlCreateAccLabel.Location = new Point(145, 132);
            mnlCreateAccLabel.Name = "mnlCreateAccLabel";
            mnlCreateAccLabel.Size = new Size(251, 46);
            mnlCreateAccLabel.TabIndex = 60;
            mnlCreateAccLabel.Text = "Add Ingredient";
            // 
            // mnlCreateAccLogo
            // 
            mnlCreateAccLogo.BackgroundImage = (Image)resources.GetObject("mnlCreateAccLogo.BackgroundImage");
            mnlCreateAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            mnlCreateAccLogo.Location = new Point(225, 32);
            mnlCreateAccLogo.Name = "mnlCreateAccLogo";
            mnlCreateAccLogo.Size = new Size(100, 100);
            mnlCreateAccLogo.TabIndex = 59;
            mnlCreateAccLogo.TabStop = false;
            // 
            // idHidee
            // 
            idHidee.AutoSize = true;
            idHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idHidee.ForeColor = Color.Black;
            idHidee.Location = new Point(225, 110);
            idHidee.Name = "idHidee";
            idHidee.Size = new Size(51, 22);
            idHidee.TabIndex = 74;
            idHidee.Text = "label1";
            // 
            // sizeHidee
            // 
            sizeHidee.AutoSize = true;
            sizeHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sizeHidee.ForeColor = Color.Black;
            sizeHidee.Location = new Point(225, 88);
            sizeHidee.Name = "sizeHidee";
            sizeHidee.Size = new Size(51, 22);
            sizeHidee.TabIndex = 75;
            sizeHidee.Text = "label1";
            // 
            // prdUnitPicker
            // 
            prdUnitPicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            prdUnitPicker.FormattingEnabled = true;
            prdUnitPicker.Location = new Point(282, 400);
            prdUnitPicker.Name = "prdUnitPicker";
            prdUnitPicker.Size = new Size(128, 30);
            prdUnitPicker.TabIndex = 71;
            prdUnitPicker.Text = "Unit";
            prdUnitPicker.KeyPress += prdUnitPicker_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(513, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddIngredient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(pictureBox1);
            Controls.Add(mnlExitIcon);
            Controls.Add(label4);
            Controls.Add(prdUnitPicker);
            Controls.Add(prdTypePicker);
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
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddIngredient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIngredient";
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mnlExitIcon;
        private Label label4;
        public ComboBox prdTypePicker;
        private Button mnlStepTwoNextBtn;
        private TextBox prdQtyBox;
        private Label label2;
        private TextBox prdVarBox;
        private Label label1;
        private TextBox prdNameBox;
        private Label mnlFirstNameLabel;
        private Label mnlCreateAccLabel;
        private PictureBox mnlCreateAccLogo;
        public Label idHidee;
        public Label sizeHidee;
        public ComboBox prdUnitPicker;
        private PictureBox pictureBox1;
    }
}