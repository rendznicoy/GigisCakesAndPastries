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
            label1 = new Label();
            addLogo = new PictureBox();
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
            aTCLogo.Location = new Point(83, 219);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 60;
            label1.Text = "label1";
            // 
            // addLogo
            // 
            addLogo.BackColor = Color.Transparent;
            addLogo.BackgroundImage = (Image)resources.GetObject("addLogo.BackgroundImage");
            addLogo.BackgroundImageLayout = ImageLayout.Zoom;
            addLogo.Location = new Point(37, 43);
            addLogo.Name = "addLogo";
            addLogo.Size = new Size(25, 25);
            addLogo.TabIndex = 61;
            addLogo.TabStop = false;
            // 
            // AddToCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(addLogo);
            Controls.Add(label1);
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
        private Label label1;
        private PictureBox addLogo;
    }
}