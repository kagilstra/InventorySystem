using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C968KyleG
{
    public partial class AddProductForm : Form
    {
        BindingList<Part> productParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();

            var candidateParts = new BindingSource();
            candidateParts.DataSource = Inventory.AllParts;
            addProductCandidatePartsDataGrid.DataSource = candidateParts;


            var associatedParts = new BindingSource();
            associatedParts.DataSource = productParts;
            addProductAssociatedPartsDataGrid.DataSource = associatedParts;


        }

        //cancel return to main form
        private void addProductCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //adds candidate part to associated parts
        private void addProductCandiatePartsbtn_Click(object sender, EventArgs e)
        {
            Part addCandidatePart = (Part)addProductCandidatePartsDataGrid.CurrentRow.DataBoundItem;
            productParts.Add(addCandidatePart);
        }

        //Removes associated part from product
        private void addProductDeleteAssociatedPartbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this Part?", "Remove Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (addProductAssociatedPartsDataGrid.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < addProductAssociatedPartsDataGrid.SelectedRows.Count; i++)
                    {
                        addProductAssociatedPartsDataGrid.Rows.RemoveAt(addProductAssociatedPartsDataGrid.SelectedRows[0].Index);
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

        private void addProductSavebtn_Click(object sender, EventArgs e)
        {
            int i;
            decimal x;
            if (!Int32.TryParse(addProductMinTextBox.Text, out i) || !Int32.TryParse(addProductMaxTextBox.Text, out i) || !Int32.TryParse(addProductInventoryTextBox.Text, out i) || !Decimal.TryParse(addProductPriceTextBox.Text, out x))
            {
                MessageBox.Show("Min, Max, Inventory, Price must be Numerical", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addProductMaxBox < addProductMinBox)
            {
                MessageBox.Show("Max cannot be less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addProductInventoryBox > addProductMaxBox || addProductInventoryBox < addProductMinBox)
            {
                MessageBox.Show("Inventory Must Be Between Max and Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product productNew = new Product((Inventory.Products.Count + 1), addProductNameBox, addProductInventoryBox, addProductPriceBox, addProductMaxBox, addProductMinBox);
            Inventory.AddProduct(productNew);

            foreach (Part part in productParts)
            { 
                productNew.AddAssociatedPart(part);
            }
            this.Close();
        }

        //Searchs for part with ID
        private void addProductSearchbtn_Click(object sender, EventArgs e)
        {
            if (addProductSearchBox < 0)
                return;

            Part match = Inventory.LookupPart(addProductSearchBox);
            //Clears selected part before selecting new part
            addProductCandidatePartsDataGrid.ClearSelection();

            foreach (DataGridViewRow row in addProductCandidatePartsDataGrid.Rows)
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

        
        //Only allows users to enter numerical digits and delete in search text box
        private void addProductSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char digit = e.KeyChar;

            if (!Char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
            }
        }

        //Only allows search when data is entered
        private void searchButtonConditionChecker()
        {
            if (addProductSearchTextBox.Text != String.Empty)
            {
                addProductSearchbtn.Enabled = true;
            }
            else
            {
                addProductSearchbtn.Enabled = false;
            }
        }

        private void addProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButtonConditionChecker();
        }

        //Clears intially selected data upon start
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            addProductAssociatedPartsDataGrid.ClearSelection();
            addProductCandidatePartsDataGrid.ClearSelection();
        }

        //Only allows save once all text boxes have data
        private void saveButtonConditionChecker()
        {
            if (addProductNameTextBox.Text != String.Empty && addProductInventoryTextBox.Text != String.Empty && addProductPriceTextBox.Text != String.Empty && addProductMaxTextBox.Text != String.Empty && addProductMinTextBox.Text != String.Empty)
            {
                addProductSavebtn.Enabled = true;
            }
            else
            {
                addProductSavebtn.Enabled = false;
            }
        }
        private void addProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }

        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButtonConditionChecker();
        }
    }
}
