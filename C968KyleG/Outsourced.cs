using System;
using System.Collections.Generic;
using System.Text;

namespace C968KyleG
{
    public class Outsourced : Part
    {
        private string companyName;
        public string CompanyName { get; set; }

        public Outsourced() { }

        public Outsourced(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }
        public Outsourced(int partID, string name, int inventory, decimal price, int max, int min, string companyName)
        { 
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }
    }
}
