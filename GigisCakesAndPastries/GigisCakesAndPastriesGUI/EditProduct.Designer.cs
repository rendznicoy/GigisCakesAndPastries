namespace GigisCakesAndPastriesGUI
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            mnlExitIcon = new PictureBox();
            mnlStepTwoNextBtn = new Button();
            prdVarBox = new TextBox();
            label3 = new Label();
            prdQtyBox = new TextBox();
            label2 = new Label();
            prdPriceBox = new TextBox();
            label1 = new Label();
            prdNameBox = new TextBox();
            mnlFirstNameLabel = new Label();
            mnlCreateAccLabel = new Label();
            mnlCreateAccLogo = new PictureBox();
            idHidee = new Label();
            sizeHidee = new Label();
            label5hide = new Label();
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).BeginInit();
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
            mnlStepTwoNextBtn.Text = "Save";
            mnlStepTwoNextBtn.UseVisualStyleBackColor = false;
            mnlStepTwoNextBtn.Click += mnlStepTwoNextBtn_Click;
            // 
            // prdVarBox
            // 
            prdVarBox.BackColor = Color.White;
            prdVarBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdVarBox.Location = new Point(100, 400);
            prdVarBox.Name = "prdVarBox";
            prdVarBox.Size = new Size(350, 30);
            prdVarBox.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(100, 381);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 67;
            label3.Text = "Product Variant";
            // 
            // prdQtyBox
            // 
            prdQtyBox.BackColor = Color.White;
            prdQtyBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdQtyBox.Location = new Point(97, 339);
            prdQtyBox.Name = "prdQtyBox";
            prdQtyBox.Size = new Size(350, 30);
            prdQtyBox.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(100, 320);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 65;
            label2.Text = "Product Quantity";
            // 
            // prdPriceBox
            // 
            prdPriceBox.BackColor = Color.White;
            prdPriceBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdPriceBox.Location = new Point(97, 279);
            prdPriceBox.Name = "prdPriceBox";
            prdPriceBox.Size = new Size(350, 30);
            prdPriceBox.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 260);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 63;
            label1.Text = "Product Price";
            // 
            // prdNameBox
            // 
            prdNameBox.BackColor = Color.White;
            prdNameBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdNameBox.Location = new Point(97, 219);
            prdNameBox.Name = "prdNameBox";
            prdNameBox.Size = new Size(350, 30);
            prdNameBox.TabIndex = 62;
            // 
            // mnlFirstNameLabel
            // 
            mnlFirstNameLabel.AutoSize = true;
            mnlFirstNameLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnlFirstNameLabel.ForeColor = Color.Black;
            mnlFirstNameLabel.Location = new Point(97, 200);
            mnlFirstNameLabel.Name = "mnlFirstNameLabel";
            mnlFirstNameLabel.Size = new Size(81, 16);
            mnlFirstNameLabel.TabIndex = 61;
            mnlFirstNameLabel.Text = "Product Name";
            // 
            // mnlCreateAccLabel
            // 
            mnlCreateAccLabel.AutoSize = true;
            mnlCreateAccLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mnlCreateAccLabel.ForeColor = Color.Black;
            mnlCreateAccLabel.Location = new Point(110, 132);
            mnlCreateAccLabel.Name = "mnlCreateAccLabel";
            mnlCreateAccLabel.Size = new Size(331, 46);
            mnlCreateAccLabel.TabIndex = 60;
            mnlCreateAccLabel.Text = "Edit Product Details";
            // 
            // mnlCreateAccLogo
            // 
            mnlCreateAccLogo.BackgroundImage = (Image)resources.GetObject("mnlCreateAccLogo.BackgroundImage");
            mnlCreateAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            mnlCreateAccLogo.Location = new Point(225, 29);
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
            sizeHidee.Location = new Point(277, 110);
            sizeHidee.Name = "sizeHidee";
            sizeHidee.Size = new Size(51, 22);
            sizeHidee.TabIndex = 75;
            sizeHidee.Text = "label1";
            // 
            // label5hide
            // 
            label5hide.AutoSize = true;
            label5hide.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5hide.ForeColor = Color.Black;
            label5hide.Location = new Point(225, 88);
            label5hide.Name = "label5hide";
            label5hide.Size = new Size(51, 22);
            label5hide.TabIndex = 76;
            label5hide.Text = "label1";
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(mnlExitIcon);
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
            Controls.Add(mnlCreateAccLogo);
            Controls.Add(idHidee);
            Controls.Add(sizeHidee);
            Controls.Add(label5hide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduct";
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mnlExitIcon;
        private Button mnlStepTwoNextBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label mnlFirstNameLabel;
        private Label mnlCreateAccLabel;
        private PictureBox mnlCreateAccLogo;
        public Label idHidee;
        public Label sizeHidee;
        public TextBox prdNameBox;
        public TextBox prdPriceBox;
        public TextBox prdQtyBox;
        public TextBox prdVarBox;
        public Label label5hide;
    }
}