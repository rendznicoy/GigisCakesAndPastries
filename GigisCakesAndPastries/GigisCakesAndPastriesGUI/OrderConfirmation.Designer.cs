namespace GigisCakesAndPastriesGUI
{
    partial class OrderConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderConfirmation));
            mnlExitIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).BeginInit();
            SuspendLayout();
            // 
            // mnlExitIcon
            // 
            mnlExitIcon.BackgroundImage = (Image)resources.GetObject("mnlExitIcon.BackgroundImage");
            mnlExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            mnlExitIcon.Location = new Point(12, 12);
            mnlExitIcon.Name = "mnlExitIcon";
            mnlExitIcon.Size = new Size(25, 25);
            mnlExitIcon.TabIndex = 58;
            mnlExitIcon.TabStop = false;
            mnlExitIcon.Click += mnlExitIcon_Click;
            // 
            // OrderConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 600);
            Controls.Add(mnlExitIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderConfirmation";
            ((System.ComponentModel.ISupportInitialize)mnlExitIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mnlExitIcon;
    }
}