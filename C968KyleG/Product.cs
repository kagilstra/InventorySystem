using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace C968KyleG
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int prodID, string name, int inStock, decimal price, int max, int min)
        {
            ProductID = prodID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID) { return part; }

            }
            Part emptyPart = new Inhouse();
            return emptyPart;
        }
    }

}

