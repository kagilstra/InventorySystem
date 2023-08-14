using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968KyleG
{
    public partial class mainScreenForm : Form
    {
        public mainScreenForm()
        {
            InitializeComponent();

            Inventory.IntialItems();

            var partsData = new BindingSource();
            partsData.DataSource = Inventory.AllParts;
            PartsDataGridView.DataSource = partsData;


            var productsData = new BindingSource();
            productsData.DataSource = Inventory.Products;
            ProductsDataGridView.DataSource = productsData;
        }
        
        //Close program
        private void mainScreenExitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hide main screen open add part form
        private void partAddBtn_Click(object sender, EventArgs e)
        {
            Hide();
            addPartForm addPartForm = new addPartForm(this);
            addPartForm.ShowDialog();
            Show();
        }

        //Clears intial selected data in datagrid
        private void mainScreenForm_Load(object sender, EventArgs e)
        {
            PartsDataGridView.ClearSelection();
            ProductsDataGridView.ClearSelection();
        }

        //hide mainscreen open modify part form
        private void partModifybtn_Click(object sender, EventArgs e)
        {
            Hide();
            if (PartsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(C968KyleG.Inhouse))
            {
                Inhouse inhousePart = (Inhouse)PartsDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartsForm(inhousePart).ShowDialog();
            }

            else
            { 
                Outsourced outsourcedPart = (Outsourced)PartsDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartsForm (outsourcedPart).ShowDialog();
            }
            Show();
        }

        //Delete Part
        private void partDeletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Part?", "Delete Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PartsDataGridView.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < PartsDataGridView.SelectedRows.Count; i++)
                    {
                        PartsDataGridView.Rows.RemoveAt(PartsDataGridView.SelectedRows[0].Index);
                    }
                }
                else
                {
                    MessageBox.Show("No Part Selected", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Part Not Deleted", "Delete Part", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //delete product
        private void productDeletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Product product = (Product)ProductsDataGridView.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0) 
                {
                    MessageBox.Show("Product can not be deleted because parts are assigned to it", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ProductsDataGridView.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < ProductsDataGridView.SelectedRows.Count; i++)
                    {
                        ProductsDataGridView.Rows.RemoveAt(ProductsDataGridView.SelectedRows[0].Index);
                    }
                }
                else
                {
                    MessageBox.Show("No Product Selected", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Product Not Deleted", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Search part using ID
        private void partSearchbtn_Click(object sender, EventArgs e)
        {
            if (partSearchBoxText < 0)
                return;

            Part match = Inventory.LookupPart(partSearchBoxText);
            PartsDataGridView.ClearSelection();

            foreach (DataGridViewRow row in PartsDataGridView.Rows) 
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

        //Search Product using ID
        private void productSearchbtn_Click(object sender, EventArgs e)
        {
            if (productSearchBoxText < 0)
                return;

            Product match = Inventory.LookupProduct(productSearchBoxText);
            ProductsDataGridView.ClearSelection();

            foreach (DataGridViewRow row in ProductsDataGridView.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product.ProductID == match.ProductID)
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

        //hide main screen open add product form
        private void productAddbtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            Show();
        }

        //hide main screen open modify product form
        private void productModifybtn_Click(object sender, EventArgs e)
        {
            Hide();
            Product modifiedproduct = (Product)ProductsDataGridView.CurrentRow.DataBoundItem;
            new ModifyProductForm(modifiedproduct).ShowDialog();
            Show();
        }

        //Only allow digits in search boxes
        private void partSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char digit = e.KeyChar;

            if (!Char.IsDigit(digit) && digit != 8)
            { 
                e.Handled = true;
            }
        }

        private void productSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char digit = e.KeyChar;

            if (!Char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
            }
        }

        //only only search button press when search textbox has data
        private void PartSearchButtonConditionChecker()
        {
            if (partSearchBox.Text != String.Empty)
            {
                partSearchbtn.Enabled = true;
            }
            else
            {
                partSearchbtn.Enabled = false;
            }
        }

        private void ProductSearchButtonConditionChecker()
        {
            if (productSearchBox.Text != String.Empty)
            {
                productSearchbtn.Enabled = true;
            }
            else
            {
                productSearchbtn.Enabled = false;
            }
        }

        private void partSearchBox_TextChanged(object sender, EventArgs e)
        {
            PartSearchButtonConditionChecker();
        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {
            ProductSearchButtonConditionChecker();
        }

        private void PartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
