namespace GigisCakesAndPastriesGUI
{
    partial class IngredientInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientInventory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            backBtn2 = new PictureBox();
            prdInvLbl = new Label();
            pictureBox4 = new PictureBox();
            searchPicBox = new PictureBox();
            searchBox = new TextBox();
            pictureBox3 = new PictureBox();
            mnlAddBtn = new Button();
            cstmrGrid = new DataGridView();
            pictureBox5 = new PictureBox();
            refreshBtn = new Button();
            IngredientID = new DataGridViewTextBoxColumn();
            IngredientName = new DataGridViewTextBoxColumn();
            Variant = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cstmrGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 129, 240);
            panel2.Controls.Add(backBtn2);
            panel2.Controls.Add(prdInvLbl);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 125);
            panel2.TabIndex = 8;
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
            // prdInvLbl
            // 
            prdInvLbl.AutoSize = true;
            prdInvLbl.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            prdInvLbl.ForeColor = Color.White;
            prdInvLbl.Location = new Point(890, 75);
            prdInvLbl.Name = "prdInvLbl";
            prdInvLbl.Size = new Size(306, 43);
            prdInvLbl.TabIndex = 0;
            prdInvLbl.Text = "Manage Ingredients";
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
            // searchPicBox
            // 
            searchPicBox.BackColor = Color.White;
            searchPicBox.BackgroundImage = (Image)resources.GetObject("searchPicBox.BackgroundImage");
            searchPicBox.BackgroundImageLayout = ImageLayout.Zoom;
            searchPicBox.Location = new Point(12, 138);
            searchPicBox.Name = "searchPicBox";
            searchPicBox.Size = new Size(52, 30);
            searchPicBox.TabIndex = 47;
            searchPicBox.TabStop = false;
            searchPicBox.Click += searchPicBox_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchBox.Location = new Point(63, 138);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Product";
            searchBox.Size = new Size(280, 30);
            searchBox.TabIndex = 48;
            searchBox.KeyPress += searchBox_KeyPress;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(42, 300);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 50);
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
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
            mnlAddBtn.TabIndex = 50;
            mnlAddBtn.Text = "Add";
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
            cstmrGrid.Columns.AddRange(new DataGridViewColumn[] { IngredientID, IngredientName, Variant, Type, Quantity, Unit, Edit, Delete });
            cstmrGrid.Location = new Point(349, 138);
            cstmrGrid.Name = "cstmrGrid";
            cstmrGrid.ReadOnly = true;
            cstmrGrid.RowHeadersWidth = 51;
            cstmrGrid.RowTemplate.Height = 29;
            cstmrGrid.Size = new Size(1500, 390);
            cstmrGrid.TabIndex = 51;
            cstmrGrid.CellContentClick += cstmrGrid_CellContentClick_1;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(42, 356);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 50);
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.FromArgb(15, 129, 240);
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            refreshBtn.ForeColor = Color.White;
            refreshBtn.Location = new Point(100, 356);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(150, 50);
            refreshBtn.TabIndex = 53;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click_1;
            // 
            // IngredientID
            // 
            IngredientID.FillWeight = 97.458374F;
            IngredientID.HeaderText = "Ingredient ID";
            IngredientID.MinimumWidth = 6;
            IngredientID.Name = "IngredientID";
            IngredientID.ReadOnly = true;
            // 
            // IngredientName
            // 
            IngredientName.FillWeight = 97.458374F;
            IngredientName.HeaderText = "Ingredient Name";
            IngredientName.MinimumWidth = 6;
            IngredientName.Name = "IngredientName";
            IngredientName.ReadOnly = true;
            // 
            // Variant
            // 
            Variant.FillWeight = 97.458374F;
            Variant.HeaderText = "Variant";
            Variant.MinimumWidth = 6;
            Variant.Name = "Variant";
            Variant.ReadOnly = true;
            // 
            // Type
            // 
            Type.FillWeight = 97.458374F;
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 97.458374F;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.FillWeight = 97.458374F;
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
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
            // IngredientInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1900, 550);
            Controls.Add(refreshBtn);
            Controls.Add(pictureBox5);
            Controls.Add(cstmrGrid);
            Controls.Add(mnlAddBtn);
            Controls.Add(pictureBox3);
            Controls.Add(searchBox);
            Controls.Add(searchPicBox);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngredientInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngredientInventory";
            Load += IngredientInventory_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cstmrGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox backBtn2;
        private Label prdInvLbl;
        private PictureBox pictureBox4;
        private PictureBox searchPicBox;
        private TextBox searchBox;
        private PictureBox pictureBox3;
        private Button mnlAddBtn;
        public DataGridView cstmrGrid;
        private PictureBox pictureBox5;
        private Button refreshBtn;
        private DataGridViewTextBoxColumn IngredientID;
        private DataGridViewTextBoxColumn IngredientName;
        private DataGridViewTextBoxColumn Variant;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}