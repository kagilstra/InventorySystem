
namespace C968KyleG
{
    partial class addPartForm
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
            this.addPartlbl = new System.Windows.Forms.Label();
            this.addPartInRadio = new System.Windows.Forms.RadioButton();
            this.addPartOutradio = new System.Windows.Forms.RadioButton();
            this.addPartIdlbl = new System.Windows.Forms.Label();
            this.addPartNamelbl = new System.Windows.Forms.Label();
            this.addPartInventorylbl = new System.Windows.Forms.Label();
            this.addPartPricelbl = new System.Windows.Forms.Label();
            this.addPartMaxlbl = new System.Windows.Forms.Label();
            this.addPartMinlbl = new System.Windows.Forms.Label();
            this.addPartInOrOutlbl = new System.Windows.Forms.Label();
            this.addPartIdBox = new System.Windows.Forms.TextBox();
            this.addPartNameBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryBox = new System.Windows.Forms.TextBox();
            this.addPartPriceBox = new System.Windows.Forms.TextBox();
            this.addPartMaxBox = new System.Windows.Forms.TextBox();
            this.addPartMinBox = new System.Windows.Forms.TextBox();
            this.addPartInOrOutBox = new System.Windows.Forms.TextBox();
            this.addPartSavebtn = new System.Windows.Forms.Button();
            this.addPartCancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartlbl
            // 
            this.addPartlbl.AutoSize = true;
            this.addPartlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPartlbl.Location = new System.Drawing.Point(12, 9);
            this.addPartlbl.Name = "addPartlbl";
            this.addPartlbl.Size = new System.Drawing.Size(69, 21);
            this.addPartlbl.TabIndex = 0;
            this.addPartlbl.Text = "Add Part";
            // 
            // addPartInRadio
            // 
            this.addPartInRadio.AutoSize = true;
            this.addPartInRadio.Location = new System.Drawing.Point(114, 48);
            this.addPartInRadio.Name = "addPartInRadio";
            this.addPartInRadio.Size = new System.Drawing.Size(74, 19);
            this.addPartInRadio.TabIndex = 1;
            this.addPartInRadio.TabStop = true;
            this.addPartInRadio.Text = "In-House";
            this.addPartInRadio.UseVisualStyleBackColor = true;
            this.addPartInRadio.CheckedChanged += new System.EventHandler(this.addPartInRadio_CheckedChanged);
            // 
            // addPartOutradio
            // 
            this.addPartOutradio.AutoSize = true;
            this.addPartOutradio.Location = new System.Drawing.Point(236, 48);
            this.addPartOutradio.Name = "addPartOutradio";
            this.addPartOutradio.Size = new System.Drawing.Size(87, 19);
            this.addPartOutradio.TabIndex = 2;
            this.addPartOutradio.TabStop = true;
            this.addPartOutradio.Text = "Outsourced";
            this.addPartOutradio.UseVisualStyleBackColor = true;
            this.addPartOutradio.CheckedChanged += new System.EventHandler(this.addPartOutradio_CheckedChanged);
            // 
            // addPartIdlbl
            // 
            this.addPartIdlbl.AutoSize = true;
            this.addPartIdlbl.Location = new System.Drawing.Point(102, 88);
            this.addPartIdlbl.Name = "addPartIdlbl";
            this.addPartIdlbl.Size = new System.Drawing.Size(18, 15);
            this.addPartIdlbl.TabIndex = 3;
            this.addPartIdlbl.Text = "ID";
            // 
            // addPartNamelbl
            // 
            this.addPartNamelbl.AutoSize = true;
            this.addPartNamelbl.Location = new System.Drawing.Point(81, 118);
            this.addPartNamelbl.Name = "addPartNamelbl";
            this.addPartNamelbl.Size = new System.Drawing.Size(39, 15);
            this.addPartNamelbl.TabIndex = 4;
            this.addPartNamelbl.Text = "Name";
            // 
            // addPartInventorylbl
            // 
            this.addPartInventorylbl.AutoSize = true;
            this.addPartInventorylbl.Location = new System.Drawing.Point(63, 148);
            this.addPartInventorylbl.Name = "addPartInventorylbl";
            this.addPartInventorylbl.Size = new System.Drawing.Size(57, 15);
            this.addPartInventorylbl.TabIndex = 5;
            this.addPartInventorylbl.Text = "Inventory";
            // 
            // addPartPricelbl
            // 
            this.addPartPricelbl.AutoSize = true;
            this.addPartPricelbl.Location = new System.Drawing.Point(87, 178);
            this.addPartPricelbl.Name = "addPartPricelbl";
            this.addPartPricelbl.Size = new System.Drawing.Size(33, 15);
            this.addPartPricelbl.TabIndex = 6;
            this.addPartPricelbl.Text = "Price";
            // 
            // addPartMaxlbl
            // 
            this.addPartMaxlbl.AutoSize = true;
            this.addPartMaxlbl.Location = new System.Drawing.Point(90, 207);
            this.addPartMaxlbl.Name = "addPartMaxlbl";
            this.addPartMaxlbl.Size = new System.Drawing.Size(30, 15);
            this.addPartMaxlbl.TabIndex = 7;
            this.addPartMaxlbl.Text = "Max";
            // 
            // addPartMinlbl
            // 
            this.addPartMinlbl.AutoSize = true;
            this.addPartMinlbl.Location = new System.Drawing.Point(224, 208);
            this.addPartMinlbl.Name = "addPartMinlbl";
            this.addPartMinlbl.Size = new System.Drawing.Size(28, 15);
            this.addPartMinlbl.TabIndex = 8;
            this.addPartMinlbl.Text = "Min";
            // 
            // addPartInOrOutlbl
            // 
            this.addPartInOrOutlbl.AutoSize = true;
            this.addPartInOrOutlbl.Location = new System.Drawing.Point(53, 238);
            this.addPartInOrOutlbl.Name = "addPartInOrOutlbl";
            this.addPartInOrOutlbl.Size = new System.Drawing.Size(67, 15);
            this.addPartInOrOutlbl.TabIndex = 9;
            this.addPartInOrOutlbl.Text = "Machine ID";
            // 
            // addPartIdBox
            // 
            this.addPartIdBox.Location = new System.Drawing.Point(138, 85);
            this.addPartIdBox.Name = "addPartIdBox";
            this.addPartIdBox.PlaceholderText = "Auto-Incremented";
            this.addPartIdBox.ReadOnly = true;
            this.addPartIdBox.Size = new System.Drawing.Size(185, 23);
            this.addPartIdBox.TabIndex = 10;
            // 
            // addPartNameBox
            // 
            this.addPartNameBox.Location = new System.Drawing.Point(138, 115);
            this.addPartNameBox.Name = "addPartNameBox";
            this.addPartNameBox.PlaceholderText = "Part Name";
            this.addPartNameBox.Size = new System.Drawing.Size(185, 23);
            this.addPartNameBox.TabIndex = 11;
            this.addPartNameBox.TextChanged += new System.EventHandler(this.addPartNameBox_TextChanged);
            // 
            // addPartInventoryBox
            // 
            this.addPartInventoryBox.Location = new System.Drawing.Point(139, 145);
            this.addPartInventoryBox.Name = "addPartInventoryBox";
            this.addPartInventoryBox.PlaceholderText = "Integer";
            this.addPartInventoryBox.Size = new System.Drawing.Size(184, 23);
            this.addPartInventoryBox.TabIndex = 12;
            this.addPartInventoryBox.TextChanged += new System.EventHandler(this.addPartInventoryBox_TextChanged);
            // 
            // addPartPriceBox
            // 
            this.addPartPriceBox.Location = new System.Drawing.Point(138, 175);
            this.addPartPriceBox.Name = "addPartPriceBox";
            this.addPartPriceBox.PlaceholderText = "00.00";
            this.addPartPriceBox.Size = new System.Drawing.Size(185, 23);
            this.addPartPriceBox.TabIndex = 13;
            this.addPartPriceBox.TextChanged += new System.EventHandler(this.addPartPriceBox_TextChanged);
            // 
            // addPartMaxBox
            // 
            this.addPartMaxBox.Location = new System.Drawing.Point(138, 205);
            this.addPartMaxBox.Name = "addPartMaxBox";
            this.addPartMaxBox.PlaceholderText = "Integer";
            this.addPartMaxBox.Size = new System.Drawing.Size(65, 23);
            this.addPartMaxBox.TabIndex = 14;
            this.addPartMaxBox.TextChanged += new System.EventHandler(this.addPartMaxBox_TextChanged);
            // 
            // addPartMinBox
            // 
            this.addPartMinBox.Location = new System.Drawing.Point(258, 205);
            this.addPartMinBox.Name = "addPartMinBox";
            this.addPartMinBox.PlaceholderText = "Integer";
            this.addPartMinBox.Size = new System.Drawing.Size(65, 23);
            this.addPartMinBox.TabIndex = 15;
            this.addPartMinBox.TextChanged += new System.EventHandler(this.addPartMinBox_TextChanged);
            // 
            // addPartInOrOutBox
            // 
            this.addPartInOrOutBox.Location = new System.Drawing.Point(138, 235);
            this.addPartInOrOutBox.Name = "addPartInOrOutBox";
            this.addPartInOrOutBox.PlaceholderText = "Machine ID";
            this.addPartInOrOutBox.Size = new System.Drawing.Size(185, 23);
            this.addPartInOrOutBox.TabIndex = 16;
            this.addPartInOrOutBox.TextChanged += new System.EventHandler(this.addPartInOrOutBox_TextChanged);
            // 
            // addPartSavebtn
            // 
            this.addPartSavebtn.Enabled = false;
            this.addPartSavebtn.Location = new System.Drawing.Point(207, 264);
            this.addPartSavebtn.Name = "addPartSavebtn";
            this.addPartSavebtn.Size = new System.Drawing.Size(75, 37);
            this.addPartSavebtn.TabIndex = 17;
            this.addPartSavebtn.Text = "Save";
            this.addPartSavebtn.UseVisualStyleBackColor = true;
            this.addPartSavebtn.Click += new System.EventHandler(this.addPartSavebtn_Click);
            // 
            // addPartCancelbtn
            // 
            this.addPartCancelbtn.Location = new System.Drawing.Point(288, 264);
            this.addPartCancelbtn.Name = "addPartCancelbtn";
            this.addPartCancelbtn.Size = new System.Drawing.Size(75, 37);
            this.addPartCancelbtn.TabIndex = 18;
            this.addPartCancelbtn.Text = "Cancel";
            this.addPartCancelbtn.UseVisualStyleBackColor = true;
            this.addPartCancelbtn.Click += new System.EventHandler(this.addPartCancelbtn_Click);
            // 
            // addPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 342);
            this.Controls.Add(this.addPartCancelbtn);
            this.Controls.Add(this.addPartSavebtn);
            this.Controls.Add(this.addPartInOrOutBox);
            this.Controls.Add(this.addPartMinBox);
            this.Controls.Add(this.addPartMaxBox);
            this.Controls.Add(this.addPartPriceBox);
            this.Controls.Add(this.addPartInventoryBox);
            this.Controls.Add(this.addPartNameBox);
            this.Controls.Add(this.addPartIdBox);
            this.Controls.Add(this.addPartInOrOutlbl);
            this.Controls.Add(this.addPartMinlbl);
            this.Controls.Add(this.addPartMaxlbl);
            this.Controls.Add(this.addPartPricelbl);
            this.Controls.Add(this.addPartInventorylbl);
            this.Controls.Add(this.addPartNamelbl);
            this.Controls.Add(this.addPartIdlbl);
            this.Controls.Add(this.addPartOutradio);
            this.Controls.Add(this.addPartInRadio);
            this.Controls.Add(this.addPartlbl);
            this.Name = "addPartForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartlbl;
        private System.Windows.Forms.Label addPartIdlbl;
        private System.Windows.Forms.Label addPartNamelbl;
        private System.Windows.Forms.Label addPartInventorylbl;
        private System.Windows.Forms.Label addPartPricelbl;
        private System.Windows.Forms.Label addPartMaxlbl;
        private System.Windows.Forms.Label addPartMinlbl;
        private System.Windows.Forms.Label addPartInOrOutlbl;
        private System.Windows.Forms.Button addPartSavebtn;
        private System.Windows.Forms.Button addPartCancelbtn;
        public System.Windows.Forms.RadioButton addPartInRadio;
        public System.Windows.Forms.RadioButton addPartOutradio;
        public System.Windows.Forms.TextBox addPartIdBox;
        public System.Windows.Forms.TextBox addPartNameBox;
        public System.Windows.Forms.TextBox addPartInventoryBox;
        public System.Windows.Forms.TextBox addPartPriceBox;
        public System.Windows.Forms.TextBox addPartMaxBox;
        public System.Windows.Forms.TextBox addPartMinBox;
        public System.Windows.Forms.TextBox addPartInOrOutBox;

        

        public int AddPartIdBoxText 
        {
            get { return int.Parse(addPartIdBox.Text); }
            set { addPartIdBox.Text = value.ToString(); }
        }

        public string AddPartNameBoxText
        {
            get { return addPartNameBox.Text; }
            set { addPartNameBox.Text = value; }
        }

        public int AddPartInventoryBoxText
        {
            get { return int.Parse(addPartInventoryBox.Text); }
            set { addPartInventoryBox.Text = value.ToString(); }
        }

        public decimal AddPartPriceBoxText
        {
            get { return decimal.Parse(addPartPriceBox.Text); }
            set { addPartPriceBox.Text = value.ToString(); }
        }

        public int AddPartMaxBoxText
        {
            get { return int.Parse(addPartMaxBox.Text); }
            set { addPartMaxBox.Text = value.ToString(); }
        }

        public int AddPartMinBoxText
        {
            get { return int.Parse(addPartMinBox.Text); }
            set { addPartMinBox.Text = value.ToString(); }
        }

        public string AddPartInOrOutBoxText
        {
            get { return addPartInOrOutBox.Text; }
            set { addPartInOrOutBox.Text = value; }
        }
    }
}