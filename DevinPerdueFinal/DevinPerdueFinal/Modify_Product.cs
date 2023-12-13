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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DevinPerdueFinal
{
    public partial class Modify_Product : Form
    {
        private static int idxSelectedProduct;
        private static int i;



        private bool allowSave()
        {
            int number1;
            decimal number2;
            return (!string.IsNullOrWhiteSpace(prodName.Text)) && !Int32.TryParse(prodName.Text, out number1) && (!string.IsNullOrWhiteSpace(prodInventory.Text)) && Int32.TryParse(prodInventory.Text, out number1) && (!string.IsNullOrWhiteSpace(prodPrice.Text)) && Decimal.TryParse(prodPrice.Text, out number2) && (!string.IsNullOrWhiteSpace(prodMin.Text)) && Int32.TryParse(prodMin.Text, out number1) && (!string.IsNullOrWhiteSpace(prodMax.Text)) && Int32.TryParse(prodMax.Text, out number1);

        }


        public Modify_Product()
        {
            InitializeComponent();


            prodID.Text = Inventory.CurrentProductID.ToString();
            prodName.Text = Inventory.CurrentProduct.Name;
            prodInventory.Text = Inventory.CurrentProduct.Inventory.ToString();
            prodPrice.Text = Inventory.CurrentProduct.Price.ToString();
            prodMin.Text = Inventory.CurrentProduct.Min.ToString();
            prodMax.Text = Inventory.CurrentProduct.Max.ToString();

           

            //Data Source For Both Tables
            dgvPart.DataSource = Inventory.AllParts;

            Inventory.CurrentIndexUpper = Inventory.CurrentProductIndex;
            dgvPart.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvAssociatedParts.DataSource = Inventory.Products[Inventory.CurrentIndexUpper].AssociatedParts; 
            

            //See a Full Row Selection
            dgvPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //make the grid read only
            dgvPart.ReadOnly = true;
            dgvAssociatedParts.ReadOnly = true;

            //disable Multi-Selection
            dgvPart.MultiSelect = false;
            dgvAssociatedParts.MultiSelect = false;

            //remove extra row
            dgvPart.AllowUserToAddRows = false;
            dgvAssociatedParts.AllowUserToAddRows = false;
        }

        private void dgvPart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPart.ClearSelection();

        }

        private void prodID_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodName_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(prodName.Text) || Int32.TryParse(prodName.Text, out number))
            {
                prodName.BackColor = System.Drawing.Color.Salmon;

            }
            else
            {
                prodName.BackColor = System.Drawing.Color.White;
            }
            saveProduct.Enabled = allowSave();
        }

        private void prodInventory_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(prodInventory.Text, out number))
            {
                prodInventory.BackColor = System.Drawing.Color.Salmon;


                if ((!Int32.TryParse(prodInventory.Text, out number)) && !string.IsNullOrWhiteSpace(prodInventory.Text))
                {
                    MessageBox.Show("Inventory can only contain numbers");
                    prodInventory.Clear();
                    return;

                }
            }
            else
            {
                prodInventory.BackColor = System.Drawing.Color.White;
            }
            saveProduct.Enabled = allowSave();
        }

        private void prodPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (!Decimal.TryParse(prodPrice.Text, out number))
            {
                prodPrice.BackColor = System.Drawing.Color.Salmon;

                if ((!Decimal.TryParse(prodPrice.Text, out number)) && !string.IsNullOrWhiteSpace(prodPrice.Text))
                {
                    MessageBox.Show("Price can only contain numbers");
                    prodPrice.Clear();
                    return;

                }
            }
            else
            {
                prodPrice.BackColor = System.Drawing.Color.White;
            }
            saveProduct.Enabled = allowSave();
        }

        private void prodMin_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(prodMin.Text, out number))
            {
                prodMin.BackColor = System.Drawing.Color.Salmon;


                if ((!Int32.TryParse(prodMin.Text, out number)) && !string.IsNullOrWhiteSpace(prodMin.Text))
                {
                    MessageBox.Show("Min can only contain numbers");
                    prodMin.Clear();
                    return;

                }
            }
            else
            {
                prodMin.BackColor = System.Drawing.Color.White;
            }
            saveProduct.Enabled = allowSave();
        }

        private void prodMax_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(prodMax.Text, out number))
            {
                prodMax.BackColor = System.Drawing.Color.Salmon;


                if ((!Int32.TryParse(prodMax.Text, out number)) && !string.IsNullOrWhiteSpace(prodMax.Text))
                {
                    MessageBox.Show("Max can only contain numbers");
                    prodMax.Clear();
                    return;

                }
            }
            else
            {
                prodMax.BackColor = System.Drawing.Color.White;
            }
            saveProduct.Enabled = allowSave();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu form1 = new Main_Menu();
            form1.Show();
        }

        private void dgvAssociatedParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAssociatedParts.ClearSelection();

        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null || !dgvAssociatedParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection");
                return;
            }
            if (dgvPart.CurrentRow != null || dgvPart.CurrentRow.Selected)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you really want to delete the selected part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int Index = dgvAssociatedParts.CurrentCell.RowIndex;
                    dgvAssociatedParts.Rows.RemoveAt(Index);
                    
                }
            }
        }

        private void searchPartsAssociated_Click(object sender, EventArgs e)
        {
            dgvAssociatedParts.ClearSelection();
            dgvAssociatedParts.DefaultCellStyle.SelectionBackColor = Color.Blue;
            bool found = false;
            if (partsAssociated.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partsAssociated.Text.ToUpper()))
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

        private void addPart_Click(object sender, EventArgs e)
        {
           


            int productID = Convert.ToInt32(prodID.Text);
            int partID = Convert.ToInt32(dgvPart.Rows[dgvPart.CurrentCell.RowIndex].Cells[0].Value);
            Product product = Inventory.LookupProduct(productID);
            Part part = Inventory.LookupPart(partID);
            Inventory.UpdateProduct(productID, product);
            product.addAssociatedPart(part);
            dgvAssociatedParts.DataSource = product.AssociatedParts; 

        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            int productID;
            productID = Convert.ToInt32(prodID.Text);

            int productMin = int.Parse(prodMin.Text);
            int productMax = int.Parse(prodMax.Text);
            int productInventory = int.Parse(prodInventory.Text);
            decimal productPrice = decimal.Parse(prodPrice.Text);


            if (productMin > productMax)
            {
                MessageBox.Show("Minimum value cannot be greater than maximum ");
                return;
            }

            if (productMax < productMin)
            {
                MessageBox.Show("Maximum value cannot be less than minimum");
                return;
            }

            if (productInventory < productMin || productInventory > productMax)
            {
                MessageBox.Show("Inventory cannot be greater than maximum or less than minimum");
                return;
            }

            Product products = new Product(Convert.ToInt32(prodID.Text), prodName.Text, Convert.ToInt32(prodInventory.Text), Convert.ToDecimal(prodPrice.Text), Convert.ToInt32(prodMin.Text), Convert.ToInt32(prodMax.Text));

            foreach (DataGridViewRow row in dgvAssociatedParts.Rows)
            {
                Part associatedPart = (Part)row.DataBoundItem;
                products.AssociatedParts.Add(associatedPart);
            }
            Inventory.UpdateProduct(productID, products);












            this.Close();
            Main_Menu form1 = new Main_Menu();
            form1.Show();

        }

        private void dgvPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }


        private void dgvPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgvAssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idxSelectedProduct = dgvAssociatedParts.CurrentCell.RowIndex;
            Inventory.CurrentProductID = (int)dgvAssociatedParts.Rows[idxSelectedProduct].Cells[0].Value;
            Inventory.CurrentProduct = Inventory.LookupProduct(Inventory.CurrentProductID);
            dgvAssociatedParts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
        }

        private void dgvAssociatedParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
