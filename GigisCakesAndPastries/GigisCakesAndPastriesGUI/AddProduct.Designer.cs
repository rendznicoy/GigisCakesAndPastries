namespace GigisCakesAndPastriesGUI
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            mnlCreateAccLogo = new PictureBox();
            mnlCreateAccLabel = new Label();
            mnlFirstNameLabel = new Label();
            prdNameBox = new TextBox();
            label1 = new Label();
            prdPriceBox = new TextBox();
            label2 = new Label();
            prdQtyBox = new TextBox();
            label3 = new Label();
            prdVarBox = new TextBox();
            mnlStepTwoNextBtn = new Button();
            prdTypePicker = new ComboBox();
            prdSizePicker = new ComboBox();
            label4 = new Label();
            mnlExitIcon = new PictureBox();
            idHidee = new Label();
            sizeHidee = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mnlCreateAccLogo
            // 
            mnlCreateAccLogo.BackgroundImage = (Image)resources.GetObject("mnlCreateAccLogo.BackgroundImage");
            mnlCreateAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            mnlCreateAccLogo.Location = new Point(225, 32);
            mnlCreateAccLogo.Name = "mnlCreateAccLogo";
            mnlCreateAccLogo.Size = new Size(100, 100);
            mnlCreateAccLogo.TabIndex = 25;
            mnlCreateAccLogo.TabStop = false;
            // 
            // mnlCreateAccLabel
            // 
            mnlCreateAccLabel.AutoSize = true;
            mnlCreateAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mnlCreateAccLabel.ForeColor = Color.Black;
            mnlCreateAccLabel.Location = new Point(165, 132);
            mnlCreateAccLabel.Name = "mnlCreateAccLabel";
            mnlCreateAccLabel.Size = new Size(217, 46);
            mnlCreateAccLabel.TabIndex = 26;
            mnlCreateAccLabel.Text = "Add Product";
            // 
            // mnlFirstNameLabel
            // 
            mnlFirstNameLabel.AutoSize = true;
            mnlFirstNameLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnlFirstNameLabel.ForeColor = Color.Black;
            mnlFirstNameLabel.Location = new Point(100, 175);
            mnlFirstNameLabel.Name = "mnlFirstNameLabel";
            mnlFirstNameLabel.Size = new Size(81, 16);
            mnlFirstNameLabel.TabIndex = 43;
            mnlFirstNameLabel.Text = "Product Name";
            // 
            // prdNameBox
            // 
            prdNameBox.BackColor = Color.White;
            prdNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdNameBox.Location = new Point(100, 194);
            prdNameBox.Name = "prdNameBox";
            prdNameBox.Size = new Size(350, 30);
            prdNameBox.TabIndex = 44;
            prdNameBox.KeyPress += prdNameBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 227);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 45;
            label1.Text = "Product Price";
            // 
            // prdPriceBox
            // 
            prdPriceBox.BackColor = Color.White;
            prdPriceBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdPriceBox.Location = new Point(100, 246);
            prdPriceBox.Name = "prdPriceBox";
            prdPriceBox.Size = new Size(350, 30);
            prdPriceBox.TabIndex = 46;
            prdPriceBox.KeyPress += prdPriceBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(100, 279);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 47;
            label2.Text = "Product Quantity";
            // 
            // prdQtyBox
            // 
            prdQtyBox.BackColor = Color.White;
            prdQtyBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdQtyBox.Location = new Point(100, 298);
            prdQtyBox.Name = "prdQtyBox";
            prdQtyBox.Size = new Size(350, 30);
            prdQtyBox.TabIndex = 48;
            prdQtyBox.KeyPress += prdQtyBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(100, 331);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 49;
            label3.Text = "Product Variant";
            // 
            // prdVarBox
            // 
            prdVarBox.BackColor = Color.White;
            prdVarBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdVarBox.Location = new Point(100, 350);
            prdVarBox.Name = "prdVarBox";
            prdVarBox.Size = new Size(350, 30);
            prdVarBox.TabIndex = 50;
            prdVarBox.KeyPress += prdVarBox_KeyPress;
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
            mnlStepTwoNextBtn.TabIndex = 52;
            mnlStepTwoNextBtn.Text = "Add";
            mnlStepTwoNextBtn.UseVisualStyleBackColor = false;
            mnlStepTwoNextBtn.Click += mnlStepTwoNextBtn_Click;
            // 
            // prdTypePicker
            // 
            prdTypePicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            prdTypePicker.FormattingEnabled = true;
            prdTypePicker.Items.AddRange(new object[] { "Cake", "Pastry" });
            prdTypePicker.Location = new Point(140, 408);
            prdTypePicker.Name = "prdTypePicker";
            prdTypePicker.Size = new Size(125, 30);
            prdTypePicker.TabIndex = 53;
            prdTypePicker.Text = "Type";
            // 
            // prdSizePicker
            // 
            prdSizePicker.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            prdSizePicker.FormattingEnabled = true;
            prdSizePicker.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            prdSizePicker.Location = new Point(282, 408);
            prdSizePicker.Name = "prdSizePicker";
            prdSizePicker.Size = new Size(128, 30);
            prdSizePicker.TabIndex = 54;
            prdSizePicker.Text = "Size";
            prdSizePicker.KeyPress += prdSizePicker_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(100, 383);
            label4.Name = "label4";
            label4.Size = new Size(165, 22);
            label4.TabIndex = 55;
            label4.Text = "Product Type and Size";
            // 
            // mnlExitIcon
            // 
            mnlExitIcon.BackgroundImage = (Image)resources.GetObject("mnlExitIcon.BackgroundImage");
            mnlExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            mnlExitIcon.Location = new Point(12, 12);
            mnlExitIcon.Name = "mnlExitIcon";
            mnlExitIcon.Size = new Size(25, 25);
            mnlExitIcon.TabIndex = 56;
            mnlExitIcon.TabStop = false;
            mnlExitIcon.Click += mnlExitIcon_Click;
            // 
            // idHidee
            // 
            idHidee.AutoSize = true;
            idHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idHidee.ForeColor = Color.Black;
            idHidee.Location = new Point(225, 110);
            idHidee.Name = "idHidee";
            idHidee.Size = new Size(51, 22);
            idHidee.TabIndex = 57;
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
            sizeHidee.TabIndex = 58;
            sizeHidee.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(513, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(pictureBox1);
            Controls.Add(mnlCreateAccLogo);
            Controls.Add(mnlExitIcon);
            Controls.Add(label4);
            Controls.Add(prdSizePicker);
            Controls.Add(prdTypePicker);
            Controls.Add(mnlStepTwoNextBtn);
            Controls.Add(prdVarBox);
            Controls.Add(label3);
            Controls.Add(prdQtyBox);
            Controls.Add(label2);
            Controls.Add(prdPriceBox);
            Controls.Add(label1);
            Controls.Add(prdNameBox);
            Controls.Add(mnlFirstNameLabel);
            Controls.Add(mnlCreateAccLabel);
            Controls.Add(idHidee);
            Controls.Add(sizeHidee);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mnlCreateAccLogo;
        private Label mnlCreateAccLabel;
        private Label mnlFirstNameLabel;
        private TextBox prdNameBox;
        private Label label1;
        private TextBox prdPriceBox;
        private Label label2;
        private TextBox prdQtyBox;
        private Label label3;
        private TextBox prdVarBox;
        private Button mnlStepTwoNextBtn;
        public ComboBox prdTypePicker;
        public ComboBox prdSizePicker;
        private Label label4;
        private PictureBox mnlExitIcon;
        public Label idHidee;
        public Label sizeHidee;
        private PictureBox pictureBox1;
    }
}