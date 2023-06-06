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
            this.decisionLabel = new Label();
            this.yesBtn = new Button();
            this.noBtn = new Button();
            this.delProIcon = new PictureBox();
            this.birthdateLabel2 = new Label();
            this.idHidee = new Label();
            ((System.ComponentModel.ISupportInitialize)this.delProIcon).BeginInit();
            SuspendLayout();
            // 
            // decisionLabel
            // 
            this.decisionLabel.AutoSize = true;
            this.decisionLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.decisionLabel.Location = new Point(75, 100);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new Size(336, 22);
            this.decisionLabel.TabIndex = 1;
            this.decisionLabel.Text = "Are you sure that you want to delete this User?";
            this.decisionLabel.Click += decisionLabel_Click;
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.yesBtn.FlatStyle = FlatStyle.Flat;
            this.yesBtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.yesBtn.ForeColor = Color.White;
            this.yesBtn.Location = new Point(100, 190);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new Size(94, 29);
            this.yesBtn.TabIndex = 2;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += yesBtn_Click;
            // 
            // noBtn
            // 
            this.noBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.noBtn.FlatStyle = FlatStyle.Flat;
            this.noBtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.noBtn.ForeColor = Color.White;
            this.noBtn.Location = new Point(290, 190);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new Size(94, 29);
            this.noBtn.TabIndex = 3;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += noBtn_Click;
            // 
            // delProIcon
            // 
            this.delProIcon.BackgroundImage = (Image)resources.GetObject("delProIcon.BackgroundImage");
            this.delProIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.delProIcon.Location = new Point(200, 10);
            this.delProIcon.Name = "delProIcon";
            this.delProIcon.Size = new Size(88, 83);
            this.delProIcon.TabIndex = 4;
            this.delProIcon.TabStop = false;
            this.delProIcon.Click += delProIcon_Click;
            // 
            // birthdateLabel2
            // 
            this.birthdateLabel2.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.birthdateLabel2.ForeColor = Color.DimGray;
            this.birthdateLabel2.Location = new Point(60, 125);
            this.birthdateLabel2.Name = "birthdateLabel2";
            this.birthdateLabel2.Size = new Size(365, 37);
            this.birthdateLabel2.TabIndex = 7;
            this.birthdateLabel2.Text = "Everything will be permanently deleted and the customer won't be able to log in on this username anymore";
            this.birthdateLabel2.Click += birthdateLabel2_Click;
            // 
            // idHidee
            // 
            this.idHidee.AutoSize = true;
            this.idHidee.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.idHidee.ForeColor = Color.Black;
            this.idHidee.Location = new Point(200, 71);
            this.idHidee.Name = "idHidee";
            this.idHidee.Size = new Size(51, 22);
            this.idHidee.TabIndex = 42;
            this.idHidee.Text = "label1";
            this.idHidee.Click += idHidee_Click;
            // 
            // DeletePrompt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(this.birthdateLabel2);
            Controls.Add(this.delProIcon);
            Controls.Add(this.noBtn);
            Controls.Add(this.yesBtn);
            Controls.Add(this.decisionLabel);
            Controls.Add(this.idHidee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeletePrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeletePrompt";
            ((System.ComponentModel.ISupportInitialize)this.delProIcon).EndInit();
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
    }
}