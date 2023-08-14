
namespace C968KyleG
{
    partial class mainScreenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventoryManagmentLbl = new System.Windows.Forms.Label();
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainScreenPartslbl = new System.Windows.Forms.Label();
            this.mainScreenProductslbl = new System.Windows.Forms.Label();
            this.partSearchbtn = new System.Windows.Forms.Button();
            this.productSearchbtn = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.partDeletebtn = new System.Windows.Forms.Button();
            this.partModifybtn = new System.Windows.Forms.Button();
            this.partAddBtn = new System.Windows.Forms.Button();
            this.productDeletebtn = new System.Windows.Forms.Button();
            this.productModifybtn = new System.Windows.Forms.Button();
            this.productAddbtn = new System.Windows.Forms.Button();
            this.mainScreenExitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryManagmentLbl
            // 
            this.inventoryManagmentLbl.AutoSize = true;
            this.inventoryManagmentLbl.Location = new System.Drawing.Point(14, 9);
            this.inventoryManagmentLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.inventoryManagmentLbl.Name = "inventoryManagmentLbl";
            this.inventoryManagmentLbl.Size = new System.Drawing.Size(301, 30);
            this.inventoryManagmentLbl.TabIndex = 0;
            this.inventoryManagmentLbl.Text = "Inventory Management System";
            // 
            // PartsDataGridView
            // 
            this.PartsDataGridView.AllowUserToAddRows = false;
            this.PartsDataGridView.AllowUserToDeleteRows = false;
            this.PartsDataGridView.AllowUserToResizeColumns = false;
            this.PartsDataGridView.AllowUserToResizeRows = false;
            this.PartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGridView.Location = new System.Drawing.Point(12, 151);
            this.PartsDataGridView.MultiSelect = false;
            this.PartsDataGridView.Name = "PartsDataGridView";
            this.PartsDataGridView.RowHeadersVisible = false;
            this.PartsDataGridView.RowTemplate.Height = 25;
            this.PartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataGridView.Size = new System.Drawing.Size(604, 323);
            this.PartsDataGridView.TabIndex = 1;
            this.PartsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataGridView_CellContentClick);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.AllowUserToResizeColumns = false;
            this.ProductsDataGridView.AllowUserToResizeRows = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(636, 151);
            this.ProductsDataGridView.MultiSelect = false;
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDataGridView.RowTemplate.Height = 25;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(604, 323);
            this.ProductsDataGridView.TabIndex = 2;
            // 
            // mainScreenPartslbl
            // 
            this.mainScreenPartslbl.AutoSize = true;
            this.mainScreenPartslbl.Location = new System.Drawing.Point(12, 118);
            this.mainScreenPartslbl.Name = "mainScreenPartslbl";
            this.mainScreenPartslbl.Size = new System.Drawing.Size(58, 30);
            this.mainScreenPartslbl.TabIndex = 3;
            this.mainScreenPartslbl.Text = "Parts";
            // 
            // mainScreenProductslbl
            // 
            this.mainScreenProductslbl.AutoSize = true;
            this.mainScreenProductslbl.Location = new System.Drawing.Point(636, 118);
            this.mainScreenProductslbl.Name = "mainScreenProductslbl";
            this.mainScreenProductslbl.Size = new System.Drawing.Size(94, 30);
            this.mainScreenProductslbl.TabIndex = 4;
            this.mainScreenProductslbl.Text = "Products";
            // 
            // partSearchbtn
            // 
            this.partSearchbtn.Enabled = false;
            this.partSearchbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partSearchbtn.Location = new System.Drawing.Point(330, 118);
            this.partSearchbtn.Name = "partSearchbtn";
            this.partSearchbtn.Size = new System.Drawing.Size(75, 30);
            this.partSearchbtn.TabIndex = 5;
            this.partSearchbtn.Text = "Search";
            this.partSearchbtn.UseVisualStyleBackColor = true;
            this.partSearchbtn.Click += new System.EventHandler(this.partSearchbtn_Click);
            // 
            // productSearchbtn
            // 
            this.productSearchbtn.Enabled = false;
            this.productSearchbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productSearchbtn.Location = new System.Drawing.Point(954, 118);
            this.productSearchbtn.Name = "productSearchbtn";
            this.productSearchbtn.Size = new System.Drawing.Size(75, 30);
            this.productSearchbtn.TabIndex = 6;
            this.productSearchbtn.Text = "Search";
            this.productSearchbtn.UseVisualStyleBackColor = true;
            this.productSearchbtn.Click += new System.EventHandler(this.productSearchbtn_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partSearchBox.Location = new System.Drawing.Point(411, 122);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.PlaceholderText = "Part ID";
            this.partSearchBox.Size = new System.Drawing.Size(205, 25);
            this.partSearchBox.TabIndex = 7;
            this.partSearchBox.TextChanged += new System.EventHandler(this.partSearchBox_TextChanged);
            this.partSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partSearchBox_KeyPress);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productSearchBox.Location = new System.Drawing.Point(1035, 122);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.PlaceholderText = "Part ID";
            this.productSearchBox.Size = new System.Drawing.Size(205, 25);
            this.productSearchBox.TabIndex = 8;
            this.productSearchBox.TextChanged += new System.EventHandler(this.productSearchBox_TextChanged);
            this.productSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productSearchBox_KeyPress);
            // 
            // partDeletebtn
            // 
            this.partDeletebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partDeletebtn.Location = new System.Drawing.Point(541, 480);
            this.partDeletebtn.Name = "partDeletebtn";
            this.partDeletebtn.Size = new System.Drawing.Size(75, 40);
            this.partDeletebtn.TabIndex = 9;
            this.partDeletebtn.Text = "Delete";
            this.partDeletebtn.UseVisualStyleBackColor = true;
            this.partDeletebtn.Click += new System.EventHandler(this.partDeletebtn_Click);
            // 
            // partModifybtn
            // 
            this.partModifybtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partModifybtn.Location = new System.Drawing.Point(460, 480);
            this.partModifybtn.Name = "partModifybtn";
            this.partModifybtn.Size = new System.Drawing.Size(75, 40);
            this.partModifybtn.TabIndex = 10;
            this.partModifybtn.Text = "Modify";
            this.partModifybtn.UseVisualStyleBackColor = true;
            this.partModifybtn.Click += new System.EventHandler(this.partModifybtn_Click);
            // 
            // partAddBtn
            // 
            this.partAddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partAddBtn.Location = new System.Drawing.Point(379, 480);
            this.partAddBtn.Name = "partAddBtn";
            this.partAddBtn.Size = new System.Drawing.Size(75, 40);
            this.partAddBtn.TabIndex = 11;
            this.partAddBtn.Text = "Add";
            this.partAddBtn.UseVisualStyleBackColor = true;
            this.partAddBtn.Click += new System.EventHandler(this.partAddBtn_Click);
            // 
            // productDeletebtn
            // 
            this.productDeletebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productDeletebtn.Location = new System.Drawing.Point(1165, 480);
            this.productDeletebtn.Name = "productDeletebtn";
            this.productDeletebtn.Size = new System.Drawing.Size(75, 40);
            this.productDeletebtn.TabIndex = 12;
            this.productDeletebtn.Text = "Delete";
            this.productDeletebtn.UseVisualStyleBackColor = true;
            this.productDeletebtn.Click += new System.EventHandler(this.productDeletebtn_Click);
            // 
            // productModifybtn
            // 
            this.productModifybtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productModifybtn.Location = new System.Drawing.Point(1084, 480);
            this.productModifybtn.Name = "productModifybtn";
            this.productModifybtn.Size = new System.Drawing.Size(75, 40);
            this.productModifybtn.TabIndex = 13;
            this.productModifybtn.Text = "Modify";
            this.productModifybtn.UseVisualStyleBackColor = true;
            this.productModifybtn.Click += new System.EventHandler(this.productModifybtn_Click);
            // 
            // productAddbtn
            // 
            this.productAddbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAddbtn.Location = new System.Drawing.Point(1003, 480);
            this.productAddbtn.Name = "productAddbtn";
            this.productAddbtn.Size = new System.Drawing.Size(75, 40);
            this.productAddbtn.TabIndex = 14;
            this.productAddbtn.Text = "Add";
            this.productAddbtn.UseVisualStyleBackColor = true;
            this.productAddbtn.Click += new System.EventHandler(this.productAddbtn_Click);
            // 
            // mainScreenExitbtn
            // 
            this.mainScreenExitbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainScreenExitbtn.Location = new System.Drawing.Point(1165, 542);
            this.mainScreenExitbtn.Name = "mainScreenExitbtn";
            this.mainScreenExitbtn.Size = new System.Drawing.Size(75, 40);
            this.mainScreenExitbtn.TabIndex = 15;
            this.mainScreenExitbtn.Text = "Exit";
            this.mainScreenExitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mainScreenExitbtn.UseVisualStyleBackColor = true;
            this.mainScreenExitbtn.Click += new System.EventHandler(this.mainScreenExitbtn_Click);
            // 
            // mainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 594);
            this.Controls.Add(this.mainScreenExitbtn);
            this.Controls.Add(this.productAddbtn);
            this.Controls.Add(this.productModifybtn);
            this.Controls.Add(this.productDeletebtn);
            this.Controls.Add(this.partAddBtn);
            this.Controls.Add(this.partModifybtn);
            this.Controls.Add(this.partDeletebtn);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.productSearchbtn);
            this.Controls.Add(this.partSearchbtn);
            this.Controls.Add(this.mainScreenProductslbl);
            this.Controls.Add(this.mainScreenPartslbl);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.PartsDataGridView);
            this.Controls.Add(this.inventoryManagmentLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "mainScreenForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.mainScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryManagmentLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn partId;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMax;
        private System.Windows.Forms.Label mainScreenPartslbl;
        private System.Windows.Forms.Label mainScreenProductslbl;
        private System.Windows.Forms.Button partSearchbtn;
        private System.Windows.Forms.Button productSearchbtn;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button partDeletebtn;
        private System.Windows.Forms.Button partModifybtn;
        private System.Windows.Forms.Button partAddBtn;
        private System.Windows.Forms.Button productDeletebtn;
        private System.Windows.Forms.Button productModifybtn;
        private System.Windows.Forms.Button productAddbtn;
        private System.Windows.Forms.Button mainScreenExitbtn;
        public System.Windows.Forms.DataGridView PartsDataGridView;
        public System.Windows.Forms.DataGridView ProductsDataGridView;

        public int partSearchBoxText { get { return int.Parse(partSearchBox.Text); } set { partSearchBox.Text = value.ToString(); } }

        public int productSearchBoxText { get { return int.Parse(productSearchBox.Text); } set { productSearchBox.Text = value.ToString(); } }
    }
}

