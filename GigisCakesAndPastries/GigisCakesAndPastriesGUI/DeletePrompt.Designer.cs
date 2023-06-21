namespace GigisCakesAndPastriesGUI
{
    partial class DeletePrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePrompt));
            decisionLabel = new Label();
            yesBtn = new Button();
            noBtn = new Button();
            delProIcon = new PictureBox();
            birthdateLabel2 = new Label();
            idHidee = new Label();
            indexHide = new Label();
            ((System.ComponentModel.ISupportInitialize)delProIcon).BeginInit();
            SuspendLayout();
            // 
            // decisionLabel
            // 
            decisionLabel.AutoSize = true;
            decisionLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            decisionLabel.Location = new Point(75, 100);
            decisionLabel.Name = "decisionLabel";
            decisionLabel.Size = new Size(336, 22);
            decisionLabel.TabIndex = 1;
            decisionLabel.Text = "Are you sure that you want to delete this User?";
            decisionLabel.Click += decisionLabel_Click;
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
            yesBtn.TabIndex = 2;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
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
            noBtn.TabIndex = 3;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.Click += noBtn_Click;
            // 
            // delProIcon
            // 
            delProIcon.BackgroundImage = (Image)resources.GetObject("delProIcon.BackgroundImage");
            delProIcon.BackgroundImageLayout = ImageLayout.Stretch;
            delProIcon.Location = new Point(200, 10);
            delProIcon.Name = "delProIcon";
            delProIcon.Size = new Size(88, 83);
            delProIcon.TabIndex = 4;
            delProIcon.TabStop = false;
            delProIcon.Click += delProIcon_Click;
            // 
            // birthdateLabel2
            // 
            birthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            birthdateLabel2.ForeColor = Color.DimGray;
            birthdateLabel2.Location = new Point(60, 125);
            birthdateLabel2.Name = "birthdateLabel2";
            birthdateLabel2.Size = new Size(365, 37);
            birthdateLabel2.TabIndex = 7;
            birthdateLabel2.Text = "Everything will be permanently deleted and the customer won't be able to log in on this username anymore";
            birthdateLabel2.Click += birthdateLabel2_Click;
            // 
            // idHidee
            // 
            idHidee.AutoSize = true;
            idHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idHidee.ForeColor = Color.Black;
            idHidee.Location = new Point(200, 71);
            idHidee.Name = "idHidee";
            idHidee.Size = new Size(51, 22);
            idHidee.TabIndex = 42;
            idHidee.Text = "label1";
            idHidee.Click += idHidee_Click;
            // 
            // indexHide
            // 
            indexHide.AutoSize = true;
            indexHide.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            indexHide.ForeColor = Color.Black;
            indexHide.Location = new Point(237, 71);
            indexHide.Name = "indexHide";
            indexHide.Size = new Size(51, 22);
            indexHide.TabIndex = 45;
            indexHide.Text = "label1";
            indexHide.Click += indexHide_Click;
            // 
            // DeletePrompt
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeletePrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeletePrompt";
            ((System.ComponentModel.ISupportInitialize)delProIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label decisionLabel;
        private Button yesBtn;
        private Button noBtn;
        private PictureBox delProIcon;
        private Label birthdateLabel2;
        public Label idHidee;
        public Label indexHide;
    }
}