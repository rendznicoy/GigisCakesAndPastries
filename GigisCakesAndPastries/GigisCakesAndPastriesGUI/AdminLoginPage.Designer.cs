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
            loginExitIcon = new PictureBox();
            customerListIcn = new PictureBox();
            inventoryIcn = new PictureBox();
            adminPageLogo = new PictureBox();
            createAccLabel = new Label();
            customerLstBtn = new Button();
            inventoryBtn = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerListIcn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryIcn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminPageLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginExitIcon
            // 
            loginExitIcon.BackgroundImage = (Image)resources.GetObject("loginExitIcon.BackgroundImage");
            loginExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            loginExitIcon.Location = new Point(1113, 12);
            loginExitIcon.Name = "loginExitIcon";
            loginExitIcon.Size = new Size(25, 25);
            loginExitIcon.TabIndex = 12;
            loginExitIcon.TabStop = false;
            loginExitIcon.Click += loginExitIcon_Click;
            // 
            // customerListIcn
            // 
            customerListIcn.BackgroundImage = (Image)resources.GetObject("customerListIcn.BackgroundImage");
            customerListIcn.BackgroundImageLayout = ImageLayout.Zoom;
            customerListIcn.Location = new Point(100, 150);
            customerListIcn.Name = "customerListIcn";
            customerListIcn.Size = new Size(250, 250);
            customerListIcn.TabIndex = 13;
            customerListIcn.TabStop = false;
            customerListIcn.Click += customerListIcn_Click;
            // 
            // inventoryIcn
            // 
            inventoryIcn.BackgroundImage = (Image)resources.GetObject("inventoryIcn.BackgroundImage");
            inventoryIcn.BackgroundImageLayout = ImageLayout.Zoom;
            inventoryIcn.Location = new Point(450, 150);
            inventoryIcn.Name = "inventoryIcn";
            inventoryIcn.Size = new Size(250, 250);
            inventoryIcn.TabIndex = 14;
            inventoryIcn.TabStop = false;
            inventoryIcn.Click += inventoryIcn_Click;
            // 
            // adminPageLogo
            // 
            adminPageLogo.BackgroundImage = (Image)resources.GetObject("adminPageLogo.BackgroundImage");
            adminPageLogo.BackgroundImageLayout = ImageLayout.Stretch;
            adminPageLogo.Location = new Point(545, 10);
            adminPageLogo.Name = "adminPageLogo";
            adminPageLogo.Size = new Size(88, 83);
            adminPageLogo.TabIndex = 16;
            adminPageLogo.TabStop = false;
            // 
            // createAccLabel
            // 
            createAccLabel.AutoSize = true;
            createAccLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            createAccLabel.ForeColor = Color.Black;
            createAccLabel.Location = new Point(455, 96);
            createAccLabel.Name = "createAccLabel";
            createAccLabel.Size = new Size(245, 40);
            createAccLabel.TabIndex = 17;
            createAccLabel.Text = "Welcome Admin!";
            // 
            // customerLstBtn
            // 
            customerLstBtn.BackColor = Color.FromArgb(15, 129, 240);
            customerLstBtn.FlatAppearance.BorderSize = 0;
            customerLstBtn.FlatStyle = FlatStyle.Flat;
            customerLstBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            customerLstBtn.ForeColor = Color.White;
            customerLstBtn.Location = new Point(100, 425);
            customerLstBtn.Name = "customerLstBtn";
            customerLstBtn.Size = new Size(250, 50);
            customerLstBtn.TabIndex = 18;
            customerLstBtn.Text = "Customer Records";
            customerLstBtn.UseVisualStyleBackColor = false;
            customerLstBtn.Click += customerLstBtn_Click;
            // 
            // inventoryBtn
            // 
            inventoryBtn.BackColor = Color.FromArgb(15, 129, 240);
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryBtn.ForeColor = Color.White;
            inventoryBtn.Location = new Point(450, 425);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new Size(250, 50);
            inventoryBtn.TabIndex = 19;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.UseVisualStyleBackColor = false;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(800, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 129, 240);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(800, 425);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 21;
            button1.Text = "Orders";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1150, 510);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(inventoryBtn);
            Controls.Add(customerLstBtn);
            Controls.Add(createAccLabel);
            Controls.Add(adminPageLogo);
            Controls.Add(inventoryIcn);
            Controls.Add(customerListIcn);
            Controls.Add(loginExitIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerListIcn).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryIcn).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminPageLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button button1;
    }
}