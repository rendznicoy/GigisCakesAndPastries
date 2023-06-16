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
            cstmrGrid = new DataGridView();
            LoyaltyPoints = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            BirthMonth = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            BirthYear = new DataGridViewTextBoxColumn();
            AccountDateCreated = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel3 = new Panel();
            indexHide = new Label();
            searchPicBox = new PictureBox();
            searchBox = new TextBox();
            customerBindingSource = new BindingSource(this.components);
            pictureBox3 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)searchPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            mnlAddBtn.FlatStyle = FlatStyle.Flat;
            mnlAddBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnlAddBtn.ForeColor = Color.White;
            mnlAddBtn.Location = new Point(100, 300);
            mnlAddBtn.Name = "mnlAddBtn";
            mnlAddBtn.Size = new Size(150, 50);
            mnlAddBtn.TabIndex = 1;
            mnlAddBtn.Text = "Manual Add";
            mnlAddBtn.UseVisualStyleBackColor = false;
            mnlAddBtn.Click += mnlAddBtn_Click;
            // 
            // cstmrGrid
            // 
            cstmrGrid.AllowUserToAddRows = false;
            cstmrGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            cstmrGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            cstmrGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cstmrGrid.BackgroundColor = Color.White;
            cstmrGrid.ColumnHeadersHeight = 30;
            cstmrGrid.Columns.AddRange(new DataGridViewColumn[] { LoyaltyPoints, ID, Surname, FirstName, MiddleName, Email, Username, PhoneNumber, Address, BirthMonth, BirthDate, BirthYear, AccountDateCreated, Edit, Delete });
            cstmrGrid.Location = new Point(349, 138);
            cstmrGrid.Name = "cstmrGrid";
            cstmrGrid.ReadOnly = true;
            cstmrGrid.RowHeadersWidth = 51;
            cstmrGrid.RowTemplate.Height = 29;
            cstmrGrid.Size = new Size(1500, 390);
            cstmrGrid.TabIndex = 4;
            cstmrGrid.CellContentClick += cstmrGrid_CellContentClick;
            // 
            // LoyaltyPoints
            // 
            LoyaltyPoints.HeaderText = "Loyalty Points";
            LoyaltyPoints.MinimumWidth = 6;
            LoyaltyPoints.Name = "LoyaltyPoints";
            LoyaltyPoints.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            MiddleName.HeaderText = "Middle Name";
            MiddleName.MinimumWidth = 6;
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // BirthMonth
            // 
            BirthMonth.HeaderText = "Birth Month";
            BirthMonth.MinimumWidth = 6;
            BirthMonth.Name = "BirthMonth";
            BirthMonth.ReadOnly = true;
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "Birth Date";
            BirthDate.MinimumWidth = 6;
            BirthDate.Name = "BirthDate";
            BirthDate.ReadOnly = true;
            // 
            // BirthYear
            // 
            BirthYear.HeaderText = "Birth Year";
            BirthYear.MinimumWidth = 6;
            BirthYear.Name = "BirthYear";
            BirthYear.ReadOnly = true;
            // 
            // AccountDateCreated
            // 
            AccountDateCreated.HeaderText = "Account Date Created";
            AccountDateCreated.MinimumWidth = 6;
            AccountDateCreated.Name = "AccountDateCreated";
            AccountDateCreated.ReadOnly = true;
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
            // searchPicBox
            // 
            searchPicBox.BackColor = Color.White;
            searchPicBox.BackgroundImage = (Image)resources.GetObject("searchPicBox.BackgroundImage");
            searchPicBox.BackgroundImageLayout = ImageLayout.Zoom;
            searchPicBox.Location = new Point(12, 138);
            searchPicBox.Name = "searchPicBox";
            searchPicBox.Size = new Size(52, 30);
            searchPicBox.TabIndex = 45;
            searchPicBox.TabStop = false;
            searchPicBox.Click += searchPicBox_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchBox.Location = new Point(63, 138);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search by ID";
            searchBox.Size = new Size(280, 30);
            searchBox.TabIndex = 46;
            searchBox.KeyPress += searchBox_KeyPress;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(GigisCakesAndPastries.Customer);
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(42, 300);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 50);
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1900, 550);
            Controls.Add(pictureBox3);
            Controls.Add(searchBox);
            Controls.Add(searchPicBox);
            Controls.Add(panel3);
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
            ((System.ComponentModel.ISupportInitialize)searchPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mngCstmrPnl;
        private Label mngCstmrLbl;
        private PictureBox mngCstmrIcon;
        private Button mnlAddBtn;
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
        public Label hiddent;
        public Label indexHide;
        private PictureBox searchPicBox;
        private TextBox searchBox;
        private DataGridViewTextBoxColumn LoyaltyPoints;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn BirthMonth;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn BirthYear;
        private DataGridViewTextBoxColumn AccountDateCreated;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private BindingSource customerBindingSource;
        private PictureBox pictureBox3;
    }
}