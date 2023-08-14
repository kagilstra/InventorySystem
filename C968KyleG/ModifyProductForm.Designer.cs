namespace C968KyleG
{
    partial class ModifyProductForm
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
            this.ModifyProductlbl = new System.Windows.Forms.Label();
            this.ModifyProductCandidateParts = new System.Windows.Forms.DataGridView();
            this.ModifyProductAssociatedParts = new System.Windows.Forms.DataGridView();
            this.modifyProductCandidatePartslbl = new System.Windows.Forms.Label();
            this.modifyProductAssociatedPartslbl = new System.Windows.Forms.Label();
            this.modifyProductSearchbtn = new System.Windows.Forms.Button();
            this.ModifyProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductCandiatePartsbtn = new System.Windows.Forms.Button();
            this.modifyProductDeleteAssociatedPartbtn = new System.Windows.Forms.Button();
            this.modifyProductCancelbtn = new System.Windows.Forms.Button();
            this.modifyProductSavebtn = new System.Windows.Forms.Button();
            this.modifyProductIDlbl = new System.Windows.Forms.Label();
            this.modifyProductNamelbl = new System.Windows.Forms.Label();
            this.modifyProductInventorylbl = new System.Windows.Forms.Label();
            this.modifyProductPricelbl = new System.Windows.Forms.Label();
            this.modifyProductMaxlbl = new System.Windows.Forms.Label();
            this.modifyProductMinlbl = new System.Windows.Forms.Label();
            this.modifyProductIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMinTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProductCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProductAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyProductlbl
            // 
            this.ModifyProductlbl.AutoSize = true;
            this.ModifyProductlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyProductlbl.Location = new System.Drawing.Point(12, 9);
            this.ModifyProductlbl.Name = "ModifyProductlbl";
            this.ModifyProductlbl.Size = new System.Drawing.Size(142, 25);
            this.ModifyProductlbl.TabIndex = 1;
            this.ModifyProductlbl.Text = "Modify Product";
            // 
            // ModifyProductCandidateParts
            // 
            this.ModifyProductCandidateParts.AllowUserToAddRows = false;
            this.ModifyProductCandidateParts.AllowUserToDeleteRows = false;
            this.ModifyProductCandidateParts.AllowUserToResizeColumns = false;
            this.ModifyProductCandidateParts.AllowUserToResizeRows = false;
            this.ModifyProductCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModifyProductCandidateParts.Location = new System.Drawing.Point(448, 36);
            this.ModifyProductCandidateParts.MultiSelect = false;
            this.ModifyProductCandidateParts.Name = "ModifyProductCandidateParts";
            this.ModifyProductCandidateParts.RowHeadersVisible = false;
            this.ModifyProductCandidateParts.RowTemplate.Height = 25;
            this.ModifyProductCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModifyProductCandidateParts.Size = new System.Drawing.Size(590, 150);
            this.ModifyProductCandidateParts.TabIndex = 8;
            // 
            // ModifyProductAssociatedParts
            // 
            this.ModifyProductAssociatedParts.AllowUserToAddRows = false;
            this.ModifyProductAssociatedParts.AllowUserToDeleteRows = false;
            this.ModifyProductAssociatedParts.AllowUserToResizeColumns = false;
            this.ModifyProductAssociatedParts.AllowUserToResizeRows = false;
            this.ModifyProductAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModifyProductAssociatedParts.Location = new System.Drawing.Point(448, 248);
            this.ModifyProductAssociatedParts.MultiSelect = false;
            this.ModifyProductAssociatedParts.Name = "ModifyProductAssociatedParts";
            this.ModifyProductAssociatedParts.RowHeadersVisible = false;
            this.ModifyProductAssociatedParts.RowTemplate.Height = 25;
            this.ModifyProductAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModifyProductAssociatedParts.Size = new System.Drawing.Size(590, 150);
            this.ModifyProductAssociatedParts.TabIndex = 9;
            // 
            // modifyProductCandidatePartslbl
            // 
            this.modifyProductCandidatePartslbl.AutoSize = true;
            this.modifyProductCandidatePartslbl.Location = new System.Drawing.Point(448, 19);
            this.modifyProductCandidatePartslbl.Name = "modifyProductCandidatePartslbl";
            this.modifyProductCandidatePartslbl.Size = new System.Drawing.Size(107, 15);
            this.modifyProductCandidatePartslbl.TabIndex = 10;
            this.modifyProductCandidatePartslbl.Text = "All Candidate Parts";
            // 
            // modifyProductAssociatedPartslbl
            // 
            this.modifyProductAssociatedPartslbl.AutoSize = true;
            this.modifyProductAssociatedPartslbl.Location = new System.Drawing.Point(448, 230);
            this.modifyProductAssociatedPartslbl.Name = "modifyProductAssociatedPartslbl";
            this.modifyProductAssociatedPartslbl.Size = new System.Drawing.Size(186, 15);
            this.modifyProductAssociatedPartslbl.TabIndex = 11;
            this.modifyProductAssociatedPartslbl.Text = "Parts Associated with this Product";
            // 
            // modifyProductSearchbtn
            // 
            this.modifyProductSearchbtn.Enabled = false;
            this.modifyProductSearchbtn.Location = new System.Drawing.Point(761, 7);
            this.modifyProductSearchbtn.Name = "modifyProductSearchbtn";
            this.modifyProductSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.modifyProductSearchbtn.TabIndex = 23;
            this.modifyProductSearchbtn.Text = "Search";
            this.modifyProductSearchbtn.UseVisualStyleBackColor = true;
            this.modifyProductSearchbtn.Click += new System.EventHandler(this.modifyProductSearchbtn_Click);
            // 
            // ModifyProductSearchTextBox
            // 
            this.ModifyProductSearchTextBox.Location = new System.Drawing.Point(842, 7);
            this.ModifyProductSearchTextBox.Name = "ModifyProductSearchTextBox";
            this.ModifyProductSearchTextBox.Size = new System.Drawing.Size(196, 23);
            this.ModifyProductSearchTextBox.TabIndex = 24;
            this.ModifyProductSearchTextBox.TextChanged += new System.EventHandler(this.modifyProductSearchTextBox_TextChanged);
            this.ModifyProductSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modifyProductSearchTextBox_KeyPress);
            // 
            // modifyProductCandiatePartsbtn
            // 
            this.modifyProductCandiatePartsbtn.Location = new System.Drawing.Point(963, 192);
            this.modifyProductCandiatePartsbtn.Name = "modifyProductCandiatePartsbtn";
            this.modifyProductCandiatePartsbtn.Size = new System.Drawing.Size(75, 35);
            this.modifyProductCandiatePartsbtn.TabIndex = 25;
            this.modifyProductCandiatePartsbtn.Text = "Add";
            this.modifyProductCandiatePartsbtn.UseVisualStyleBackColor = true;
            this.modifyProductCandiatePartsbtn.Click += new System.EventHandler(this.modifyProductCandiatePartsbtn_Click);
            // 
            // modifyProductDeleteAssociatedPartbtn
            // 
            this.modifyProductDeleteAssociatedPartbtn.Location = new System.Drawing.Point(963, 404);
            this.modifyProductDeleteAssociatedPartbtn.Name = "modifyProductDeleteAssociatedPartbtn";
            this.modifyProductDeleteAssociatedPartbtn.Size = new System.Drawing.Size(75, 35);
            this.modifyProductDeleteAssociatedPartbtn.TabIndex = 26;
            this.modifyProductDeleteAssociatedPartbtn.Text = "Delete";
            this.modifyProductDeleteAssociatedPartbtn.UseVisualStyleBackColor = true;
            this.modifyProductDeleteAssociatedPartbtn.Click += new System.EventHandler(this.modifyProductDeleteAssociatedPartbtn_Click);
            // 
            // modifyProductCancelbtn
            // 
            this.modifyProductCancelbtn.Location = new System.Drawing.Point(963, 447);
            this.modifyProductCancelbtn.Name = "modifyProductCancelbtn";
            this.modifyProductCancelbtn.Size = new System.Drawing.Size(75, 35);
            this.modifyProductCancelbtn.TabIndex = 27;
            this.modifyProductCancelbtn.Text = "Cancel";
            this.modifyProductCancelbtn.UseVisualStyleBackColor = true;
            this.modifyProductCancelbtn.Click += new System.EventHandler(this.modifyProductCancelbtn_Click);
            // 
            // modifyProductSavebtn
            // 
            this.modifyProductSavebtn.Enabled = false;
            this.modifyProductSavebtn.Location = new System.Drawing.Point(882, 447);
            this.modifyProductSavebtn.Name = "modifyProductSavebtn";
            this.modifyProductSavebtn.Size = new System.Drawing.Size(75, 35);
            this.modifyProductSavebtn.TabIndex = 28;
            this.modifyProductSavebtn.Text = "Save";
            this.modifyProductSavebtn.UseVisualStyleBackColor = true;
            this.modifyProductSavebtn.Click += new System.EventHandler(this.modifyProductSavebtn_Click);
            // 
            // modifyProductIDlbl
            // 
            this.modifyProductIDlbl.AutoSize = true;
            this.modifyProductIDlbl.Location = new System.Drawing.Point(92, 151);
            this.modifyProductIDlbl.Name = "modifyProductIDlbl";
            this.modifyProductIDlbl.Size = new System.Drawing.Size(18, 15);
            this.modifyProductIDlbl.TabIndex = 29;
            this.modifyProductIDlbl.Text = "ID";
            // 
            // modifyProductNamelbl
            // 
            this.modifyProductNamelbl.AutoSize = true;
            this.modifyProductNamelbl.Location = new System.Drawing.Point(71, 180);
            this.modifyProductNamelbl.Name = "modifyProductNamelbl";
            this.modifyProductNamelbl.Size = new System.Drawing.Size(39, 15);
            this.modifyProductNamelbl.TabIndex = 30;
            this.modifyProductNamelbl.Text = "Name";
            // 
            // modifyProductInventorylbl
            // 
            this.modifyProductInventorylbl.AutoSize = true;
            this.modifyProductInventorylbl.Location = new System.Drawing.Point(53, 209);
            this.modifyProductInventorylbl.Name = "modifyProductInventorylbl";
            this.modifyProductInventorylbl.Size = new System.Drawing.Size(57, 15);
            this.modifyProductInventorylbl.TabIndex = 31;
            this.modifyProductInventorylbl.Text = "Inventory";
            // 
            // modifyProductPricelbl
            // 
            this.modifyProductPricelbl.AutoSize = true;
            this.modifyProductPricelbl.Location = new System.Drawing.Point(77, 238);
            this.modifyProductPricelbl.Name = "modifyProductPricelbl";
            this.modifyProductPricelbl.Size = new System.Drawing.Size(33, 15);
            this.modifyProductPricelbl.TabIndex = 32;
            this.modifyProductPricelbl.Text = "Price";
            // 
            // modifyProductMaxlbl
            // 
            this.modifyProductMaxlbl.AutoSize = true;
            this.modifyProductMaxlbl.Location = new System.Drawing.Point(80, 273);
            this.modifyProductMaxlbl.Name = "modifyProductMaxlbl";
            this.modifyProductMaxlbl.Size = new System.Drawing.Size(30, 15);
            this.modifyProductMaxlbl.TabIndex = 33;
            this.modifyProductMaxlbl.Text = "Max";
            // 
            // modifyProductMinlbl
            // 
            this.modifyProductMinlbl.AutoSize = true;
            this.modifyProductMinlbl.Location = new System.Drawing.Point(197, 273);
            this.modifyProductMinlbl.Name = "modifyProductMinlbl";
            this.modifyProductMinlbl.Size = new System.Drawing.Size(28, 15);
            this.modifyProductMinlbl.TabIndex = 34;
            this.modifyProductMinlbl.Text = "Min";
            // 
            // modifyProductIDTextBox
            // 
            this.modifyProductIDTextBox.Location = new System.Drawing.Point(129, 148);
            this.modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            this.modifyProductIDTextBox.PlaceholderText = "Auto-Incremented";
            this.modifyProductIDTextBox.ReadOnly = true;
            this.modifyProductIDTextBox.Size = new System.Drawing.Size(164, 23);
            this.modifyProductIDTextBox.TabIndex = 35;
            // 
            // modifyProductNameTextBox
            // 
            this.modifyProductNameTextBox.Location = new System.Drawing.Point(129, 177);
            this.modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            this.modifyProductNameTextBox.PlaceholderText = "Product Name";
            this.modifyProductNameTextBox.Size = new System.Drawing.Size(164, 23);
            this.modifyProductNameTextBox.TabIndex = 36;
            this.modifyProductNameTextBox.TextChanged += new System.EventHandler(this.modifyProductNameTextBox_TextChanged);
            // 
            // modifyProductInventoryTextBox
            // 
            this.modifyProductInventoryTextBox.Location = new System.Drawing.Point(129, 206);
            this.modifyProductInventoryTextBox.Name = "modifyProductInventoryTextBox";
            this.modifyProductInventoryTextBox.PlaceholderText = "Stock";
            this.modifyProductInventoryTextBox.Size = new System.Drawing.Size(164, 23);
            this.modifyProductInventoryTextBox.TabIndex = 37;
            this.modifyProductInventoryTextBox.TextChanged += new System.EventHandler(this.modifyProductInventoryTextBox_TextChanged);
            // 
            // modifyProductPriceTextBox
            // 
            this.modifyProductPriceTextBox.Location = new System.Drawing.Point(129, 235);
            this.modifyProductPriceTextBox.Name = "modifyProductPriceTextBox";
            this.modifyProductPriceTextBox.PlaceholderText = "00.00";
            this.modifyProductPriceTextBox.Size = new System.Drawing.Size(164, 23);
            this.modifyProductPriceTextBox.TabIndex = 38;
            this.modifyProductPriceTextBox.TextChanged += new System.EventHandler(this.modifyProductPriceTextBox_TextChanged);
            // 
            // modifyProductMaxTextBox
            // 
            this.modifyProductMaxTextBox.Location = new System.Drawing.Point(129, 270);
            this.modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            this.modifyProductMaxTextBox.PlaceholderText = "Integer";
            this.modifyProductMaxTextBox.Size = new System.Drawing.Size(53, 23);
            this.modifyProductMaxTextBox.TabIndex = 39;
            this.modifyProductMaxTextBox.TextChanged += new System.EventHandler(this.modifyProductMaxTextBox_TextChanged);
            // 
            // modifyProductMinTextBox
            // 
            this.modifyProductMinTextBox.Location = new System.Drawing.Point(240, 270);
            this.modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            this.modifyProductMinTextBox.PlaceholderText = "Integer";
            this.modifyProductMinTextBox.Size = new System.Drawing.Size(53, 23);
            this.modifyProductMinTextBox.TabIndex = 40;
            this.modifyProductMinTextBox.TextChanged += new System.EventHandler(this.modifyProductMinTextBox_TextChanged);
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 494);
            this.Controls.Add(this.modifyProductMinTextBox);
            this.Controls.Add(this.modifyProductMaxTextBox);
            this.Controls.Add(this.modifyProductPriceTextBox);
            this.Controls.Add(this.modifyProductInventoryTextBox);
            this.Controls.Add(this.modifyProductNameTextBox);
            this.Controls.Add(this.modifyProductIDTextBox);
            this.Controls.Add(this.modifyProductMinlbl);
            this.Controls.Add(this.modifyProductMaxlbl);
            this.Controls.Add(this.modifyProductPricelbl);
            this.Controls.Add(this.modifyProductInventorylbl);
            this.Controls.Add(this.modifyProductNamelbl);
            this.Controls.Add(this.modifyProductIDlbl);
            this.Controls.Add(this.modifyProductSavebtn);
            this.Controls.Add(this.modifyProductCancelbtn);
            this.Controls.Add(this.modifyProductDeleteAssociatedPartbtn);
            this.Controls.Add(this.modifyProductCandiatePartsbtn);
            this.Controls.Add(this.ModifyProductSearchTextBox);
            this.Controls.Add(this.modifyProductSearchbtn);
            this.Controls.Add(this.modifyProductAssociatedPartslbl);
            this.Controls.Add(this.modifyProductCandidatePartslbl);
            this.Controls.Add(this.ModifyProductAssociatedParts);
            this.Controls.Add(this.ModifyProductCandidateParts);
            this.Controls.Add(this.ModifyProductlbl);
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProductCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProductAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyProductlbl;
        private System.Windows.Forms.DataGridView ModifyProductCandidateParts;
        private System.Windows.Forms.DataGridView ModifyProductAssociatedParts;
        private System.Windows.Forms.Label modifyProductCandidatePartslbl;
        private System.Windows.Forms.Label modifyProductAssociatedPartslbl;
        private System.Windows.Forms.Button modifyProductSearchbtn;
        private System.Windows.Forms.TextBox ModifyProductSearchTextBox;
        private System.Windows.Forms.Button modifyProductCandiatePartsbtn;
        private System.Windows.Forms.Button modifyProductDeleteAssociatedPartbtn;
        private System.Windows.Forms.Button modifyProductCancelbtn;
        private System.Windows.Forms.Button modifyProductSavebtn;
        private System.Windows.Forms.Label modifyProductIDlbl;
        private System.Windows.Forms.Label modifyProductNamelbl;
        private System.Windows.Forms.Label modifyProductInventorylbl;
        private System.Windows.Forms.Label modifyProductPricelbl;
        private System.Windows.Forms.Label modifyProductMaxlbl;
        private System.Windows.Forms.Label modifyProductMinlbl;
        private System.Windows.Forms.TextBox modifyProductIDTextBox;
        private System.Windows.Forms.TextBox modifyProductNameTextBox;
        private System.Windows.Forms.TextBox modifyProductInventoryTextBox;
        private System.Windows.Forms.TextBox modifyProductPriceTextBox;
        private System.Windows.Forms.TextBox modifyProductMaxTextBox;
        private System.Windows.Forms.TextBox modifyProductMinTextBox;

        public int modifyProductIDText { get { return int.Parse(modifyProductIDTextBox.Text); } set { modifyProductIDTextBox.Text = value.ToString(); } }
        public string modifyProductNameText { get { return modifyProductNameTextBox.Text; } set { modifyProductNameTextBox.Text = value; } }
        public int modifyProductInventoryText { get { return int.Parse(modifyProductInventoryTextBox.Text); } set { modifyProductInventoryTextBox.Text = value.ToString(); } }
        public decimal modifyProductPriceText { get { return decimal.Parse(modifyProductPriceTextBox.Text); } set { modifyProductPriceTextBox.Text = value.ToString(); } }
        public int modifyProductMaxText { get { return int.Parse(modifyProductMaxTextBox.Text); } set { modifyProductMaxTextBox.Text = value.ToString(); } }
        public int modifyProductMinText { get { return int.Parse(modifyProductMinTextBox.Text); } set { modifyProductMinTextBox.Text = value.ToString(); } }
        public int ModifyProductSearchText { get { return int.Parse(ModifyProductSearchTextBox.Text); } set { ModifyProductSearchTextBox.Text = value.ToString(); } }
    }
}