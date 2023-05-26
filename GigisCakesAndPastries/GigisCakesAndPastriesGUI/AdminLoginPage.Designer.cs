namespace GigisCakesAndPastriesGUI
{
    partial class AdminLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginPage));
            this.loginExitIcon = new PictureBox();
            this.customerListIcn = new PictureBox();
            this.inventoryIcn = new PictureBox();
            this.adminPageLogo = new PictureBox();
            this.createAccLabel = new Label();
            this.customerLstBtn = new Button();
            this.inventoryBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)this.loginExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.customerListIcn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.inventoryIcn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.adminPageLogo).BeginInit();
            SuspendLayout();
            // 
            // loginExitIcon
            // 
            this.loginExitIcon.BackgroundImage = (Image)resources.GetObject("loginExitIcon.BackgroundImage");
            this.loginExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.loginExitIcon.Location = new Point(12, 12);
            this.loginExitIcon.Name = "loginExitIcon";
            this.loginExitIcon.Size = new Size(25, 25);
            this.loginExitIcon.TabIndex = 12;
            this.loginExitIcon.TabStop = false;
            this.loginExitIcon.Click += loginExitIcon_Click;
            // 
            // customerListIcn
            // 
            this.customerListIcn.BackgroundImage = (Image)resources.GetObject("customerListIcn.BackgroundImage");
            this.customerListIcn.BackgroundImageLayout = ImageLayout.Stretch;
            this.customerListIcn.Location = new Point(100, 150);
            this.customerListIcn.Name = "customerListIcn";
            this.customerListIcn.Size = new Size(250, 250);
            this.customerListIcn.TabIndex = 13;
            this.customerListIcn.TabStop = false;
            // 
            // inventoryIcn
            // 
            this.inventoryIcn.Location = new Point(450, 150);
            this.inventoryIcn.Name = "inventoryIcn";
            this.inventoryIcn.Size = new Size(250, 250);
            this.inventoryIcn.TabIndex = 14;
            this.inventoryIcn.TabStop = false;
            // 
            // adminPageLogo
            // 
            this.adminPageLogo.BackgroundImage = (Image)resources.GetObject("adminPageLogo.BackgroundImage");
            this.adminPageLogo.BackgroundImageLayout = ImageLayout.Stretch;
            this.adminPageLogo.Location = new Point(356, 10);
            this.adminPageLogo.Name = "adminPageLogo";
            this.adminPageLogo.Size = new Size(88, 83);
            this.adminPageLogo.TabIndex = 16;
            this.adminPageLogo.TabStop = false;
            // 
            // createAccLabel
            // 
            this.createAccLabel.AutoSize = true;
            this.createAccLabel.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.createAccLabel.ForeColor = Color.Black;
            this.createAccLabel.Location = new Point(240, 96);
            this.createAccLabel.Name = "createAccLabel";
            this.createAccLabel.Size = new Size(340, 43);
            this.createAccLabel.TabIndex = 17;
            this.createAccLabel.Text = "Welcome Admin Rain!";
            // 
            // customerLstBtn
            // 
            this.customerLstBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.customerLstBtn.FlatAppearance.BorderSize = 0;
            this.customerLstBtn.FlatStyle = FlatStyle.Flat;
            this.customerLstBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.customerLstBtn.ForeColor = Color.White;
            this.customerLstBtn.Location = new Point(100, 425);
            this.customerLstBtn.Name = "customerLstBtn";
            this.customerLstBtn.Size = new Size(250, 50);
            this.customerLstBtn.TabIndex = 18;
            this.customerLstBtn.Text = "Customer Records";
            this.customerLstBtn.UseVisualStyleBackColor = false;
            this.customerLstBtn.Click += customerLstBtn_Click;
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = FlatStyle.Flat;
            this.inventoryBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.inventoryBtn.ForeColor = Color.White;
            this.inventoryBtn.Location = new Point(450, 425);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new Size(250, 50);
            this.inventoryBtn.TabIndex = 19;
            this.inventoryBtn.Text = "Next";
            this.inventoryBtn.UseVisualStyleBackColor = false;
            // 
            // AdminLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 510);
            Controls.Add(this.inventoryBtn);
            Controls.Add(this.customerLstBtn);
            Controls.Add(this.createAccLabel);
            Controls.Add(this.adminPageLogo);
            Controls.Add(this.inventoryIcn);
            Controls.Add(this.customerListIcn);
            Controls.Add(this.loginExitIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.loginExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.customerListIcn).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.inventoryIcn).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.adminPageLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox loginExitIcon;
        private PictureBox customerListIcn;
        private PictureBox inventoryIcn;
        private PictureBox adminPageLogo;
        private Label createAccLabel;
        private Button customerLstBtn;
        private Button inventoryBtn;
    }
}