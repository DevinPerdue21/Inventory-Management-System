using DevinPerdueFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevinPerdueFinal
{
    public partial class Main_Menu : Form
    {
        private static int idxSelectedPart;
        private static int idxSelectedProduct;
        public Main_Menu()
        {
            InitializeComponent();
            idxSelectedPart = -1;
            idxSelectedProduct = -1;
            Build();
            
            
            //Data Source For Both Tables
            dgvPart.DataSource = Inventory.AllParts;
            dgvProduct.DataSource = Inventory.Products.OrderBy(product => product.ProductID).ToList();
            //dgvProduct.DataSource = Inventory.Products;

          



            //See a Full Row Selection
            dgvPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make the grid read only
            dgvPart.ReadOnly = true;
            dgvProduct.ReadOnly = true;

            //disable Multi-Selection
            dgvPart.MultiSelect = false;
            dgvProduct.MultiSelect = false;

            //remove extra row
            dgvPart.AllowUserToAddRows = false;
            dgvProduct.AllowUserToAddRows = false;

        }
        private void Build()
        {  
        }

        

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Clear Selection
            dgvPart.ClearSelection();
        }

        private void myBindingComplete1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Clear Selection
            dgvProduct.ClearSelection();
        }
        
        //Add Part Button
        private void addPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Part f4 = new Add_Part();
            f4.Show();
        }

        //Modify Part Button
        private void modifyPart_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {
                this.Hide();
                Modify_Part f3 = new Modify_Part();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Please select something to modify.");
            }
        }

        //Delete Part Button
        private void deletePart_Click(object sender, EventArgs e)
        {
            if (dgvPart.CurrentRow == null || !dgvPart.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection");
                return;
            }
                if (dgvPart.CurrentRow != null || dgvPart.CurrentRow.Selected)
                {
                if (DialogResult.Yes == MessageBox.Show("Do you really want to delete the selected part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                    int Index = dgvPart.CurrentCell.RowIndex;
                    Inventory.AllParts.RemoveAt(Index);
                    }
                }
           
        }

        //Add Product Button
        private void addProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Products f2 = new Add_Products();
            f2.Show();
        }

        //Modify Product Button
        private void modifyProduct_Click(object sender, EventArgs e)
        {
            if (idxSelectedProduct >= 0)
            {
                this.Hide();
                Modify_Product f6 = new Modify_Product();
                f6.Show();
            }
            else
            {
                MessageBox.Show("Please select something to modify.");
            }
        }

        //Delete Product Button
        private void deleteProduct_Click(object sender, EventArgs e)
        {
         
            if (dgvProduct.CurrentRow == null || !dgvProduct.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection");
                return;
            }
            if (dgvProduct.CurrentRow != null || dgvProduct.CurrentRow.Selected)
            {
                Product product = (Product)dgvProduct.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product with associated parts. Please delete associated parts from the product before trying to delete");
                }
                else 
                {

                    DialogResult = MessageBox.Show("Do you really want to delete the selected produdct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    int Index = dgvProduct.CurrentCell.RowIndex;
                    Inventory.Products.RemoveAt(Index);
                    dgvProduct.Refresh();

                    dgvProduct.DataSource = Inventory.Products.OrderBy(p => p.ProductID).ToList();

                }
            } 


        }

        //Close Program Button
        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Part Search Bar
        private void searchPart_Click(object sender, EventArgs e)
        {
            dgvPart.ClearSelection();
            dgvPart.DefaultCellStyle.SelectionBackColor = Color.Blue;
            bool found = false;
            if(partSearch.Text != "")
            {
                for ( int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partSearch.Text.ToUpper()))
                    {
                        dgvPart.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing Found!");
            }
        }

        //Product Search Bar
        private void searchProduct_Click(object sender, EventArgs e)
        {
            dgvProduct.ClearSelection();
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.Blue;
            bool found = false;
            if (productSearch.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(productSearch.Text.ToUpper()))
                    {
                        dgvProduct.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing Found!");
            }
        }

        private void dgvPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idxSelectedPart = dgvPart.CurrentCell.RowIndex;
            Inventory.CurrentPartID = (int)dgvPart.Rows[idxSelectedPart].Cells[0].Value;
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);  
            dgvPart.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
        }

        private void dgvProduct_Click(object sender, EventArgs e)
        {
            idxSelectedProduct = dgvProduct.CurrentCell.RowIndex;
            Inventory.CurrentProductID = (int)dgvProduct.Rows[idxSelectedProduct].Cells[0].Value;   
            Inventory.CurrentProduct = Inventory.LookupProduct(Inventory.CurrentProductID);
            dgvProduct.DefaultCellStyle.SelectionBackColor=System.Drawing.Color.Blue;
        }

        private void productSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
