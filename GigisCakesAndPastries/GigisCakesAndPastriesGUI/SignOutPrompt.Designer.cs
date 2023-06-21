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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignOutPrompt));
            decisionLabel = new Label();
            yesBtn = new Button();
            noBtn = new Button();
            SuspendLayout();
            // 
            // decisionLabel
            // 
            decisionLabel.AutoSize = true;
            decisionLabel.Location = new Point(112, 50);
            decisionLabel.Name = "decisionLabel";
            decisionLabel.Size = new Size(107, 16);
            decisionLabel.TabIndex = 0;
            decisionLabel.Text = "Sign Out and Exit?";
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.FromArgb(15, 129, 240);
            yesBtn.FlatStyle = FlatStyle.Flat;
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(50, 100);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(94, 29);
            yesBtn.TabIndex = 1;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
            // 
            // noBtn
            // 
            noBtn.BackColor = Color.FromArgb(15, 129, 240);
            noBtn.FlatStyle = FlatStyle.Flat;
            noBtn.ForeColor = Color.White;
            noBtn.Location = new Point(190, 100);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(94, 29);
            noBtn.TabIndex = 2;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.Click += noBtn_Click;
            // 
            // SignOutPrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 166);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(decisionLabel);
            Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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