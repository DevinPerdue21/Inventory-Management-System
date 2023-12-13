using DevinPerdueFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DevinPerdueFinal
{
    public partial class Add_Products : Form
    {
        private List<Part> tempParts = new List<Part>();
        private BindingList<Part> tempAssociatedParts = new BindingList<Part>();
        
        private bool allowSave()
        {
            int number1;
            decimal number2;
            return (!string.IsNullOrWhiteSpace(prodName.Text)) && !Int32.TryParse(prodName.Text, out number1) && (!string.IsNullOrWhiteSpace(prodInventory.Text)) && Int32.TryParse(prodInventory.Text, out number1) && (!string.IsNullOrWhiteSpace(prodPrice.Text)) && Decimal.TryParse(prodPrice.Text, out number2) && (!string.IsNullOrWhiteSpace(prodMin.Text)) && Int32.TryParse(prodMin.Text, out number1) && (!string.IsNullOrWhiteSpace(prodMax.Text)) && Int32.TryParse(prodMax.Text, out number1);

        }

        public Add_Products()
        {
            InitializeComponent();
            RequiredFields();


            //Data Source For Both Tables
            dgvPart.DataSource = Inventory.AllParts;

            Inventory.CurrentIndexUpper = Inventory.CurrentProductIndex;
            dgvPart.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvAssociatedParts.DataSource = tempAssociatedParts;

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


        private void RequiredFields()
        {
            if (string.IsNullOrWhiteSpace(prodName.Text))
            {
                prodName.BackColor = Color.Salmon;
                saveProduct.Enabled = false;
            }

            if (string.IsNullOrWhiteSpace(prodInventory.Text))
            {
                prodInventory.BackColor = Color.Salmon;
            }

            if (string.IsNullOrWhiteSpace(prodPrice.Text))
            {
                prodPrice.BackColor = Color.Salmon;
            }

            if (string.IsNullOrWhiteSpace(prodMin.Text))
            {
                prodMin.BackColor = Color.Salmon;
            }

            if (string.IsNullOrWhiteSpace(prodMax.Text))
            {
                prodMax.BackColor = Color.Salmon;
            }

        

        }
        private void dgvPart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPart.ClearSelection();
        }

        private void dgvAssociatedParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAssociatedParts.ClearSelection();
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

        private void saveProduct_Click(object sender, EventArgs e)
        {
            int productID;
            productID = Inventory.Products.Count + 1 ;

            prodID.Text = productID.ToString();

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

            Inventory.AddProduct(products);

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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu form1 = new Main_Menu();
            form1.Show();
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAssociatedParts.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                DialogResult confirm = MessageBox.Show("Please confirm that you wish to remove this item", "Delete?", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    tempParts.Remove(selectedPart); 
                    dgvAssociatedParts.DataSource = null; 
                    dgvAssociatedParts.DataSource = tempParts; 
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
            if (dgvPart.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPart.SelectedRows[0]; 
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                if ((!tempParts.Contains(selectedPart)) || (tempParts.Contains(selectedPart))) 
                {
                    tempParts.Add(selectedPart);

                    dgvAssociatedParts.AutoGenerateColumns = false; 
                    dgvAssociatedParts.DataSource = null;
                    dgvAssociatedParts.DataSource = tempParts;

                    dgvPart.ClearSelection();
                }
               
                
               
            
            } 

        }

        private void dgvPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAssociatedParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
