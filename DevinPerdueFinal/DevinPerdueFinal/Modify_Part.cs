using DevinPerdueFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DevinPerdueFinal
{
    public partial class Modify_Part : Form
    {
        bool isInhouse;
        private bool allowSave()
        {
            int number1;
            decimal number2;
            return (!string.IsNullOrWhiteSpace(txtPartName.Text)) && !Int32.TryParse(txtPartName.Text, out number1) && (!string.IsNullOrWhiteSpace(txtInventory.Text)) && Int32.TryParse(txtInventory.Text, out number1) && (!string.IsNullOrWhiteSpace(txtPrice.Text)) && Decimal.TryParse(txtPrice.Text, out number2) && (!string.IsNullOrWhiteSpace(txtMin.Text)) && Int32.TryParse(txtMin.Text, out number1) && (!string.IsNullOrWhiteSpace(txtMax.Text)) && Int32.TryParse(txtMax.Text, out number1) &&
                (!(string.IsNullOrWhiteSpace(txtSource.Text) || (isInhouse && !Int32.TryParse(txtSource.Text, out number1))));
        }
        
        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(txtSource.Text) || (isInhouse && !Int32.TryParse(txtSource.Text, out number)))
            {
                txtSource.BackColor = System.Drawing.Color.Salmon;
                if ((!Int32.TryParse(txtSource.Text, out number)) && !string.IsNullOrWhiteSpace(txtSource.Text))
                {
                    MessageBox.Show("Machine ID can only contain numbers");
                    txtSource.Clear();
                    return;

                }
            }
            else
            {
                txtSource.BackColor = System.Drawing.Color.White;
            }
            saveModifiedPart.Enabled = allowSave();
        }
        public Modify_Part()
        {
            InitializeComponent();
            txtPartID.Text = Inventory.CurrentPart.pID.ToString();
            txtPartName.Text = Inventory.CurrentPart.Name;
            txtInventory.Text = Inventory.CurrentPart.Stock.ToString();
            txtPrice.Text = Inventory.CurrentPart.Price.ToString();
            txtMin.Text = Inventory.CurrentPart.Min.ToString();
            txtMax.Text = Inventory.CurrentPart.Max.ToString();
            
            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse e = (Inhouse)Inventory.CurrentPart;
                txtSource.Text = e.MachineID.ToString();
                isInhouse = true;
                inhouse.Checked = true;
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPart;
                txtSource.Text = e.CompanyName;
                isInhouse = false;
                outsourced.Checked = true;
            }

            
        }

        private void partPrice_Click(object sender, EventArgs e)
        {

        }

        private void inhouse_CheckedChanged(object sender, EventArgs e)
        {
            Source.Text = "Machine ID";
            isInhouse = true;
            checkOnRBSwitch();
        }

        private void outsourced_CheckedChanged(object sender, EventArgs e)
        {
            Source.Text = "Company Name";
            isInhouse = false;
            checkOnRBSwitch();
        }

        private void Source_Click(object sender, EventArgs e)
        {

        }

        private void saveModifiedPart_Click(object sender, EventArgs e)
        {
            int partID;
            partID = Convert.ToInt32(txtPartID.Text);

            int partMin = int.Parse(txtMin.Text);
            int partMax = int.Parse(txtMax.Text);
            int partInventory = int.Parse(txtInventory.Text);
            decimal partPrice = decimal.Parse(txtPrice.Text);

            if (partMin > partMax)
            {
                MessageBox.Show("Minimum value cannot be greater than maximum ");
                return;
            }

            if (partMax < partMin)
            {
                MessageBox.Show("Maximum value cannot be less than minimum");
                return;
            }

            if (partInventory < partMin || partInventory > partMax)
            {
                MessageBox.Show("Inventory cannot be greater than maximum or less than minimum");
                return;
            }

            if (isInhouse)
             {
                Part prt = new Inhouse(Convert.ToInt32(txtPartID.Text), txtPartName.Text, Convert.ToInt32(txtInventory.Text), Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text), Convert.ToInt32(txtSource.Text));
                Inventory.UpdatePart(partID, prt);

             }
             else
             {
                Part prt = new Outsourced(Convert.ToInt32(txtPartID.Text), txtPartName.Text, Convert.ToInt32(txtInventory.Text), Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text), txtSource.Text);
                Inventory.UpdatePart(partID, prt);
            }

             this.Close();
             Main_Menu form1 = new Main_Menu();
             form1.Show(); 

        }

        private void txtPartID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(txtPartName.Text) || Int32.TryParse(txtPartName.Text, out number))
            {
                txtPartName.BackColor = System.Drawing.Color.Salmon;
                    
            }
            else
            {
                txtPartName.BackColor = System.Drawing.Color.White;
            }
            saveModifiedPart.Enabled = allowSave();
        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(txtInventory.Text, out number))
            {
                txtInventory.BackColor = System.Drawing.Color.Salmon;


                if ((!Int32.TryParse(txtInventory.Text, out number)) && !string.IsNullOrWhiteSpace(txtInventory.Text))
                {
                    MessageBox.Show("Inventory can only contain numbers");
                    txtInventory.Clear();
                    return;

                }
            }
            else
            {
                txtInventory.BackColor = System.Drawing.Color.White;
            }
            saveModifiedPart.Enabled = allowSave();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (!Decimal.TryParse(txtPrice.Text, out number))
            {
                txtPrice.BackColor = System.Drawing.Color.Salmon;

                if ((!Decimal.TryParse(txtPrice.Text, out number)) && !string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Price can only contain numbers");
                    txtPrice.Clear();
                    return;

                }
            }
            else
            {
                txtPrice.BackColor = System.Drawing.Color.White;
            }
            saveModifiedPart.Enabled = allowSave();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(txtMin.Text, out number))       
            {
                txtMin.BackColor = System.Drawing.Color.Salmon;
                

                if ((!Int32.TryParse(txtMin.Text, out number)) && !string.IsNullOrWhiteSpace(txtMin.Text))
                {
                    MessageBox.Show("Min can only contain numbers");
                    txtMin.Clear();
                    return;
                    
                }
            }
            else
            {
                txtMin.BackColor = System.Drawing.Color.White;
            }
            saveModifiedPart.Enabled = allowSave();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(txtMax.Text, out number))
            {
                txtMax.BackColor = System.Drawing.Color.Salmon;

                if ((!Int32.TryParse(txtMax.Text, out number)) && !string.IsNullOrWhiteSpace(txtMax.Text))
                {
                    MessageBox.Show("Max can only contain numbers");
                    txtMax.Clear();
                    return;

                }

            }
            else
            {
                txtMax.BackColor = System.Drawing.Color.White;
            }
            saveModifiedPart.Enabled = allowSave();
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }

        private void cancelModifiedPart_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu form1 = new Main_Menu();
            form1.Show();
        }
    }
}
