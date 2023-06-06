namespace GigisCakesAndPastriesGUI
{
    partial class ManageCustomers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            this.mngCstmrPnl = new Panel();
            this.panel1 = new Panel();
            this.panel2 = new Panel();
            this.backBtn2 = new PictureBox();
            this.label2 = new Label();
            this.pictureBox4 = new PictureBox();
            this.hiddent = new Label();
            this.pictureBox1 = new PictureBox();
            this.label1 = new Label();
            this.pictureBox2 = new PictureBox();
            this.backBtn = new PictureBox();
            this.mngCstmrLbl = new Label();
            this.mngCstmrIcon = new PictureBox();
            this.mnlAddBtn = new Button();
            this.mnlEdtBtn = new Button();
            this.deleteBtn = new Button();
            this.cstmrGrid = new DataGridView();
            this.loyaltyPointsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.birthMonthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.accountDateCreateadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.Edit = new DataGridViewImageColumn();
            this.Delete = new DataGridViewImageColumn();
            this.customerBindingSource = new BindingSource(this.components);
            this.panel3 = new Panel();
            this.refreshBtn = new Button();
            this.mngCstmrPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.backBtn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.mngCstmrIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cstmrGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mngCstmrPnl
            // 
            this.mngCstmrPnl.BackColor = Color.FromArgb(15, 129, 240);
            this.mngCstmrPnl.Controls.Add(this.panel1);
            this.mngCstmrPnl.Controls.Add(this.backBtn);
            this.mngCstmrPnl.Controls.Add(this.mngCstmrLbl);
            this.mngCstmrPnl.Controls.Add(this.mngCstmrIcon);
            this.mngCstmrPnl.Dock = DockStyle.Top;
            this.mngCstmrPnl.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.mngCstmrPnl.Location = new Point(0, 0);
            this.mngCstmrPnl.Name = "mngCstmrPnl";
            this.mngCstmrPnl.Size = new Size(1900, 125);
            this.mngCstmrPnl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(15, 129, 240);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1900, 125);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = Color.FromArgb(15, 129, 240);
            this.panel2.Controls.Add(this.backBtn2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = DockStyle.Top;
            this.panel2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.panel2.Location = new Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1900, 125);
            this.panel2.TabIndex = 6;
            // 
            // backBtn2
            // 
            this.backBtn2.BackgroundImage = (Image)resources.GetObject("backBtn2.BackgroundImage");
            this.backBtn2.BackgroundImageLayout = ImageLayout.Stretch;
            this.backBtn2.Image = (Image)resources.GetObject("backBtn2.Image");
            this.backBtn2.Location = new Point(12, 12);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new Size(25, 25);
            this.backBtn2.TabIndex = 4;
            this.backBtn2.TabStop = false;
            this.backBtn2.Click += backBtn2_Click;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(900, 75);
            this.label2.Name = "label2";
            this.label2.Size = new Size(301, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Customers";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            this.pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox4.Location = new Point(950, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(200, 50);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // hiddent
            // 
            this.hiddent.AutoSize = true;
            this.hiddent.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.hiddent.ForeColor = Color.White;
            this.hiddent.Location = new Point(358, 174);
            this.hiddent.Name = "hiddent";
            this.hiddent.Size = new Size(105, 43);
            this.hiddent.TabIndex = 5;
            this.hiddent.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(25, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(275, 75);
            this.label1.Name = "label1";
            this.label1.Size = new Size(301, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Customers";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            this.pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox2.Location = new Point(325, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(200, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            this.backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            this.backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            this.backBtn.Location = new Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new Size(25, 25);
            this.backBtn.TabIndex = 4;
            this.backBtn.TabStop = false;
            // 
            // mngCstmrLbl
            // 
            this.mngCstmrLbl.AutoSize = true;
            this.mngCstmrLbl.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.mngCstmrLbl.ForeColor = Color.White;
            this.mngCstmrLbl.Location = new Point(275, 75);
            this.mngCstmrLbl.Name = "mngCstmrLbl";
            this.mngCstmrLbl.Size = new Size(301, 43);
            this.mngCstmrLbl.TabIndex = 0;
            this.mngCstmrLbl.Text = "Manage Customers";
            // 
            // mngCstmrIcon
            // 
            this.mngCstmrIcon.BackgroundImage = (Image)resources.GetObject("mngCstmrIcon.BackgroundImage");
            this.mngCstmrIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.mngCstmrIcon.Location = new Point(325, 10);
            this.mngCstmrIcon.Name = "mngCstmrIcon";
            this.mngCstmrIcon.Size = new Size(200, 50);
            this.mngCstmrIcon.TabIndex = 1;
            this.mngCstmrIcon.TabStop = false;
            // 
            // mnlAddBtn
            // 
            this.mnlAddBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.mnlAddBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlAddBtn.ForeColor = Color.White;
            this.mnlAddBtn.Location = new Point(100, 225);
            this.mnlAddBtn.Name = "mnlAddBtn";
            this.mnlAddBtn.Size = new Size(150, 50);
            this.mnlAddBtn.TabIndex = 1;
            this.mnlAddBtn.Text = "Manual Add";
            this.mnlAddBtn.UseVisualStyleBackColor = false;
            this.mnlAddBtn.Click += mnlAddBtn_Click;
            // 
            // mnlEdtBtn
            // 
            this.mnlEdtBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.mnlEdtBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.mnlEdtBtn.ForeColor = Color.White;
            this.mnlEdtBtn.Location = new Point(100, 281);
            this.mnlEdtBtn.Name = "mnlEdtBtn";
            this.mnlEdtBtn.Size = new Size(150, 50);
            this.mnlEdtBtn.TabIndex = 2;
            this.mnlEdtBtn.Text = "Manual Edit";
            this.mnlEdtBtn.UseVisualStyleBackColor = false;
            this.mnlEdtBtn.Click += mnlEdtBtn_Click;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.deleteBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.deleteBtn.ForeColor = Color.White;
            this.deleteBtn.Location = new Point(100, 337);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new Size(150, 50);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += deleteBtn_Click;
            // 
            // cstmrGrid
            // 
            this.cstmrGrid.AllowUserToAddRows = false;
            this.cstmrGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.cstmrGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cstmrGrid.AutoGenerateColumns = false;
            this.cstmrGrid.BackgroundColor = Color.White;
            this.cstmrGrid.ColumnHeadersHeight = 30;
            this.cstmrGrid.Columns.AddRange(new DataGridViewColumn[] { this.loyaltyPointsDataGridViewTextBoxColumn, this.iDDataGridViewTextBoxColumn, this.surnameDataGridViewTextBoxColumn, this.firstnameDataGridViewTextBoxColumn, this.middleNameDataGridViewTextBoxColumn, this.emailDataGridViewTextBoxColumn, this.usernameDataGridViewTextBoxColumn, this.phoneNumberDataGridViewTextBoxColumn, this.addressDataGridViewTextBoxColumn, this.birthMonthDataGridViewTextBoxColumn, this.birthDateDataGridViewTextBoxColumn, this.birthYearDataGridViewTextBoxColumn, this.accountDateCreateadDataGridViewTextBoxColumn, this.Edit, this.Delete });
            this.cstmrGrid.DataSource = this.customerBindingSource;
            this.cstmrGrid.Location = new Point(349, 138);
            this.cstmrGrid.Name = "cstmrGrid";
            this.cstmrGrid.ReadOnly = true;
            this.cstmrGrid.RowHeadersWidth = 51;
            this.cstmrGrid.RowTemplate.Height = 29;
            this.cstmrGrid.Size = new Size(1500, 390);
            this.cstmrGrid.TabIndex = 4;
            this.cstmrGrid.CellContentClick += cstmrGrid_CellContentClick;
            // 
            // loyaltyPointsDataGridViewTextBoxColumn
            // 
            this.loyaltyPointsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.loyaltyPointsDataGridViewTextBoxColumn.DataPropertyName = "LoyaltyPoints";
            this.loyaltyPointsDataGridViewTextBoxColumn.HeaderText = "Loyalty Points";
            this.loyaltyPointsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loyaltyPointsDataGridViewTextBoxColumn.Name = "loyaltyPointsDataGridViewTextBoxColumn";
            this.loyaltyPointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.loyaltyPointsDataGridViewTextBoxColumn.Width = 128;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 53;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 96;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 109;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Width = 129;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 75;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 104;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 137;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 91;
            // 
            // birthMonthDataGridViewTextBoxColumn
            // 
            this.birthMonthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.birthMonthDataGridViewTextBoxColumn.DataPropertyName = "BirthMonth";
            this.birthMonthDataGridViewTextBoxColumn.HeaderText = "Birth Month";
            this.birthMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthMonthDataGridViewTextBoxColumn.Name = "birthMonthDataGridViewTextBoxColumn";
            this.birthMonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthMonthDataGridViewTextBoxColumn.Width = 116;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDateDataGridViewTextBoxColumn.Width = 105;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "Birth Year";
            this.birthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            this.birthYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthYearDataGridViewTextBoxColumn.Width = 101;
            // 
            // accountDateCreateadDataGridViewTextBoxColumn
            // 
            this.accountDateCreateadDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.accountDateCreateadDataGridViewTextBoxColumn.DataPropertyName = "AccountDateCreatead";
            this.accountDateCreateadDataGridViewTextBoxColumn.HeaderText = "Account Date Createad";
            this.accountDateCreateadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountDateCreateadDataGridViewTextBoxColumn.Name = "accountDateCreateadDataGridViewTextBoxColumn";
            this.accountDateCreateadDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountDateCreateadDataGridViewTextBoxColumn.Width = 192;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = (Image)resources.GetObject("Edit.Image");
            this.Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = (Image)resources.GetObject("Delete.Image");
            this.Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 6;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(GigisCakesAndPastries.Customer);
            // 
            // panel3
            // 
            this.panel3.BackColor = Color.FromArgb(15, 129, 240);
            this.panel3.Dock = DockStyle.Bottom;
            this.panel3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.panel3.Location = new Point(0, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(1900, 10);
            this.panel3.TabIndex = 7;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = Color.FromArgb(15, 129, 240);
            this.refreshBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.refreshBtn.ForeColor = Color.White;
            this.refreshBtn.Location = new Point(100, 393);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new Size(150, 50);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += refreshBtn_Click;
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1900, 550);
            Controls.Add(this.refreshBtn);
            Controls.Add(this.panel3);
            Controls.Add(this.deleteBtn);
            Controls.Add(this.mnlEdtBtn);
            Controls.Add(this.mnlAddBtn);
            Controls.Add(this.mngCstmrPnl);
            Controls.Add(this.cstmrGrid);
            Controls.Add(this.hiddent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Customers";
            Load += ManageCustomers_Load;
            this.mngCstmrPnl.ResumeLayout(false);
            this.mngCstmrPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.backBtn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.mngCstmrIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cstmrGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mngCstmrPnl;
        private Label mngCstmrLbl;
        private PictureBox mngCstmrIcon;
        private Button mnlAddBtn;
        private Button mnlEdtBtn;
        private Button deleteBtn;
        private PictureBox backBtn;
        private Panel panel1;
        private Panel panel2;
        private PictureBox backBtn2;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel3;
        public DataGridView cstmrGrid;
        private Button refreshBtn;
        private DataGridViewTextBoxColumn loyaltyPointsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthMonthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountDateCreateadDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        public BindingSource customerBindingSource;
        public Label hiddent;
    }
}