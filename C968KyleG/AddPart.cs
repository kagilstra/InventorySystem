using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C968KyleG
{
    public partial class addPartForm : Form
    {
        mainScreenForm mainScreen;
        public addPartForm(mainScreenForm ms)
        {
            InitializeComponent();
            this.mainScreen = ms;
        }
        
        //cancel return to main form
        private void addPartCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Changes CompanyName text to MachineID
        private void addPartInRadio_CheckedChanged(object sender, EventArgs e)
        {
            addPartInOrOutlbl.Text = "Machine ID";
            addPartInOrOutlbl.Location = new Point(53, 238);
            addPartInOrOutBox.PlaceholderText = "Machine ID";
        }

        //Changes MachineID text to CompanyNAme
        private void addPartOutradio_CheckedChanged(object sender, EventArgs e)
        {
            addPartInOrOutlbl.Text = "Company Name";
            addPartInOrOutlbl.Location = new Point(26, 238);
            addPartInOrOutBox.PlaceholderText = "Company Name";
        }

        //Saves Part or returns error if data is incorrect
        private void addPartSavebtn_Click(object sender, EventArgs e)
        {
            int i;
            decimal x;
            if (!Int32.TryParse(addPartMinBox.Text, out i) || !Int32.TryParse(addPartMaxBox.Text, out i) || !Int32.TryParse(addPartInventoryBox.Text, out i) || !Decimal.TryParse(addPartPriceBox.Text, out x))
            {
                MessageBox.Show("Min, Max, Inventory, Price must be Numerical", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AddPartMaxBoxText < AddPartMinBoxText) 
            {
                MessageBox.Show("Max cannot be less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AddPartInventoryBoxText > AddPartMaxBoxText || AddPartInventoryBoxText < AddPartMinBoxText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addPartInRadio.Checked && Int32.TryParse(AddPartInOrOutBoxText, out i))
            {
                Inhouse inHouse = new Inhouse((Inventory.AllParts.Count + 1), AddPartNameBoxText, AddPartInventoryBoxText, AddPartPriceBoxText, AddPartMaxBoxText, AddPartMinBoxText, int.Parse(AddPartInOrOutBoxText));
                Inventory.AllParts.Add(inHouse);
            }
            else if (addPartInRadio.Checked && !Int32.TryParse(AddPartInOrOutBoxText, out i))
            {
                MessageBox.Show("Machine ID must be an Integer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (addPartOutradio.Checked)
            { 
                Outsourced outsourced = new Outsourced((Inventory.AllParts.Count + 1), AddPartNameBoxText, AddPartInventoryBoxText, AddPartPriceBoxText, AddPartMaxBoxText, AddPartMinBoxText, AddPartInOrOutBoxText);
                Inventory.AllParts.Add(outsourced);
            }

            this.Close(); 
        }

        //Only allows save once data has been entered
        private void saveButtonConditionChecker()
        {
            if ((addPartNameBox.Text != String.Empty) && (addPartInventoryBox.Text != String.Empty) && (addPartPriceBox.Text != String.Empty) && (addPartMinBox.Text != String.Empty) && (addPartMaxBox.Text != String.Empty) && (addPartInOrOutBox.Text != String.Empty))
            {
                addPartSavebtn.Enabled = true;
            }
            else
            {
                addPartSavebtn.Enabled = false;
            }
        }

        private void addPartNameBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addPartInventoryBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addPartPriceBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addPartMaxBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addPartMinBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addPartInOrOutBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }
    }
}
