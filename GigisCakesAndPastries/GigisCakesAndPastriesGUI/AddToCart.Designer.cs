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
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aTCLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addLogo).BeginInit();
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
            aTCLogo.Location = new Point(37, 199);
            aTCLogo.Name = "aTCLogo";
            aTCLogo.Size = new Size(200, 200);
            aTCLogo.TabIndex = 58;
            aTCLogo.TabStop = false;
            // 
            // nameHide
            // 
            nameHide.AutoSize = true;
            nameHide.Font = new Font("Agency FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            nameHide.ForeColor = Color.White;
            nameHide.Location = new Point(194, 199);
            nameHide.Name = "nameHide";
            nameHide.Size = new Size(27, 17);
            nameHide.TabIndex = 59;
            nameHide.Text = "label1";
            // 
            // cstmrDetails
            // 
            cstmrDetails.AutoSize = true;
            cstmrDetails.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cstmrDetails.Location = new Point(64, 44);
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
            addLogo.Location = new Point(37, 83);
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
            editBtn.Location = new Point(194, 139);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(215, 24);
            editBtn.TabIndex = 80;
            editBtn.Text = "Update Recipient Details";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // AddToCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
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
    }
}