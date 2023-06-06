namespace GigisCakesAndPastriesGUI
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.entrCstmrLabel = new Label();
            this.idBox = new TextBox();
            this.searchBtn = new Button();
            this.exitIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.exitIcon).BeginInit();
            SuspendLayout();
            // 
            // entrCstmrLabel
            // 
            this.entrCstmrLabel.AutoSize = true;
            this.entrCstmrLabel.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.entrCstmrLabel.ForeColor = Color.Black;
            this.entrCstmrLabel.Location = new Point(110, 25);
            this.entrCstmrLabel.Name = "entrCstmrLabel";
            this.entrCstmrLabel.Size = new Size(160, 22);
            this.entrCstmrLabel.TabIndex = 2;
            this.entrCstmrLabel.Text = "ENTER CUSTOMER ID";
            // 
            // idBox
            // 
            this.idBox.BackColor = Color.White;
            this.idBox.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.idBox.Location = new Point(40, 75);
            this.idBox.Name = "idBox";
            this.idBox.PlaceholderText = "Enter ID";
            this.idBox.Size = new Size(300, 27);
            this.idBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = FlatStyle.Flat;
            this.searchBtn.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.searchBtn.ForeColor = Color.White;
            this.searchBtn.Location = new Point(40, 125);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new Size(300, 40);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += searchBtn_Click;
            // 
            // exitIcon
            // 
            this.exitIcon.BackgroundImage = (Image)resources.GetObject("exitIcon.BackgroundImage");
            this.exitIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.exitIcon.Location = new Point(12, 12);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new Size(25, 25);
            this.exitIcon.TabIndex = 14;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += exitIcon_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 200);
            Controls.Add(this.exitIcon);
            Controls.Add(this.searchBtn);
            Controls.Add(this.idBox);
            Controls.Add(this.entrCstmrLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteUser";
            ((System.ComponentModel.ISupportInitialize)this.exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label entrCstmrLabel;
        private Button searchBtn;
        private PictureBox exitIcon;
        public TextBox idBox;
    }
}