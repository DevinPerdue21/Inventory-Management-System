using DevinPerdueFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevinPerdueFinal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.AllParts.Add(new Inhouse(1, "Wheel", 10, 20.00m, 1, 25, 1234));
            Inventory.AllParts.Add(new Inhouse(2, "Exhaust", 20, 40.00m, 1, 25, 4321));
            Inventory.AllParts.Add(new Outsourced(3, "Motor", 15, 200.00m, 1, 25, "Toyota"));
            Inventory.AllParts.Add(new Outsourced(4, "Seats", 20, 75.00m, 1, 25, "Ford")); 

            Inventory.Products.Add(new Product(1, "Dirt Bike", 10, 250.00m, 1, 25));
            Inventory.Products.Add(new Product(2, "Go-Kart", 15, 150.00m, 1, 25));
            Inventory.Products.Add(new Product(3, "Four Wheeler", 25, 500.00m, 1, 25));
            Inventory.Products.Add(new Product(4, "Golf Cart", 15, 70.00m, 1, 25));



            Inventory.CurrentIndexUpper = -1;
            Inventory.CurrentIndexLower = -1;    

            


            Inventory.LookupProduct(1).addAssociatedPart(Inventory.LookupPart(2));
            Inventory.LookupProduct(1).addAssociatedPart(Inventory.LookupPart(3));

            Inventory.LookupProduct(2).addAssociatedPart(Inventory.LookupPart(2));
            Inventory.LookupProduct(2).addAssociatedPart(Inventory.LookupPart(1));


            Inventory.LookupProduct(3).addAssociatedPart(Inventory.LookupPart(3));
            Inventory.LookupProduct(3).addAssociatedPart(Inventory.LookupPart(4));

            Inventory.LookupProduct(4).addAssociatedPart(Inventory.LookupPart(1));
            Inventory.LookupProduct(4).addAssociatedPart(Inventory.LookupPart(4));

            




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Menu());
        }
    }
}
