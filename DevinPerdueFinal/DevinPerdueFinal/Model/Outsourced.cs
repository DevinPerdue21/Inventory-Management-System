using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinPerdueFinal.Model
{
    internal class Outsourced: Part
    {
        public Outsourced(string name, int inventory, decimal price, int min, int max, string companyName) 
            :base(name, inventory, price, min, max)
        {
            CompanyName = companyName;  
        }
        public Outsourced(int pID, string name, int inventory, decimal price, int min, int max, string companyName)
            :base(pID, name, inventory, price, min, max)
        {
            CompanyName = companyName;
        } 
        public string CompanyName { get; set; }
    }
}
