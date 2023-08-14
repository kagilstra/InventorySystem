namespace C968KyleG
{
    partial class ModifyPartsForm
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
            this.ModifyPartlbl = new System.Windows.Forms.Label();
            this.ModifyInhouseRadio = new System.Windows.Forms.RadioButton();
            this.ModifyOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.modifyPartIDLbl = new System.Windows.Forms.Label();
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.modifyPartInventorylbl = new System.Windows.Forms.Label();
            this.ModifyPartPricelbl = new System.Windows.Forms.Label();
            this.ModifyPartMaxlbl = new System.Windows.Forms.Label();
            this.ModifyPartMinlbl = new System.Windows.Forms.Label();
            this.ModifyPartInOrOutlbl = new System.Windows.Forms.Label();
            this.ModifyPartCancelbtn = new System.Windows.Forms.Button();
            this.ModifyPartSaveBtn = new System.Windows.Forms.Button();
            this.ModifyPartIDTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartNameTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartMinTextBox = new System.Windows.Forms.TextBox();
            this.ModifyPartInOrOutTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModifyPartlbl
            // 
            this.ModifyPartlbl.AutoSize = true;
            this.ModifyPartlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyPartlbl.Location = new System.Drawing.Point(12, 9);
            this.ModifyPartlbl.Name = "ModifyPartlbl";
            this.ModifyPartlbl.Size = new System.Drawing.Size(90, 21);
            this.ModifyPartlbl.TabIndex = 0;
            this.ModifyPartlbl.Text = "Modify Part";
            // 
            // ModifyInhouseRadio
            // 
            this.ModifyInhouseRadio.AutoSize = true;
            this.ModifyInhouseRadio.Location = new System.Drawing.Point(114, 48);
            this.ModifyInhouseRadio.Name = "ModifyInhouseRadio";
            this.ModifyInhouseRadio.Size = new System.Drawing.Size(74, 19);
            this.ModifyInhouseRadio.TabIndex = 1;
            this.ModifyInhouseRadio.TabStop = true;
            this.ModifyInhouseRadio.Text = "In-House";
            this.ModifyInhouseRadio.UseVisualStyleBackColor = true;
            this.ModifyInhouseRadio.CheckedChanged += new System.EventHandler(this.ModifyInhouseRadio_CheckedChanged);
            // 
            // ModifyOutsourcedRadio
            // 
            this.ModifyOutsourcedRadio.AutoSize = true;
            this.ModifyOutsourcedRadio.Location = new System.Drawing.Point(236, 48);
            this.ModifyOutsourcedRadio.Name = "ModifyOutsourcedRadio";
            this.ModifyOutsourcedRadio.Size = new System.Drawing.Size(87, 19);
            this.ModifyOutsourcedRadio.TabIndex = 2;
            this.ModifyOutsourcedRadio.TabStop = true;
            this.ModifyOutsourcedRadio.Text = "Outsourced";
            this.ModifyOutsourcedRadio.UseVisualStyleBackColor = true;
            this.ModifyOutsourcedRadio.CheckedChanged += new System.EventHandler(this.ModifyOutsourcedRadio_CheckedChanged);
            // 
            // modifyPartIDLbl
            // 
            this.modifyPartIDLbl.AutoSize = true;
            this.modifyPartIDLbl.Location = new System.Drawing.Point(102, 88);
            this.modifyPartIDLbl.Name = "modifyPartIDLbl";
            this.modifyPartIDLbl.Size = new System.Drawing.Size(18, 15);
            this.modifyPartIDLbl.TabIndex = 3;
            this.modifyPartIDLbl.Text = "ID";
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Location = new System.Drawing.Point(81, 118);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(39, 15);
            this.ModifyPartLabel.TabIndex = 4;
            this.ModifyPartLabel.Text = "Name";
            // 
            // modifyPartInventorylbl
            // 
            this.modifyPartInventorylbl.AutoSize = true;
            this.modifyPartInventorylbl.Location = new System.Drawing.Point(63, 148);
            this.modifyPartInventorylbl.Name = "modifyPartInventorylbl";
            this.modifyPartInventorylbl.Size = new System.Drawing.Size(57, 15);
            this.modifyPartInventorylbl.TabIndex = 5;
            this.modifyPartInventorylbl.Text = "Inventory";
            // 
            // ModifyPartPricelbl
            // 
            this.ModifyPartPricelbl.AutoSize = true;
            this.ModifyPartPricelbl.Location = new System.Drawing.Point(87, 178);
            this.ModifyPartPricelbl.Name = "ModifyPartPricelbl";
            this.ModifyPartPricelbl.Size = new System.Drawing.Size(33, 15);
            this.ModifyPartPricelbl.TabIndex = 6;
            this.ModifyPartPricelbl.Text = "Price";
            // 
            // ModifyPartMaxlbl
            // 
            this.ModifyPartMaxlbl.AutoSize = true;
            this.ModifyPartMaxlbl.Location = new System.Drawing.Point(90, 207);
            this.ModifyPartMaxlbl.Name = "ModifyPartMaxlbl";
            this.ModifyPartMaxlbl.Size = new System.Drawing.Size(30, 15);
            this.ModifyPartMaxlbl.TabIndex = 7;
            this.ModifyPartMaxlbl.Text = "Max";
            // 
            // ModifyPartMinlbl
            // 
            this.ModifyPartMinlbl.AutoSize = true;
            this.ModifyPartMinlbl.Location = new System.Drawing.Point(224, 208);
            this.ModifyPartMinlbl.Name = "ModifyPartMinlbl";
            this.ModifyPartMinlbl.Size = new System.Drawing.Size(28, 15);
            this.ModifyPartMinlbl.TabIndex = 8;
            this.ModifyPartMinlbl.Text = "Min";
            // 
            // ModifyPartInOrOutlbl
            // 
            this.ModifyPartInOrOutlbl.AutoSize = true;
            this.ModifyPartInOrOutlbl.Location = new System.Drawing.Point(53, 238);
            this.ModifyPartInOrOutlbl.Name = "ModifyPartInOrOutlbl";
            this.ModifyPartInOrOutlbl.Size = new System.Drawing.Size(67, 15);
            this.ModifyPartInOrOutlbl.TabIndex = 9;
            this.ModifyPartInOrOutlbl.Text = "Machine ID";
            // 
            // ModifyPartCancelbtn
            // 
            this.ModifyPartCancelbtn.Location = new System.Drawing.Point(288, 264);
            this.ModifyPartCancelbtn.Name = "ModifyPartCancelbtn";
            this.ModifyPartCancelbtn.Size = new System.Drawing.Size(75, 37);
            this.ModifyPartCancelbtn.TabIndex = 10;
            this.ModifyPartCancelbtn.Text = "Cancel";
            this.ModifyPartCancelbtn.UseVisualStyleBackColor = true;
            this.ModifyPartCancelbtn.Click += new System.EventHandler(this.ModifyPartCancelbtn_Click);
            // 
            // ModifyPartSaveBtn
            // 
            this.ModifyPartSaveBtn.Enabled = false;
            this.ModifyPartSaveBtn.Location = new System.Drawing.Point(207, 264);
            this.ModifyPartSaveBtn.Name = "ModifyPartSaveBtn";
            this.ModifyPartSaveBtn.Size = new System.Drawing.Size(75, 37);
            this.ModifyPartSaveBtn.TabIndex = 11;
            this.ModifyPartSaveBtn.Text = "Save";
            this.ModifyPartSaveBtn.UseVisualStyleBackColor = true;
            this.ModifyPartSaveBtn.Click += new System.EventHandler(this.ModifyPartSaveBtn_Click);
            // 
            // ModifyPartIDTextBox
            // 
            this.ModifyPartIDTextBox.Location = new System.Drawing.Point(138, 85);
            this.ModifyPartIDTextBox.Name = "ModifyPartIDTextBox";
            this.ModifyPartIDTextBox.PlaceholderText = "Auto-Incremented";
            this.ModifyPartIDTextBox.ReadOnly = true;
            this.ModifyPartIDTextBox.Size = new System.Drawing.Size(185, 23);
            this.ModifyPartIDTextBox.TabIndex = 12;
            // 
            // ModifyPartNameTextBox
            // 
            this.ModifyPartNameTextBox.Location = new System.Drawing.Point(138, 115);
            this.ModifyPartNameTextBox.Name = "ModifyPartNameTextBox";
            this.ModifyPartNameTextBox.PlaceholderText = "Part Name";
            this.ModifyPartNameTextBox.Size = new System.Drawing.Size(185, 23);
            this.ModifyPartNameTextBox.TabIndex = 13;
            this.ModifyPartNameTextBox.TextChanged += new System.EventHandler(this.ModifyPartNameTextBox_TextChanged);
            // 
            // ModifyPartInventoryTextBox
            // 
            this.ModifyPartInventoryTextBox.Location = new System.Drawing.Point(138, 145);
            this.ModifyPartInventoryTextBox.Name = "ModifyPartInventoryTextBox";
            this.ModifyPartInventoryTextBox.PlaceholderText = "Integer";
            this.ModifyPartInventoryTextBox.Size = new System.Drawing.Size(185, 23);
            this.ModifyPartInventoryTextBox.TabIndex = 14;
            this.ModifyPartInventoryTextBox.TextChanged += new System.EventHandler(this.ModifyPartInventoryTextBox_TextChanged);
            // 
            // ModifyPartPriceTextBox
            // 
            this.ModifyPartPriceTextBox.Location = new System.Drawing.Point(138, 175);
            this.ModifyPartPriceTextBox.Name = "ModifyPartPriceTextBox";
            this.ModifyPartPriceTextBox.PlaceholderText = "00.00";
            this.ModifyPartPriceTextBox.Size = new System.Drawing.Size(185, 23);
            this.ModifyPartPriceTextBox.TabIndex = 15;
            this.ModifyPartPriceTextBox.TextChanged += new System.EventHandler(this.ModifyPartPriceTextBox_TextChanged);
            // 
            // ModifyPartMaxTextBox
            // 
            this.ModifyPartMaxTextBox.Location = new System.Drawing.Point(138, 205);
            this.ModifyPartMaxTextBox.Name = "ModifyPartMaxTextBox";
            this.ModifyPartMaxTextBox.PlaceholderText = "Integer";
            this.ModifyPartMaxTextBox.Size = new System.Drawing.Size(65, 23);
            this.ModifyPartMaxTextBox.TabIndex = 16;
            this.ModifyPartMaxTextBox.TextChanged += new System.EventHandler(this.ModifyPartMaxTextBox_TextChanged);
            // 
            // ModifyPartMinTextBox
            // 
            this.ModifyPartMinTextBox.Location = new System.Drawing.Point(258, 205);
            this.ModifyPartMinTextBox.Name = "ModifyPartMinTextBox";
            this.ModifyPartMinTextBox.PlaceholderText = "Integer";
            this.ModifyPartMinTextBox.Size = new System.Drawing.Size(65, 23);
            this.ModifyPartMinTextBox.TabIndex = 17;
            this.ModifyPartMinTextBox.TextChanged += new System.EventHandler(this.ModifyPartMinTextBox_TextChanged);
            // 
            // ModifyPartInOrOutTextBox
            // 
            this.ModifyPartInOrOutTextBox.Location = new System.Drawing.Point(138, 235);
            this.ModifyPartInOrOutTextBox.Name = "ModifyPartInOrOutTextBox";
            this.ModifyPartInOrOutTextBox.PlaceholderText = "Machine ID";
            this.ModifyPartInOrOutTextBox.Size = new System.Drawing.Size(185, 23);
            this.ModifyPartInOrOutTextBox.TabIndex = 18;
            this.ModifyPartInOrOutTextBox.TextChanged += new System.EventHandler(this.ModifyPartInOrOutTextBox_TextChanged);
            // 
            // ModifyPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 342);
            this.Controls.Add(this.ModifyPartInOrOutTextBox);
            this.Controls.Add(this.ModifyPartMinTextBox);
            this.Controls.Add(this.ModifyPartMaxTextBox);
            this.Controls.Add(this.ModifyPartPriceTextBox);
            this.Controls.Add(this.ModifyPartInventoryTextBox);
            this.Controls.Add(this.ModifyPartNameTextBox);
            this.Controls.Add(this.ModifyPartIDTextBox);
            this.Controls.Add(this.ModifyPartSaveBtn);
            this.Controls.Add(this.ModifyPartCancelbtn);
            this.Controls.Add(this.ModifyPartInOrOutlbl);
            this.Controls.Add(this.ModifyPartMinlbl);
            this.Controls.Add(this.ModifyPartMaxlbl);
            this.Controls.Add(this.ModifyPartPricelbl);
            this.Controls.Add(this.modifyPartInventorylbl);
            this.Controls.Add(this.ModifyPartLabel);
            this.Controls.Add(this.modifyPartIDLbl);
            this.Controls.Add(this.ModifyOutsourcedRadio);
            this.Controls.Add(this.ModifyInhouseRadio);
            this.Controls.Add(this.ModifyPartlbl);
            this.Name = "ModifyPartsForm";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyPartlbl;
        private System.Windows.Forms.RadioButton ModifyInhouseRadio;
        private System.Windows.Forms.RadioButton ModifyOutsourcedRadio;
        private System.Windows.Forms.Label modifyPartIDLbl;
        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.Label modifyPartInventorylbl;
        private System.Windows.Forms.Label ModifyPartPricelbl;
        private System.Windows.Forms.Label ModifyPartMaxlbl;
        private System.Windows.Forms.Label ModifyPartMinlbl;
        private System.Windows.Forms.Label ModifyPartInOrOutlbl;
        private System.Windows.Forms.Button ModifyPartCancelbtn;
        private System.Windows.Forms.Button ModifyPartSaveBtn;
        private System.Windows.Forms.TextBox ModifyPartIDTextBox;
        private System.Windows.Forms.TextBox ModifyPartNameTextBox;
        private System.Windows.Forms.TextBox ModifyPartInventoryTextBox;
        private System.Windows.Forms.TextBox ModifyPartPriceTextBox;
        private System.Windows.Forms.TextBox ModifyPartMaxTextBox;
        private System.Windows.Forms.TextBox ModifyPartMinTextBox;
        private System.Windows.Forms.TextBox ModifyPartInOrOutTextBox;

        public int ModifyPartIDText { get { return int.Parse(ModifyPartIDTextBox.Text); } set { ModifyPartIDTextBox.Text = value.ToString(); } }
        public string ModifyPartNameText { get { return ModifyPartNameTextBox.Text; } set { ModifyPartNameTextBox.Text = value; } }
        public int ModifyPartInventoryText { get { return int.Parse(ModifyPartInventoryTextBox.Text); } set { ModifyPartInventoryTextBox.Text = value.ToString(); } }
        public decimal ModifyPartPriceText { get { return decimal.Parse(ModifyPartPriceTextBox.Text); } set { ModifyPartPriceTextBox.Text = value.ToString(); } }
        public int ModifyPartMaxText { get { return int.Parse(ModifyPartMaxTextBox.Text); } set { ModifyPartMaxTextBox.Text = value.ToString(); } }
        public int ModifyPartMinText { get { return int.Parse(ModifyPartMinTextBox.Text); } set { ModifyPartMinTextBox.Text = value.ToString(); } }
        public string ModifyPartInOrOutText { get { return ModifyPartInOrOutTextBox.Text; } set { ModifyPartInOrOutTextBox.Text = value; } }
    }
}