using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevinPerdueFinal.Model
{
       class Product
    {
        public  BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>(); 


        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }    
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        private static int IDcount = 1;
        public Product(int productID, string name, int inventory, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Min = min;
            Max = max;
        }

        public Product(string name, int inventory, decimal price, int min, int max) 
        {
            ProductID = IDcount++;
            Name = name; 
            Inventory = inventory; 
            Price = price;  
            Min = min;
            Max = max;
        }

        public Product() { }   


        






        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            Part part = lookupAssociatedPart(partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }
        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.pID == partID)
                {
                    return part;
                }
            }
            return null;
        }

    }
}