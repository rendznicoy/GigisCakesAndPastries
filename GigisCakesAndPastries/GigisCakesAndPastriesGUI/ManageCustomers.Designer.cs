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
            mngCstmrPnl = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            backBtn2 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            backBtn = new PictureBox();
            mngCstmrLbl = new Label();
            mngCstmrIcon = new PictureBox();
            hiddent = new Label();
            mnlAddBtn = new Button();
            mnlEdtBtn = new Button();
            deleteBtn = new Button();
            cstmrGrid = new DataGridView();
            loyaltyPointsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthMonthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountDateCreateadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            customerBindingSource = new BindingSource(this.components);
            panel3 = new Panel();
            refreshBtn = new Button();
            indexHide = new Label();
            mngCstmrPnl.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mngCstmrIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cstmrGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mngCstmrPnl
            // 
            mngCstmrPnl.BackColor = Color.FromArgb(15, 129, 240);
            mngCstmrPnl.Controls.Add(panel1);
            mngCstmrPnl.Controls.Add(backBtn);
            mngCstmrPnl.Controls.Add(mngCstmrLbl);
            mngCstmrPnl.Controls.Add(mngCstmrIcon);
            mngCstmrPnl.Dock = DockStyle.Top;
            mngCstmrPnl.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            mngCstmrPnl.Location = new Point(0, 0);
            mngCstmrPnl.Name = "mngCstmrPnl";
            mngCstmrPnl.Size = new Size(1900, 125);
            mngCstmrPnl.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 129, 240);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 125);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 129, 240);
            panel2.Controls.Add(backBtn2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 125);
            panel2.TabIndex = 6;
            // 
            // backBtn2
            // 
            backBtn2.BackgroundImage = (Image)resources.GetObject("backBtn2.BackgroundImage");
            backBtn2.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn2.Image = (Image)resources.GetObject("backBtn2.Image");
            backBtn2.Location = new Point(12, 12);
            backBtn2.Name = "backBtn2";
            backBtn2.Size = new Size(25, 25);
            backBtn2.TabIndex = 4;
            backBtn2.TabStop = false;
            backBtn2.Click += backBtn2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(900, 75);
            label2.Name = "label2";
            label2.Size = new Size(301, 43);
            label2.TabIndex = 0;
            label2.Text = "Manage Customers";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(950, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 50);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 75);
            label1.Name = "label1";
            label1.Size = new Size(301, 43);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(325, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(25, 25);
            backBtn.TabIndex = 4;
            backBtn.TabStop = false;
            // 
            // mngCstmrLbl
            // 
            mngCstmrLbl.AutoSize = true;
            mngCstmrLbl.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            mngCstmrLbl.ForeColor = Color.White;
            mngCstmrLbl.Location = new Point(275, 75);
            mngCstmrLbl.Name = "mngCstmrLbl";
            mngCstmrLbl.Size = new Size(301, 43);
            mngCstmrLbl.TabIndex = 0;
            mngCstmrLbl.Text = "Manage Customers";
            // 
            // mngCstmrIcon
            // 
            mngCstmrIcon.BackgroundImage = (Image)resources.GetObject("mngCstmrIcon.BackgroundImage");
            mngCstmrIcon.BackgroundImageLayout = ImageLayout.Stretch;
            mngCstmrIcon.Location = new Point(325, 10);
            mngCstmrIcon.Name = "mngCstmrIcon";
            mngCstmrIcon.Size = new Size(200, 50);
            mngCstmrIcon.TabIndex = 1;
            mngCstmrIcon.TabStop = false;
            // 
            // hiddent
            // 
            hiddent.AutoSize = true;
            hiddent.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            hiddent.ForeColor = Color.White;
            hiddent.Location = new Point(358, 174);
            hiddent.Name = "hiddent";
            hiddent.Size = new Size(105, 43);
            hiddent.TabIndex = 5;
            hiddent.Text = "label1";
            // 
            // mnlAddBtn
            // 
            mnlAddBtn.BackColor = Color.FromArgb(15, 129, 240);
            mnlAddBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnlAddBtn.ForeColor = Color.White;
            mnlAddBtn.Location = new Point(100, 225);
            mnlAddBtn.Name = "mnlAddBtn";
            mnlAddBtn.Size = new Size(150, 50);
            mnlAddBtn.TabIndex = 1;
            mnlAddBtn.Text = "Manual Add";
            mnlAddBtn.UseVisualStyleBackColor = false;
            mnlAddBtn.Click += mnlAddBtn_Click;
            // 
            // mnlEdtBtn
            // 
            mnlEdtBtn.BackColor = Color.FromArgb(15, 129, 240);
            mnlEdtBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnlEdtBtn.ForeColor = Color.White;
            mnlEdtBtn.Location = new Point(100, 281);
            mnlEdtBtn.Name = "mnlEdtBtn";
            mnlEdtBtn.Size = new Size(150, 50);
            mnlEdtBtn.TabIndex = 2;
            mnlEdtBtn.Text = "Manual Edit";
            mnlEdtBtn.UseVisualStyleBackColor = false;
            mnlEdtBtn.Click += mnlEdtBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(15, 129, 240);
            deleteBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(100, 337);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(150, 50);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cstmrGrid
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            cstmrGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            cstmrGrid.AutoGenerateColumns = false;
            cstmrGrid.BackgroundColor = Color.White;
            cstmrGrid.ColumnHeadersHeight = 30;
            cstmrGrid.Columns.AddRange(new DataGridViewColumn[] { loyaltyPointsDataGridViewTextBoxColumn, iDDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, firstnameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, birthMonthDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, birthYearDataGridViewTextBoxColumn, accountDateCreateadDataGridViewTextBoxColumn, Edit, Delete });
            cstmrGrid.DataSource = customerBindingSource;
            cstmrGrid.Location = new Point(349, 138);
            cstmrGrid.Name = "cstmrGrid";
            cstmrGrid.ReadOnly = true;
            cstmrGrid.RowHeadersWidth = 51;
            cstmrGrid.RowTemplate.Height = 29;
            cstmrGrid.Size = new Size(1500, 390);
            cstmrGrid.TabIndex = 4;
            cstmrGrid.CellContentClick += cstmrGrid_CellContentClick;
            // 
            // loyaltyPointsDataGridViewTextBoxColumn
            // 
            loyaltyPointsDataGridViewTextBoxColumn.DataPropertyName = "LoyaltyPoints";
            loyaltyPointsDataGridViewTextBoxColumn.HeaderText = "Loyalty Points";
            loyaltyPointsDataGridViewTextBoxColumn.MinimumWidth = 6;
            loyaltyPointsDataGridViewTextBoxColumn.Name = "loyaltyPointsDataGridViewTextBoxColumn";
            loyaltyPointsDataGridViewTextBoxColumn.ReadOnly = true;
            loyaltyPointsDataGridViewTextBoxColumn.Width = 124;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 53;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ReadOnly = true;
            surnameDataGridViewTextBoxColumn.Width = 96;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            firstnameDataGridViewTextBoxColumn.Width = 102;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 75;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            usernameDataGridViewTextBoxColumn.Width = 104;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 133;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 91;
            // 
            // birthMonthDataGridViewTextBoxColumn
            // 
            birthMonthDataGridViewTextBoxColumn.DataPropertyName = "BirthMonth";
            birthMonthDataGridViewTextBoxColumn.HeaderText = "Birth Month";
            birthMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthMonthDataGridViewTextBoxColumn.Name = "birthMonthDataGridViewTextBoxColumn";
            birthMonthDataGridViewTextBoxColumn.ReadOnly = true;
            birthMonthDataGridViewTextBoxColumn.Width = 112;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            birthDateDataGridViewTextBoxColumn.Width = 101;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            birthYearDataGridViewTextBoxColumn.HeaderText = "Birth Year";
            birthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            birthYearDataGridViewTextBoxColumn.ReadOnly = true;
            birthYearDataGridViewTextBoxColumn.Width = 97;
            // 
            // accountDateCreateadDataGridViewTextBoxColumn
            // 
            accountDateCreateadDataGridViewTextBoxColumn.DataPropertyName = "AccountDateCreatead";
            accountDateCreateadDataGridViewTextBoxColumn.HeaderText = "Account Date Createad";
            accountDateCreateadDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountDateCreateadDataGridViewTextBoxColumn.Name = "accountDateCreateadDataGridViewTextBoxColumn";
            accountDateCreateadDataGridViewTextBoxColumn.ReadOnly = true;
            accountDateCreateadDataGridViewTextBoxColumn.Width = 184;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.Description = "Edit";
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.ToolTipText = "Edit";
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.Description = "Delete";
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.ToolTipText = "Delete";
            Delete.Width = 6;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(GigisCakesAndPastries.Customer);
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 129, 240);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.Location = new Point(0, 540);
            panel3.Name = "panel3";
            panel3.Size = new Size(1900, 10);
            panel3.TabIndex = 7;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.FromArgb(15, 129, 240);
            refreshBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            refreshBtn.ForeColor = Color.White;
            refreshBtn.Location = new Point(100, 393);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(150, 50);
            refreshBtn.TabIndex = 8;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // indexHide
            // 
            indexHide.AutoSize = true;
            indexHide.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            indexHide.ForeColor = Color.Black;
            indexHide.Location = new Point(374, 240);
            indexHide.Name = "indexHide";
            indexHide.Size = new Size(51, 22);
            indexHide.TabIndex = 44;
            indexHide.Text = "label1";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1900, 550);
            Controls.Add(refreshBtn);
            Controls.Add(panel3);
            Controls.Add(deleteBtn);
            Controls.Add(mnlEdtBtn);
            Controls.Add(mnlAddBtn);
            Controls.Add(mngCstmrPnl);
            Controls.Add(cstmrGrid);
            Controls.Add(hiddent);
            Controls.Add(indexHide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Customers";
            Load += ManageCustomers_Load;
            mngCstmrPnl.ResumeLayout(false);
            mngCstmrPnl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)mngCstmrIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)cstmrGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
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
        public BindingSource customerBindingSource;
        public Label hiddent;
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
        public Label indexHide;
    }
}