using System;
using System.Collections.Generic;
using System.Text;

namespace C968KyleG
{
    public class Inhouse : Part
    {
        private int machineID;
        public int MachineID { get; set; }

        public Inhouse() { }

        public Inhouse(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }


        public Inhouse(int partID, string name, int inventory, decimal price, int max, int min, int machineID)
        { 
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
