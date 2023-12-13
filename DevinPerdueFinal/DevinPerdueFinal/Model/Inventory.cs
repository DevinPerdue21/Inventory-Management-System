using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevinPerdueFinal.Model
{
    static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static int CurrentIndexUpper;
        public static int CurrentIndexLower;




        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }

        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }


        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
     

        public static bool RemoveProduct(int productID)
        {
            Product product = LookupProduct(productID);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public static Product LookupProduct(int i)
        {
            for (int j = 0; j < Products.Count; j++)
            {
                if (Products[j].ProductID.Equals(i))
                {
                    CurrentProductIndex = j;
                    return Products[j];
                }
            }
            CurrentProductIndex = -1;
            return null;
        }

        public static void UpdateProduct(int productID, Product product)
        {
            foreach (Product products in Products)
            {
                Product modifiedProduct = (Product)products;

                if (modifiedProduct.ProductID == productID)
                {
                    Inventory.Products.Remove(modifiedProduct);
                    Inventory.AddProduct(product);
                    break;
                }
            }
        }


        public static void AddPart(int index, Part part)
        {
            AllParts.Insert(index - 1, part);
        }

        public static bool DeletePart(Part part)
        {
            if (AllParts.Contains(part))
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public static Part LookupPart(int i)
        {
            for (int j = 0; j < AllParts.Count; j++)
            {
                if (AllParts[j].pID.Equals(i))
                {
                    CurrentPartIndex = j;
                    return AllParts[j];
                }
            }
            CurrentPartIndex = -1;
            return null;
        }


        public static void UpdatePart(int partID, Part prt)
        {
            foreach (Part part in AllParts)
            {
                Part modifiedPart = (Part)part;

                if (modifiedPart.pID == partID)
                {
                    Inventory.AllParts.Remove(modifiedPart);
                    Inventory.AddPart(partID, prt);
                    break;
                }
            }
        }

    }   
}
