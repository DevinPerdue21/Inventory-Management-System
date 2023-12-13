using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinPerdueFinal.Model
{
    abstract class Part
    {
        public static int partCount;
    
        public Part(string name, int inventory, decimal price, int min, int max)
        {
            pID = partCount++;
            Name = name;
            Stock = inventory;
            Price = price;
            Min = min;
            Max = max;
            


        }

        public Part(int partID, string name, int inventory, decimal price, int min, int max) 
        {
            pID = partID;
            Name = name; 
            Stock = inventory; 
            Price = price; 
            Min = min; 
            Max = max;
        } 

        public int pID { get ; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }



      




    }
}
