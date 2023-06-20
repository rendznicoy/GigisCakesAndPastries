namespace GigisCakesAndPastriesGUI
{
    partial class AddToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            mnlExitIcon = new PictureBox();
            aTCLogo = new PictureBox();
            nameHide = new Label();
            cstmrDetails = new Label();
            addLogo = new PictureBox();
            usernameHide = new Label();
            editBtn = new Button();
            prdLbl = new Label();
            sizePicker = new ComboBox();
            prcLbl = new Label();
            prcLogo = new PictureBox();
            ordPicker = new ComboBox();
            payPicker = new ComboBox();
            stepTwoNextBtn = new Button();
            qtyPicker = new NumericUpDown();
            qtyLabel = new Label();
            qtyCount = new Label();
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aTCLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prcLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qtyPicker).BeginInit();
            SuspendLayout();
            // 
            // mnlExitIcon
            // 
            mnlExitIcon.BackgroundImage = (Image)resources.GetObject("mnlExitIcon.BackgroundImage");
            mnlExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            mnlExitIcon.Location = new Point(12, 12);
            mnlExitIcon.Name = "mnlExitIcon";
            mnlExitIcon.Size = new Size(25, 25);
            mnlExitIcon.TabIndex = 57;
            mnlExitIcon.TabStop = false;
            mnlExitIcon.Click += mnlExitIcon_Click;
            // 
            // aTCLogo
            // 
            aTCLogo.BackColor = Color.Transparent;
            aTCLogo.BackgroundImageLayout = ImageLayout.Zoom;
            aTCLogo.Location = new Point(37, 225);
            aTCLogo.Name = "aTCLogo";
            aTCLogo.Size = new Size(100, 100);
            aTCLogo.TabIndex = 58;
            aTCLogo.TabStop = false;
            // 
            // nameHide
            // 
            nameHide.AutoSize = true;
            nameHide.Font = new Font("Agency FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            nameHide.ForeColor = Color.White;
            nameHide.Location = new Point(194, 249);
            nameHide.Name = "nameHide";
            nameHide.Size = new Size(27, 17);
            nameHide.TabIndex = 59;
            nameHide.Text = "label1";
            // 
            // cstmrDetails
            // 
            cstmrDetails.AutoSize = true;
            cstmrDetails.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cstmrDetails.Location = new Point(64, 54);
            cstmrDetails.Name = "cstmrDetails";
            cstmrDetails.Size = new Size(334, 24);
            cstmrDetails.TabIndex = 60;
            cstmrDetails.Text = "Customer Name, Phone Number, Address";
            cstmrDetails.TextChanged += cstmrDetails_TextChanged;
            // 
            // addLogo
            // 
            addLogo.BackColor = Color.Transparent;
            addLogo.BackgroundImage = (Image)resources.GetObject("addLogo.BackgroundImage");
            addLogo.BackgroundImageLayout = ImageLayout.Zoom;
            addLogo.Location = new Point(37, 54);
            addLogo.Name = "addLogo";
            addLogo.Size = new Size(25, 25);
            addLogo.TabIndex = 61;
            addLogo.TabStop = false;
            // 
            // usernameHide
            // 
            usernameHide.AutoSize = true;
            usernameHide.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameHide.ForeColor = Color.White;
            usernameHide.Location = new Point(12, 567);
            usernameHide.Name = "usernameHide";
            usernameHide.Size = new Size(0, 24);
            usernameHide.TabIndex = 62;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(15, 129, 240);
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(168, 164);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(215, 24);
            editBtn.TabIndex = 80;
            editBtn.Text = "Update Recipient Details";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // prdLbl
            // 
            prdLbl.AutoSize = true;
            prdLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdLbl.Location = new Point(150, 225);
            prdLbl.Name = "prdLbl";
            prdLbl.Size = new Size(120, 24);
            prdLbl.TabIndex = 81;
            prdLbl.Text = "Product Name";
            // 
            // sizePicker
            // 
            sizePicker.BackColor = Color.White;
            sizePicker.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sizePicker.FormattingEnabled = true;
            sizePicker.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            sizePicker.Location = new Point(150, 260);
            sizePicker.Name = "sizePicker";
            sizePicker.Size = new Size(150, 30);
            sizePicker.TabIndex = 82;
            sizePicker.Text = "Select Product Size";
            sizePicker.SelectedIndexChanged += sizePicker_SelectedIndexChanged;
            // 
            // prcLbl
            // 
            prcLbl.AutoSize = true;
            prcLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prcLbl.Location = new Point(186, 338);
            prcLbl.Name = "prcLbl";
            prcLbl.Size = new Size(42, 24);
            prcLbl.TabIndex = 83;
            prcLbl.Text = "0.00";
            // 
            // prcLogo
            // 
            prcLogo.BackColor = Color.Transparent;
            prcLogo.BackgroundImage = (Image)resources.GetObject("prcLogo.BackgroundImage");
            prcLogo.BackgroundImageLayout = ImageLayout.Zoom;
            prcLogo.Location = new Point(150, 332);
            prcLogo.Name = "prcLogo";
            prcLogo.Size = new Size(30, 30);
            prcLogo.TabIndex = 92;
            prcLogo.TabStop = false;
            // 
            // ordPicker
            // 
            ordPicker.BackColor = Color.White;
            ordPicker.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ordPicker.FormattingEnabled = true;
            ordPicker.Items.AddRange(new object[] { "Delivery" });
            ordPicker.Location = new Point(363, 260);
            ordPicker.Name = "ordPicker";
            ordPicker.Size = new Size(150, 30);
            ordPicker.TabIndex = 94;
            ordPicker.Text = "Order Options";
            ordPicker.SelectedIndexChanged += ordPicker_SelectedIndexChanged;
            // 
            // payPicker
            // 
            payPicker.BackColor = Color.White;
            payPicker.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            payPicker.FormattingEnabled = true;
            payPicker.Items.AddRange(new object[] { "Cash on Delivery" });
            payPicker.Location = new Point(150, 296);
            payPicker.Name = "payPicker";
            payPicker.Size = new Size(150, 30);
            payPicker.TabIndex = 95;
            payPicker.Text = "Payment Options";
            payPicker.SelectedIndexChanged += payPicker_SelectedIndexChanged;
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
            stepTwoNextBtn.TabIndex = 96;
            stepTwoNextBtn.Text = "Place Order";
            stepTwoNextBtn.UseVisualStyleBackColor = false;
            stepTwoNextBtn.Click += stepTwoNextBtn_Click;
            // 
            // qtyPicker
            // 
            qtyPicker.BackColor = Color.White;
            qtyPicker.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            qtyPicker.Location = new Point(363, 299);
            qtyPicker.Name = "qtyPicker";
            qtyPicker.Size = new Size(150, 27);
            qtyPicker.TabIndex = 97;
            qtyPicker.ValueChanged += qtyPicker_ValueChanged;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            qtyLabel.Location = new Point(430, 338);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(47, 24);
            qtyLabel.TabIndex = 98;
            qtyLabel.Text = "Qty: ";
            // 
            // qtyCount
            // 
            qtyCount.AutoSize = true;
            qtyCount.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            qtyCount.Location = new Point(467, 338);
            qtyCount.Name = "qtyCount";
            qtyCount.Size = new Size(19, 24);
            qtyCount.TabIndex = 99;
            qtyCount.Text = "0";
            // 
            // AddToCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(qtyCount);
            Controls.Add(qtyLabel);
            Controls.Add(qtyPicker);
            Controls.Add(stepTwoNextBtn);
            Controls.Add(payPicker);
            Controls.Add(ordPicker);
            Controls.Add(prcLogo);
            Controls.Add(prcLbl);
            Controls.Add(sizePicker);
            Controls.Add(prdLbl);
            Controls.Add(editBtn);
            Controls.Add(usernameHide);
            Controls.Add(addLogo);
            Controls.Add(cstmrDetails);
            Controls.Add(mnlExitIcon);
            Controls.Add(aTCLogo);
            Controls.Add(nameHide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddToCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddToCart";
            Load += AddToCart_Load;
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)aTCLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)addLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)prcLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)qtyPicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mnlExitIcon;
        private PictureBox aTCLogo;
        public Label nameHide;
        private Label cstmrDetails;
        private PictureBox addLogo;
        public Label usernameHide;
        private Button editBtn;
        public Label prdLbl;
        public ComboBox sizePicker;
        public Label prcLbl;
        private PictureBox prcLogo;
        public ComboBox ordPicker;
        public ComboBox payPicker;
        private Button stepTwoNextBtn;
        private NumericUpDown qtyPicker;
        public Label qtyLabel;
        public Label qtyCount;
    }
}