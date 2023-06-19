namespace GigisCakesAndPastriesGUI
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            searchBox = new TextBox();
            searchPicBox = new PictureBox();
            panel3 = new Panel();
            indexHide = new Label();
            customerBindingSource = new BindingSource(this.components);
            refreshBtn = new Button();
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
            pictureBox5 = new PictureBox();
            cstmrGrid = new DataGridView();
            hiddent = new Label();
            OrderID = new DataGridViewTextBoxColumn();
            ProductOrdered = new DataGridViewTextBoxColumn();
            ProductSize = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerPhoneNumber = new DataGridViewTextBoxColumn();
            CustomerAddress = new DataGridViewTextBoxColumn();
            OrderOption = new DataGridViewTextBoxColumn();
            PaymentOption = new DataGridViewTextBoxColumn();
            OrderQuantity = new DataGridViewTextBoxColumn();
            OrderTotal = new DataGridViewTextBoxColumn();
            DateOrdered = new DataGridViewTextBoxColumn();
            Confirm = new DataGridViewImageColumn();
            Cancel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)searchPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            mngCstmrPnl.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mngCstmrIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cstmrGrid).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchBox.Location = new Point(63, 138);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search by ID";
            searchBox.Size = new Size(280, 30);
            searchBox.TabIndex = 57;
            // 
            // searchPicBox
            // 
            searchPicBox.BackColor = Color.White;
            searchPicBox.BackgroundImage = (Image)resources.GetObject("searchPicBox.BackgroundImage");
            searchPicBox.BackgroundImageLayout = ImageLayout.Zoom;
            searchPicBox.Location = new Point(12, 138);
            searchPicBox.Name = "searchPicBox";
            searchPicBox.Size = new Size(52, 30);
            searchPicBox.TabIndex = 56;
            searchPicBox.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 129, 240);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.Location = new Point(0, 540);
            panel3.Name = "panel3";
            panel3.Size = new Size(1900, 10);
            panel3.TabIndex = 54;
            // 
            // indexHide
            // 
            indexHide.AutoSize = true;
            indexHide.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            indexHide.ForeColor = Color.Black;
            indexHide.Location = new Point(374, 240);
            indexHide.Name = "indexHide";
            indexHide.Size = new Size(51, 22);
            indexHide.TabIndex = 55;
            indexHide.Text = "label1";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(GigisCakesAndPastries.Customer);
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.FromArgb(15, 129, 240);
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            refreshBtn.ForeColor = Color.White;
            refreshBtn.Location = new Point(100, 329);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(150, 50);
            refreshBtn.TabIndex = 60;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
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
            mngCstmrPnl.TabIndex = 50;
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
            label2.Location = new Point(931, 75);
            label2.Name = "label2";
            label2.Size = new Size(242, 43);
            label2.TabIndex = 0;
            label2.Text = "Manage Orders";
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
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(42, 329);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 50);
            pictureBox5.TabIndex = 59;
            pictureBox5.TabStop = false;
            // 
            // cstmrGrid
            // 
            cstmrGrid.AllowUserToAddRows = false;
            cstmrGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            cstmrGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            cstmrGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cstmrGrid.BackgroundColor = Color.White;
            cstmrGrid.ColumnHeadersHeight = 30;
            cstmrGrid.Columns.AddRange(new DataGridViewColumn[] { OrderID, ProductOrdered, ProductSize, CustomerName, CustomerPhoneNumber, CustomerAddress, OrderOption, PaymentOption, OrderQuantity, OrderTotal, DateOrdered, Confirm, Cancel });
            cstmrGrid.Location = new Point(349, 138);
            cstmrGrid.Name = "cstmrGrid";
            cstmrGrid.ReadOnly = true;
            cstmrGrid.RowHeadersWidth = 51;
            cstmrGrid.RowTemplate.Height = 29;
            cstmrGrid.Size = new Size(1500, 390);
            cstmrGrid.TabIndex = 52;
            // 
            // hiddent
            // 
            hiddent.AutoSize = true;
            hiddent.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            hiddent.ForeColor = Color.White;
            hiddent.Location = new Point(358, 174);
            hiddent.Name = "hiddent";
            hiddent.Size = new Size(130, 43);
            hiddent.TabIndex = 53;
            hiddent.Text = "hiddent";
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Order ID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            // 
            // ProductOrdered
            // 
            ProductOrdered.HeaderText = "Product Ordered";
            ProductOrdered.MinimumWidth = 6;
            ProductOrdered.Name = "ProductOrdered";
            ProductOrdered.ReadOnly = true;
            // 
            // ProductSize
            // 
            ProductSize.HeaderText = "Product Size";
            ProductSize.MinimumWidth = 6;
            ProductSize.Name = "ProductSize";
            ProductSize.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // CustomerPhoneNumber
            // 
            CustomerPhoneNumber.HeaderText = "Customer Phone Number";
            CustomerPhoneNumber.MinimumWidth = 6;
            CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            CustomerPhoneNumber.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            CustomerAddress.HeaderText = "Customer Address";
            CustomerAddress.MinimumWidth = 6;
            CustomerAddress.Name = "CustomerAddress";
            CustomerAddress.ReadOnly = true;
            // 
            // OrderOption
            // 
            OrderOption.HeaderText = "Order Option";
            OrderOption.MinimumWidth = 6;
            OrderOption.Name = "OrderOption";
            OrderOption.ReadOnly = true;
            // 
            // PaymentOption
            // 
            PaymentOption.HeaderText = "Payment Option";
            PaymentOption.MinimumWidth = 6;
            PaymentOption.Name = "PaymentOption";
            PaymentOption.ReadOnly = true;
            // 
            // OrderQuantity
            // 
            OrderQuantity.HeaderText = "Order Quantity";
            OrderQuantity.MinimumWidth = 6;
            OrderQuantity.Name = "OrderQuantity";
            OrderQuantity.ReadOnly = true;
            // 
            // OrderTotal
            // 
            OrderTotal.HeaderText = "Order Total";
            OrderTotal.MinimumWidth = 6;
            OrderTotal.Name = "OrderTotal";
            OrderTotal.ReadOnly = true;
            // 
            // DateOrdered
            // 
            DateOrdered.HeaderText = "Date Ordered";
            DateOrdered.MinimumWidth = 6;
            DateOrdered.Name = "DateOrdered";
            DateOrdered.ReadOnly = true;
            // 
            // Confirm
            // 
            Confirm.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Confirm.Description = "Confirm";
            Confirm.HeaderText = "";
            Confirm.Image = (Image)resources.GetObject("Confirm.Image");
            Confirm.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Confirm.MinimumWidth = 6;
            Confirm.Name = "Confirm";
            Confirm.ReadOnly = true;
            Confirm.ToolTipText = "Confirm";
            Confirm.Width = 6;
            // 
            // Cancel
            // 
            Cancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cancel.Description = "Cancel";
            Cancel.HeaderText = "";
            Cancel.Image = (Image)resources.GetObject("Cancel.Image");
            Cancel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Cancel.MinimumWidth = 6;
            Cancel.Name = "Cancel";
            Cancel.ReadOnly = true;
            Cancel.ToolTipText = "Cancel";
            Cancel.Width = 6;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1900, 550);
            Controls.Add(searchBox);
            Controls.Add(searchPicBox);
            Controls.Add(panel3);
            Controls.Add(refreshBtn);
            Controls.Add(mngCstmrPnl);
            Controls.Add(pictureBox5);
            Controls.Add(cstmrGrid);
            Controls.Add(hiddent);
            Controls.Add(indexHide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            ((System.ComponentModel.ISupportInitialize)searchPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)cstmrGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchBox;
        private PictureBox searchPicBox;
        private Panel panel3;
        public Label indexHide;
        private BindingSource customerBindingSource;
        private Button refreshBtn;
        private Panel mngCstmrPnl;
        private Panel panel1;
        private Panel panel2;
        private PictureBox backBtn2;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox backBtn;
        private Label mngCstmrLbl;
        private PictureBox mngCstmrIcon;
        private PictureBox pictureBox5;
        public DataGridView cstmrGrid;
        public Label hiddent;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn ProductOrdered;
        private DataGridViewTextBoxColumn ProductSize;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerPhoneNumber;
        private DataGridViewTextBoxColumn CustomerAddress;
        private DataGridViewTextBoxColumn OrderOption;
        private DataGridViewTextBoxColumn PaymentOption;
        private DataGridViewTextBoxColumn OrderQuantity;
        private DataGridViewTextBoxColumn OrderTotal;
        private DataGridViewTextBoxColumn DateOrdered;
        private DataGridViewImageColumn Confirm;
        private DataGridViewImageColumn Cancel;
    }
}