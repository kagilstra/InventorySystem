using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace C968KyleG
{
    public partial class ModifyProductForm : Form
    {
        BindingList<Part> productParts = new BindingList<Part>();
        
        public ModifyProductForm(Product modifiedProduct)
        {
            InitializeComponent();

            modifyProductIDText = modifiedProduct.ProductID;
            modifyProductNameText = modifiedProduct.Name;
            modifyProductInventoryText = modifiedProduct.InStock;
            modifyProductPriceText = modifiedProduct.Price;
            modifyProductMinText = modifiedProduct.Min;
            modifyProductMaxText = modifiedProduct.Max;

            var candidateParts = new BindingSource();
            candidateParts.DataSource = Inventory.AllParts;
            ModifyProductCandidateParts.DataSource = candidateParts;


            var associatedParts = new BindingSource();
            associatedParts.DataSource = productParts;
            ModifyProductAssociatedParts.DataSource = associatedParts;

            
            foreach (Part part in modifiedProduct.AssociatedParts)
            {
                productParts.Add(part);
            }


        }

        //cancel return to main form
        private void modifyProductCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Removes associated part from product
        private void modifyProductDeleteAssociatedPartbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this Part?", "Remove Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ModifyProductAssociatedParts.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < ModifyProductAssociatedParts.SelectedRows.Count; i++)
                    {
                        ModifyProductAssociatedParts.Rows.RemoveAt(ModifyProductAssociatedParts.SelectedRows[0].Index);
                    }
                }
                else
                {
                    MessageBox.Show("No Part Selected", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Part Not Removed", "Remove Part", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Saves modified product or returns error if data is incorrect
        private void modifyProductSavebtn_Click(object sender, EventArgs e)
        {
            int i;
            decimal x;
            int productID = int.Parse(modifyProductIDTextBox.Text);
            if (!Int32.TryParse(modifyProductMinTextBox.Text, out i) || !Int32.TryParse(modifyProductMaxTextBox.Text, out i) || !Int32.TryParse(modifyProductInventoryTextBox.Text, out i) || !Decimal.TryParse(modifyProductPriceTextBox.Text, out x))
            {
                MessageBox.Show("Min, Max, Inventory, Price must be Numerical", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (modifyProductMaxText < modifyProductMinText)
            {
                MessageBox.Show("Max cannot be less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (modifyProductInventoryText > modifyProductMaxText || modifyProductInventoryText < modifyProductMinText)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product productNew = new Product(modifyProductIDText, modifyProductNameText, modifyProductInventoryText, modifyProductPriceText, modifyProductMaxText, modifyProductMinText);
            Inventory.UpdateProduct(productID, productNew);

            foreach (Part part in productParts)
            {
                productNew.AddAssociatedPart(part);
            }
            this.Close();
        }

        //adds candidate part to associated parts
        private void modifyProductCandiatePartsbtn_Click(object sender, EventArgs e)
        {
            Part addCandidatePart = (Part)ModifyProductCandidateParts.CurrentRow.DataBoundItem;
            productParts.Add(addCandidatePart);
        }

        //Searchs for part with ID
        private void modifyProductSearchbtn_Click(object sender, EventArgs e)
        {
            if (ModifyProductSearchText < 0)
                return;

            Part match = Inventory.LookupPart(ModifyProductSearchText);
            //Clears selected part before selecting new part
            ModifyProductCandidateParts.ClearSelection();

            foreach (DataGridViewRow row in ModifyProductCandidateParts.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        //Only allows search when data is entered
        private void searchButtonConditionChecker()
        {
            if (ModifyProductSearchTextBox.Text != String.Empty)
            {
                modifyProductSearchbtn.Enabled = true;
            }
            else
            {
                modifyProductSearchbtn.Enabled = false;
            }
        }

        private void modifyProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButtonConditionChecker();
        }

        //Only allows users to enter numerical digits and delete in search text box
        private void modifyProductSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char digit = e.KeyChar;

            if (!Char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
            }
        }

        //clears intial selected data on form load
        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            ModifyProductCandidateParts.ClearSelection();
            ModifyProductAssociatedParts.ClearSelection();
        }

        //Only allows save once all text boxes have data
        private void saveButtonConditionChecker()
        {
            if (modifyProductNameTextBox.Text != String.Empty && modifyProductInventoryTextBox.Text != String.Empty && modifyProductPriceTextBox.Text != String.Empty && modifyProductMaxTextBox.Text != String.Empty && modifyProductMinTextBox.Text != String.Empty)
            {
                modifyProductSavebtn.Enabled = true;
            }
            else
            {
                modifyProductSavebtn.Enabled = false;
            }
        }
        private void modifyProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void modifyProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void modifyProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

    }
}
    

