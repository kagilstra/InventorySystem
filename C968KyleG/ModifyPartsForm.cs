using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C968KyleG
{
    public partial class ModifyPartsForm : Form
    {
        
        public ModifyPartsForm(Inhouse inHousePart)
        {
            InitializeComponent();
            ModifyPartIDText = inHousePart.PartID;
            ModifyPartNameText = inHousePart.Name;
            ModifyPartInventoryText = inHousePart.Inventory;
            ModifyPartPriceText = inHousePart.Price;
            ModifyPartMaxText = inHousePart.Max;
            ModifyPartMinText = inHousePart.Min;
            ModifyPartInOrOutText = inHousePart.MachineID.ToString();
            ModifyInhouseRadio.Checked = true;
        }
        public ModifyPartsForm(Outsourced outsourcedPart)
        {
            InitializeComponent();
            ModifyPartIDText = outsourcedPart.PartID;
            ModifyPartNameText = outsourcedPart.Name;
            ModifyPartInventoryText = outsourcedPart.Inventory;
            ModifyPartPriceText = outsourcedPart.Price;
            ModifyPartMaxText = outsourcedPart.Max;
            ModifyPartMinText = outsourcedPart.Min;
            ModifyPartInOrOutText = outsourcedPart.CompanyName;
            ModifyOutsourcedRadio.Checked = true;
        }


        //Saves modified Part or returns error if data is incorrect
        private void ModifyPartSaveBtn_Click(object sender, EventArgs e)
        {
            int i;
            decimal x;
            int partID = int.Parse(ModifyPartIDTextBox.Text);
            if (!Int32.TryParse(ModifyPartMinTextBox.Text, out i) || !Int32.TryParse(ModifyPartMaxTextBox.Text, out i) || !Int32.TryParse(ModifyPartInventoryTextBox.Text, out i) || !Decimal.TryParse(ModifyPartPriceTextBox.Text, out x))
            {
                MessageBox.Show("Min, Max, Inventory, Price must be Numerical", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ModifyPartMaxText < ModifyPartMinText)
            {
                MessageBox.Show("Max cannot be less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ModifyPartInventoryText > ModifyPartMaxText || ModifyPartInventoryText < ModifyPartMinText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ModifyInhouseRadio.Checked)
            {
                Inhouse inHouse = new Inhouse(partID, ModifyPartNameText, ModifyPartInventoryText, ModifyPartPriceText, ModifyPartMaxText, ModifyPartMinText, int.Parse(ModifyPartInOrOutText));
                Inventory.UpdatePart(partID, inHouse);
            }
            else
            {
                Outsourced outsourced = new Outsourced(partID, ModifyPartNameText, ModifyPartInventoryText, ModifyPartPriceText, ModifyPartMaxText, ModifyPartMinText, ModifyPartInOrOutText);
                Inventory.UpdatePart(partID, outsourced);
            }
            this.Close();
        }

        //cancel return to main form
        private void ModifyPartCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Changes CompanyName text to MachineID
        private void ModifyInhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            ModifyPartInOrOutlbl.Text = "Machine ID";
            ModifyPartInOrOutlbl.Location = new Point(53, 238);
            ModifyPartInOrOutTextBox.PlaceholderText = "Machine ID";
        }

        //Changes MachineID text to CompanyNAme
        private void ModifyOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            ModifyPartInOrOutlbl.Text = "Company Name";
            ModifyPartInOrOutlbl.Location = new Point(26, 238);
            ModifyPartInOrOutTextBox.PlaceholderText = "Company Name";
        }

        //Only allows save once all text boxes have data
        private void saveButtonConditionChecker()
        {
            if ((ModifyPartNameTextBox.Text != String.Empty) && (ModifyPartInventoryTextBox.Text != String.Empty) && (ModifyPartPriceTextBox.Text != String.Empty) && (ModifyPartMinTextBox.Text != String.Empty) && (ModifyPartMaxTextBox.Text != String.Empty) && (ModifyPartInOrOutTextBox.Text != String.Empty))
            {
                ModifyPartSaveBtn.Enabled = true;
            }
            else
            {
                ModifyPartSaveBtn.Enabled = false;
            }
        }
        private void ModifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void ModifyPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void ModifyPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void ModifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void ModifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void ModifyPartInOrOutTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }
    }
}
