namespace GigisCakesAndPastriesGUI
{
    partial class CSignOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSignOut));
            noBtn = new Button();
            yesBtn = new Button();
            decisionLabel = new Label();
            SuspendLayout();
            // 
            // noBtn
            // 
            noBtn.BackColor = Color.FromArgb(15, 129, 240);
            noBtn.FlatStyle = FlatStyle.Flat;
            noBtn.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            noBtn.ForeColor = Color.White;
            noBtn.Location = new Point(190, 100);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(94, 29);
            noBtn.TabIndex = 5;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.Click += noBtn_Click;
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.FromArgb(15, 129, 240);
            yesBtn.FlatStyle = FlatStyle.Flat;
            yesBtn.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(50, 100);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(94, 29);
            yesBtn.TabIndex = 4;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
            // 
            // decisionLabel
            // 
            decisionLabel.AutoSize = true;
            decisionLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            decisionLabel.Location = new Point(112, 50);
            decisionLabel.Name = "decisionLabel";
            decisionLabel.Size = new Size(107, 16);
            decisionLabel.TabIndex = 3;
            decisionLabel.Text = "Sign Out and Exit?";
            // 
            // CSignOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 166);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(decisionLabel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CSignOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSignOut";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button noBtn;
        private Button yesBtn;
        private Label decisionLabel;
    }
}