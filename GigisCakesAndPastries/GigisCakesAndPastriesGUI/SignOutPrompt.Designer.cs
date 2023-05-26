namespace GigisCakesAndPastriesGUI
{
    partial class SignOutPrompt
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
            this.decisionLabel = new Label();
            this.yesBtn = new Button();
            this.noBtn = new Button();
            SuspendLayout();
            // 
            // decisionLabel
            // 
            this.decisionLabel.AutoSize = true;
            this.decisionLabel.Location = new Point(112, 50);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new Size(107, 16);
            this.decisionLabel.TabIndex = 0;
            this.decisionLabel.Text = "Sign Out and Exit?";
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.yesBtn.FlatStyle = FlatStyle.Flat;
            this.yesBtn.ForeColor = Color.White;
            this.yesBtn.Location = new Point(50, 100);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new Size(94, 29);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += yesBtn_Click;
            // 
            // noBtn
            // 
            this.noBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.noBtn.FlatStyle = FlatStyle.Flat;
            this.noBtn.ForeColor = Color.White;
            this.noBtn.Location = new Point(190, 100);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new Size(94, 29);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += noBtn_Click;
            // 
            // SignOutPrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 166);
            Controls.Add(this.noBtn);
            Controls.Add(this.yesBtn);
            Controls.Add(this.decisionLabel);
            Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignOutPrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label decisionLabel;
        private Button yesBtn;
        private Button noBtn;
    }
}