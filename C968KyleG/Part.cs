using System;
using System.Collections.Generic;
using System.Text;

namespace C968KyleG
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private int inventory;
        private decimal price;
        private int max;
        private int min;
        

        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

    }
}
