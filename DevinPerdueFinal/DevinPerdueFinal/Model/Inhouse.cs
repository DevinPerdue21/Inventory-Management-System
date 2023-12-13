using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DevinPerdueFinal.Model
{
    internal class Inhouse: Part
    {
        public Inhouse(string name, int inventory, decimal price, int min, int max, int machineID) 
            : base(name, inventory, price, min, max)
        {
           MachineID = machineID;
        
        }

        public Inhouse(int pID, string name, int inventory, decimal price, int min, int max, int machineID)
            :base(pID, name, inventory, price, min, max)
        {
            MachineID = machineID;
        } 
        public int MachineID { get; set; }

    }
}
