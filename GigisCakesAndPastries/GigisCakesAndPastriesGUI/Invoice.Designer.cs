namespace GigisCakesAndPastriesGUI
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            mnlFillInfoLabel = new Label();
            mnlCreateAccLogo = new PictureBox();
            ordIDLbl = new Label();
            cstmrDetails = new Label();
            orderID = new Label();
            amtPayLbl = new Label();
            prcLogo = new PictureBox();
            prcLbl = new Label();
            prdLbl = new Label();
            ordTypeLbl = new Label();
            payLbl = new Label();
            label3 = new Label();
            label4 = new Label();
            invDate = new Label();
            stepTwoNextBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prcLogo).BeginInit();
            SuspendLayout();
            // 
            // mnlFillInfoLabel
            // 
            mnlFillInfoLabel.AutoSize = true;
            mnlFillInfoLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mnlFillInfoLabel.ForeColor = Color.Black;
            mnlFillInfoLabel.Location = new Point(209, 25);
            mnlFillInfoLabel.Name = "mnlFillInfoLabel";
            mnlFillInfoLabel.Size = new Size(132, 46);
            mnlFillInfoLabel.TabIndex = 39;
            mnlFillInfoLabel.Text = "Invoice";
            // 
            // mnlCreateAccLogo
            // 
            mnlCreateAccLogo.BackgroundImage = (Image)resources.GetObject("mnlCreateAccLogo.BackgroundImage");
            mnlCreateAccLogo.BackgroundImageLayout = ImageLayout.Stretch;
            mnlCreateAccLogo.Location = new Point(12, 131);
            mnlCreateAccLogo.Name = "mnlCreateAccLogo";
            mnlCreateAccLogo.Size = new Size(50, 50);
            mnlCreateAccLogo.TabIndex = 60;
            mnlCreateAccLogo.TabStop = false;
            // 
            // ordIDLbl
            // 
            ordIDLbl.AutoSize = true;
            ordIDLbl.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ordIDLbl.ForeColor = Color.Black;
            ordIDLbl.Location = new Point(68, 131);
            ordIDLbl.Name = "ordIDLbl";
            ordIDLbl.Size = new Size(87, 27);
            ordIDLbl.TabIndex = 40;
            ordIDLbl.Text = "Order ID";
            // 
            // cstmrDetails
            // 
            cstmrDetails.AutoSize = true;
            cstmrDetails.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cstmrDetails.Location = new Point(12, 208);
            cstmrDetails.Name = "cstmrDetails";
            cstmrDetails.Size = new Size(334, 24);
            cstmrDetails.TabIndex = 61;
            cstmrDetails.Text = "Customer Name, Phone Number, Address";
            cstmrDetails.TextChanged += cstmrDetails_TextChanged;
            // 
            // orderID
            // 
            orderID.AutoSize = true;
            orderID.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            orderID.ForeColor = Color.Black;
            orderID.Location = new Point(68, 154);
            orderID.Name = "orderID";
            orderID.Size = new Size(87, 27);
            orderID.TabIndex = 62;
            orderID.Text = "Order ID";
            // 
            // amtPayLbl
            // 
            amtPayLbl.AutoSize = true;
            amtPayLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amtPayLbl.ForeColor = Color.Black;
            amtPayLbl.Location = new Point(12, 406);
            amtPayLbl.Name = "amtPayLbl";
            amtPayLbl.Size = new Size(134, 24);
            amtPayLbl.TabIndex = 63;
            amtPayLbl.Text = "Amount To Pay:";
            // 
            // prcLogo
            // 
            prcLogo.BackColor = Color.Transparent;
            prcLogo.BackgroundImage = (Image)resources.GetObject("prcLogo.BackgroundImage");
            prcLogo.BackgroundImageLayout = ImageLayout.Zoom;
            prcLogo.Location = new Point(158, 400);
            prcLogo.Name = "prcLogo";
            prcLogo.Size = new Size(30, 30);
            prcLogo.TabIndex = 94;
            prcLogo.TabStop = false;
            // 
            // prcLbl
            // 
            prcLbl.AutoSize = true;
            prcLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prcLbl.Location = new Point(194, 406);
            prcLbl.Name = "prcLbl";
            prcLbl.Size = new Size(42, 24);
            prcLbl.TabIndex = 93;
            prcLbl.Text = "0.00";
            // 
            // prdLbl
            // 
            prdLbl.AutoSize = true;
            prdLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prdLbl.Location = new Point(158, 327);
            prdLbl.Name = "prdLbl";
            prdLbl.Size = new Size(320, 24);
            prdLbl.TabIndex = 95;
            prdLbl.Text = "Order Quantity, Size, and Product Name";
            // 
            // ordTypeLbl
            // 
            ordTypeLbl.AutoSize = true;
            ordTypeLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ordTypeLbl.Location = new Point(158, 351);
            ordTypeLbl.Name = "ordTypeLbl";
            ordTypeLbl.Size = new Size(97, 24);
            ordTypeLbl.TabIndex = 97;
            ordTypeLbl.Text = "Order Type";
            // 
            // payLbl
            // 
            payLbl.AutoSize = true;
            payLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            payLbl.Location = new Point(158, 375);
            payLbl.Name = "payLbl";
            payLbl.Size = new Size(140, 24);
            payLbl.TabIndex = 98;
            payLbl.Text = "Payment Method";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(139, 24);
            label3.TabIndex = 99;
            label3.Text = "Recipient Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(395, 128);
            label4.Name = "label4";
            label4.Size = new Size(122, 27);
            label4.TabIndex = 100;
            label4.Text = "Invoice Date";
            // 
            // invDate
            // 
            invDate.AutoSize = true;
            invDate.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            invDate.ForeColor = Color.Black;
            invDate.Location = new Point(395, 154);
            invDate.Name = "invDate";
            invDate.Size = new Size(122, 27);
            invDate.TabIndex = 101;
            invDate.Text = "Invoice Date";
            // 
            // stepTwoNextBtn
            // 
            stepTwoNextBtn.BackColor = Color.FromArgb(15, 129, 240);
            stepTwoNextBtn.FlatAppearance.BorderSize = 0;
            stepTwoNextBtn.FlatStyle = FlatStyle.Flat;
            stepTwoNextBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            stepTwoNextBtn.ForeColor = Color.White;
            stepTwoNextBtn.Location = new Point(100, 500);
            stepTwoNextBtn.Name = "stepTwoNextBtn";
            stepTwoNextBtn.Size = new Size(350, 50);
            stepTwoNextBtn.TabIndex = 102;
            stepTwoNextBtn.Text = "Place Order";
            stepTwoNextBtn.UseVisualStyleBackColor = false;
            stepTwoNextBtn.Click += stepTwoNextBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(37, 473);
            label2.Name = "label2";
            label2.Size = new Size(480, 24);
            label2.TabIndex = 103;
            label2.Text = "Save Your Invoice for Easy Reference and Order Verification!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 351);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 104;
            label1.Text = "Order Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 375);
            label5.Name = "label5";
            label5.Size = new Size(145, 24);
            label5.TabIndex = 105;
            label5.Text = "Payment Method:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 327);
            label6.Name = "label6";
            label6.Size = new Size(116, 24);
            label6.TabIndex = 106;
            label6.Text = "Order Details:";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(mnlFillInfoLabel);
            Controls.Add(stepTwoNextBtn);
            Controls.Add(invDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(payLbl);
            Controls.Add(ordTypeLbl);
            Controls.Add(prdLbl);
            Controls.Add(prcLogo);
            Controls.Add(prcLbl);
            Controls.Add(amtPayLbl);
            Controls.Add(orderID);
            Controls.Add(ordIDLbl);
            Controls.Add(cstmrDetails);
            Controls.Add(mnlCreateAccLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            Load += Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)mnlCreateAccLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)prcLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mnlFillInfoLabel;
        private PictureBox mnlCreateAccLogo;
        private Label ordIDLbl;
        private Label cstmrDetails;
        private Label orderID;
        private Label amtPayLbl;
        private PictureBox prcLogo;
        public Label prcLbl;
        public Label prdLbl;
        public Label ordTypeLbl;
        public Label payLbl;
        private Label label3;
        private Label label4;
        private Label invDate;
        private Button stepTwoNextBtn;
        private Label label2;
        public Label label1;
        public Label label5;
        public Label label6;
    }
}