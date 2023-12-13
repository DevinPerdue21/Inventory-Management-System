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
    public partial class Add_Part : Form
    {
        bool isInhouse;

        private bool allowSave()
        {
            int number1;
            decimal number2;
            return (!string.IsNullOrWhiteSpace(partNameTxt.Text)) && !Int32.TryParse(partNameTxt.Text, out number1) && (!string.IsNullOrWhiteSpace(inventoryTxt.Text)) && Int32.TryParse(inventoryTxt.Text, out number1) && (!string.IsNullOrWhiteSpace(priceTxt.Text)) && Decimal.TryParse(priceTxt.Text, out number2) && (!string.IsNullOrWhiteSpace(minTxt.Text)) && Int32.TryParse(minTxt.Text, out number1) && (!string.IsNullOrWhiteSpace(maxTxt.Text)) && Int32.TryParse(maxTxt.Text, out number1) &&
                (!(string.IsNullOrWhiteSpace(sourceTxt.Text) || (isInhouse && !Int32.TryParse(sourceTxt.Text, out number1))));
        }

        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(sourceTxt.Text) || (isInhouse  && !Int32.TryParse(sourceTxt.Text, out number)))
            {
                sourceTxt.BackColor = System.Drawing.Color.Salmon;
                if ((!Int32.TryParse(sourceTxt.Text, out number)) && !string.IsNullOrWhiteSpace(sourceTxt.Text))
                {
                    MessageBox.Show("Machine ID can only contain numbers");
                    sourceTxt.Clear();
                    return;

                }
            }
            else
            {
                sourceTxt.BackColor = System.Drawing.Color.White;
            }
            save.Enabled = allowSave();
        }
        public Add_Part()
        {
            InitializeComponent();
            RequiredFields();

        }

        private void RequiredFields()
        {
            if (string.IsNullOrWhiteSpace(partNameTxt.Text))
            {
                partNameTxt.BackColor = Color.Salmon;
            }

            if (string.IsNullOrWhiteSpace(inventoryTxt.Text))
            {
                inventoryTxt.BackColor = Color.Salmon;
            }

            if (string.IsNullOrWhiteSpace(priceTxt.Text))
            {
                priceTxt.BackColor = Color.Salmon;
            }

            if (string.IsNullOrWhiteSpace(minTxt.Text))
            {
                minTxt.BackColor = Color.Salmon;
            }

            if (string.IsNullOrWhiteSpace(maxTxt.Text))
            {
                maxTxt.BackColor = Color.Salmon;
            }


        }
        private void max_Click(object sender, EventArgs e)
        {

        }

        private void inhouse_CheckedChanged(object sender, EventArgs e)
        {
            source.Text = "Machine ID";
            isInhouse = true;
            checkOnRBSwitch();
        }

        private void outsourced_CheckedChanged(object sender, EventArgs e)
        {
            source.Text = "Company Name";
            isInhouse = false;
            checkOnRBSwitch();
        }

      

        private void partNameTxt_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(partNameTxt.Text) || Int32.TryParse(partNameTxt.Text, out number))
            {
                partNameTxt.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                partNameTxt.BackColor = System.Drawing.Color.White;
            }
            save.Enabled = allowSave();
        }

        private void inventoryTxt_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(inventoryTxt.Text, out number))
            {
                inventoryTxt.BackColor = System.Drawing.Color.Salmon;

                if ((!Int32.TryParse(inventoryTxt.Text, out number)) && !string.IsNullOrWhiteSpace(inventoryTxt.Text))
                {
                    MessageBox.Show("Inventory can only contain numbers");
                    inventoryTxt.Clear();
                    return;

                }
            }
            else
            {
                inventoryTxt.BackColor = System.Drawing.Color.White;
            }
            save.Enabled = allowSave();
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            decimal number1;
            if (!Decimal.TryParse(priceTxt.Text, out number1))
            {
                priceTxt.BackColor = System.Drawing.Color.Salmon;

                if ((!Decimal.TryParse(priceTxt.Text, out number1)) && !string.IsNullOrWhiteSpace(priceTxt.Text))
                {
                    MessageBox.Show("Price can only contain numbers");
                    priceTxt.Clear();
                    return;

                }
            }
            else
            {
                priceTxt.BackColor = System.Drawing.Color.White;
            }
            save.Enabled = allowSave();
        }

        private void minTxt_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(minTxt.Text, out number))
            {
                minTxt.BackColor = System.Drawing.Color.Salmon;

                if ((!Int32.TryParse(minTxt.Text, out number)) && !string.IsNullOrWhiteSpace(minTxt.Text))
                {
                    MessageBox.Show("Min can only contain numbers");
                    minTxt.Clear();
                    return;

                }
            }
            else
            {
                minTxt.BackColor = System.Drawing.Color.White;
            }
            save.Enabled = allowSave();
        }

        private void maxTxt_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(maxTxt.Text, out number))
            {
                maxTxt.BackColor = System.Drawing.Color.Salmon;

                if ((!Int32.TryParse(maxTxt.Text, out number)) && !string.IsNullOrWhiteSpace(maxTxt.Text))
                {
                    MessageBox.Show("Max can only contain numbers");
                    maxTxt.Clear();
                    return;

                }
            }
            else
            {
                maxTxt.BackColor = System.Drawing.Color.White;
            }
            save.Enabled = allowSave();
        }

        private void sourceTxt_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int partID = Inventory.AllParts.Count + 1;
            int partMin = int.Parse(minTxt.Text);
            int partMax = int.Parse(maxTxt.Text);
            int partInventory = int.Parse(inventoryTxt.Text);
            decimal partPrice = decimal.Parse(priceTxt.Text);

            if (partMin >  partMax) 
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

          



            partIDTxt.Text = partID.ToString();
            if (isInhouse)
            {
                Part prt = new Inhouse(Convert.ToInt32(partIDTxt.Text), partNameTxt.Text, Convert.ToInt32(inventoryTxt.Text), Convert.ToDecimal(priceTxt.Text), Convert.ToInt32(minTxt.Text), Convert.ToInt32(maxTxt.Text), Convert.ToInt32(sourceTxt.Text));
                int index = partID;
                Inventory.AddPart(index, prt);
                

            }
            else
            {
                Part prt = new Outsourced(Convert.ToInt32(partIDTxt.Text), partNameTxt.Text, Convert.ToInt32(inventoryTxt.Text), Convert.ToDecimal(priceTxt.Text), Convert.ToInt32(minTxt.Text), Convert.ToInt32(maxTxt.Text), sourceTxt.Text);
                int index = partID;
                Inventory.AddPart(index, prt);
            }

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
    }
}
