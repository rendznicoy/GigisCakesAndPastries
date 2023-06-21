namespace GigisCakesAndPastriesGUI
{
    partial class Notice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notice));
            delProIcon = new PictureBox();
            decisionLabel = new Label();
            yesBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)delProIcon).BeginInit();
            SuspendLayout();
            // 
            // delProIcon
            // 
            delProIcon.BackgroundImage = (Image)resources.GetObject("delProIcon.BackgroundImage");
            delProIcon.BackgroundImageLayout = ImageLayout.Stretch;
            delProIcon.Location = new Point(200, 10);
            delProIcon.Name = "delProIcon";
            delProIcon.Size = new Size(88, 83);
            delProIcon.TabIndex = 50;
            delProIcon.TabStop = false;
            // 
            // decisionLabel
            // 
            decisionLabel.AutoSize = true;
            decisionLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            decisionLabel.Location = new Point(102, 110);
            decisionLabel.Name = "decisionLabel";
            decisionLabel.Size = new Size(277, 22);
            decisionLabel.TabIndex = 51;
            decisionLabel.Text = "You have successfully placed an order";
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.FromArgb(15, 129, 240);
            yesBtn.FlatStyle = FlatStyle.Flat;
            yesBtn.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(200, 190);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(94, 29);
            yesBtn.TabIndex = 52;
            yesBtn.Text = "Thanks!";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 150);
            label1.Name = "label1";
            label1.Size = new Size(444, 22);
            label1.TabIndex = 53;
            label1.Text = "We will contact you as soon as possible for order confirmation";
            // 
            // Notice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 253);
            Controls.Add(label1);
            Controls.Add(yesBtn);
            Controls.Add(decisionLabel);
            Controls.Add(delProIcon);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Notice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notice";
            Load += Notice_Load;
            ((System.ComponentModel.ISupportInitialize)delProIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox delProIcon;
        private Label decisionLabel;
        private Button yesBtn;
        private Label label1;
    }
}