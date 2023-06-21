namespace GigisCakesAndPastriesGUI
{
    partial class InventoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryView));
            customerListIcn = new PictureBox();
            customerLstBtn = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            adminPageLogo = new PictureBox();
            createAccLabel = new Label();
            loginExitIcon = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)customerListIcn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminPageLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // customerListIcn
            // 
            customerListIcn.BackgroundImage = (Image)resources.GetObject("customerListIcn.BackgroundImage");
            customerListIcn.BackgroundImageLayout = ImageLayout.Zoom;
            customerListIcn.Location = new Point(100, 150);
            customerListIcn.Name = "customerListIcn";
            customerListIcn.Size = new Size(250, 250);
            customerListIcn.TabIndex = 14;
            customerListIcn.TabStop = false;
            customerListIcn.Click += customerListIcn_Click;
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
            customerLstBtn.TabIndex = 19;
            customerLstBtn.Text = "Product List";
            customerLstBtn.UseVisualStyleBackColor = false;
            customerLstBtn.Click += customerLstBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(450, 150);
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
            button1.Location = new Point(450, 425);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 21;
            button1.Text = "Ingredient List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // adminPageLogo
            // 
            adminPageLogo.BackgroundImage = (Image)resources.GetObject("adminPageLogo.BackgroundImage");
            adminPageLogo.BackgroundImageLayout = ImageLayout.Stretch;
            adminPageLogo.Location = new Point(356, 10);
            adminPageLogo.Name = "adminPageLogo";
            adminPageLogo.Size = new Size(88, 83);
            adminPageLogo.TabIndex = 22;
            adminPageLogo.TabStop = false;
            // 
            // createAccLabel
            // 
            createAccLabel.AutoSize = true;
            createAccLabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            createAccLabel.ForeColor = Color.Black;
            createAccLabel.Location = new Point(332, 96);
            createAccLabel.Name = "createAccLabel";
            createAccLabel.Size = new Size(144, 40);
            createAccLabel.TabIndex = 23;
            createAccLabel.Text = "Inventory";
            // 
            // loginExitIcon
            // 
            loginExitIcon.BackgroundImage = (Image)resources.GetObject("loginExitIcon.BackgroundImage");
            loginExitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            loginExitIcon.Location = new Point(763, 12);
            loginExitIcon.Name = "loginExitIcon";
            loginExitIcon.Size = new Size(25, 25);
            loginExitIcon.TabIndex = 24;
            loginExitIcon.TabStop = false;
            loginExitIcon.Click += loginExitIcon_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(732, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // InventoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 510);
            Controls.Add(pictureBox2);
            Controls.Add(loginExitIcon);
            Controls.Add(createAccLabel);
            Controls.Add(adminPageLogo);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(customerLstBtn);
            Controls.Add(customerListIcn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InventoryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryView";
            ((System.ComponentModel.ISupportInitialize)customerListIcn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminPageLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginExitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox customerListIcn;
        private Button customerLstBtn;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox adminPageLogo;
        private Label createAccLabel;
        private PictureBox loginExitIcon;
        private PictureBox pictureBox2;
    }
}