namespace GigisCakesAndPastriesGUI
{
    partial class DeleteOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteOrder));
            birthdateLabel2 = new Label();
            delProIcon = new PictureBox();
            noBtn = new Button();
            yesBtn = new Button();
            decisionLabel = new Label();
            idHidee = new Label();
            indexHide = new Label();
            ((System.ComponentModel.ISupportInitialize)delProIcon).BeginInit();
            SuspendLayout();
            // 
            // birthdateLabel2
            // 
            birthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            birthdateLabel2.ForeColor = Color.DimGray;
            birthdateLabel2.Location = new Point(60, 125);
            birthdateLabel2.Name = "birthdateLabel2";
            birthdateLabel2.Size = new Size(365, 37);
            birthdateLabel2.TabIndex = 50;
            birthdateLabel2.Text = "Everything will be permanently deleted and you won't be able to retrieve any details about this order";
            // 
            // delProIcon
            // 
            delProIcon.BackgroundImage = (Image)resources.GetObject("delProIcon.BackgroundImage");
            delProIcon.BackgroundImageLayout = ImageLayout.Stretch;
            delProIcon.Location = new Point(200, 10);
            delProIcon.Name = "delProIcon";
            delProIcon.Size = new Size(88, 83);
            delProIcon.TabIndex = 49;
            delProIcon.TabStop = false;
            // 
            // noBtn
            // 
            noBtn.BackColor = Color.FromArgb(15, 129, 240);
            noBtn.FlatStyle = FlatStyle.Flat;
            noBtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            noBtn.ForeColor = Color.White;
            noBtn.Location = new Point(290, 190);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(94, 29);
            noBtn.TabIndex = 48;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.Click += noBtn_Click;
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.FromArgb(15, 129, 240);
            yesBtn.FlatStyle = FlatStyle.Flat;
            yesBtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(100, 190);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(94, 29);
            yesBtn.TabIndex = 47;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
            // 
            // decisionLabel
            // 
            decisionLabel.AutoSize = true;
            decisionLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            decisionLabel.Location = new Point(75, 100);
            decisionLabel.Name = "decisionLabel";
            decisionLabel.Size = new Size(344, 22);
            decisionLabel.TabIndex = 46;
            decisionLabel.Text = "Are you sure that you want to delete this Order?";
            // 
            // idHidee
            // 
            idHidee.AutoSize = true;
            idHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idHidee.ForeColor = Color.Black;
            idHidee.Location = new Point(200, 71);
            idHidee.Name = "idHidee";
            idHidee.Size = new Size(51, 22);
            idHidee.TabIndex = 51;
            idHidee.Text = "label1";
            // 
            // indexHide
            // 
            indexHide.AutoSize = true;
            indexHide.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            indexHide.ForeColor = Color.Black;
            indexHide.Location = new Point(237, 71);
            indexHide.Name = "indexHide";
            indexHide.Size = new Size(51, 22);
            indexHide.TabIndex = 52;
            indexHide.Text = "label1";
            // 
            // DeleteOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 253);
            Controls.Add(birthdateLabel2);
            Controls.Add(delProIcon);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(decisionLabel);
            Controls.Add(idHidee);
            Controls.Add(indexHide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteOrder";
            ((System.ComponentModel.ISupportInitialize)delProIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label birthdateLabel2;
        private PictureBox delProIcon;
        private Button noBtn;
        private Button yesBtn;
        private Label decisionLabel;
        public Label idHidee;
        public Label indexHide;
    }
}