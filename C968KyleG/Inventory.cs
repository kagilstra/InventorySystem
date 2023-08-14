using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace C968KyleG
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();


        //Adds Product
        public static void AddProduct(Product product) 
        {
            Products.Add(product);
        }
        
        public static bool RemoveProduct(int productID) 
        {
            Product deleteThisProduct = LookupProduct(productID);
            if (deleteThisProduct == null)
            {
                return false;
            }
            else
            {
                Products.Remove(deleteThisProduct);
                return true;
            }
        } 

        //Searchs for Product using ProductID returns ERROR if productID not found
        public static Product LookupProduct(int productID) {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID) 
                { 
                    return product; 
                }

            }
            Product emptyProduct = new Product();
            MessageBox.Show("ProductID not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return emptyProduct;

        }

        public static void UpdateProduct(int productID, Product updatedProduct) 
        {
            RemoveProduct(productID);
            AddProduct(updatedProduct);
        } 
       
        //Adds part
        public static void AddPart(Part part) 
        { 
            AllParts.Add(part);
        }
        
        //Deletes Part/Parts from Grid
        public static bool DeletePart(int part) {
            Part deleteThisPart = LookupPart(part);
            if (deleteThisPart == null)
            {
                return false;
            }
            else 
            { 
                AllParts.Remove(deleteThisPart);
                return true;
            }
        }

        //Uses PartID to search for specific parts returns Error if PartID not found
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID) 
                { 
                    return part; 
                }   
            }
            Part emptyPart = new Inhouse();
            MessageBox.Show("PartID not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return emptyPart;
        }

        //update part for inhouse parts
        public static void UpdatePart(int partID, Inhouse updatedPart) 
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(C968KyleG.Inhouse))
                {
                    Inhouse replacePart = (Inhouse)AllParts[i];

                    if (replacePart.PartID == partID)
                    {
                        replacePart.Name = updatedPart.Name;
                        replacePart.Inventory = updatedPart.Inventory;
                        replacePart.Price = updatedPart.Price;
                        replacePart.Min = updatedPart.Min;
                        replacePart.Max = updatedPart.Max;
                        replacePart.MachineID = updatedPart.MachineID;
                    }
                }
                DeletePart(partID);
                AddPart(updatedPart);
            }
        }
        //Update part overload for Outsourced parts
        public static void UpdatePart(int partID, Outsourced updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(C968KyleG.Outsourced))
                {
                    Outsourced replacePart = (Outsourced)AllParts[i];


                    if (replacePart.PartID == partID)
                    {
                        replacePart.Name = updatedPart.Name;
                        replacePart.Inventory = updatedPart.Inventory;
                        replacePart.Price = updatedPart.Price;
                        replacePart.Min = updatedPart.Min;
                        replacePart.Max = updatedPart.Max;
                        replacePart.CompanyName = updatedPart.CompanyName;
                    }
                }
                DeletePart(partID);
                AddPart(updatedPart);
            }
        }
        
        //Intial items included in DataGrids
        public static void IntialItems()
        {
            //Intial items in Parts DataGridView
            Part inHousePart1 = new Inhouse(0, "Wheel", 15, 12.11m, 25, 5, 109);
            Part outSourcedPart1 = new Outsourced(1, "Pedal", 11, 8.22m, 25, 5, "Bike Company");
            Part inHousePart2 = new Inhouse(2, "Chain", 12, 8.33m, 25, 5, 109);
            Part outSourcedPart2 = new Outsourced(3, "Seat", 8, 4.55m, 15, 2, "Bike Company");
            AllParts.Add(inHousePart1);
            AllParts.Add(outSourcedPart1);
            AllParts.Add(inHousePart2);
            AllParts.Add(outSourcedPart2);

            //Intial Items in Products DataGridView
            Product intialProduct1 = new Product(0, "Red Bicycle", 15, 11.44m, 25, 1);
            Product intialProduct2 = new Product(1, "Yellow Bicycle", 19, 9.66m, 20, 1);
            Product intialProduct3 = new Product(2, "Blued Bicycle", 5, 12.77m, 25, 1);
            Products.Add(intialProduct1);
            Products.Add(intialProduct2);
            Products.Add(intialProduct3);
            
            //Parts associated with intialProduct1
            intialProduct1.AssociatedParts.Add(inHousePart2);
            intialProduct1.AssociatedParts.Add(inHousePart1);
            intialProduct1.AssociatedParts.Add(outSourcedPart1);
            
            //Parts associated with intialProduct2
            intialProduct2.AssociatedParts.Add(inHousePart2);
            intialProduct2.AssociatedParts.Add(outSourcedPart2);
           
            //Parts associated with intialProduct3
            intialProduct3.AssociatedParts.Add(inHousePart2);
            intialProduct3.AssociatedParts.Add(inHousePart1);
            intialProduct3.AssociatedParts.Add(outSourcedPart1);
        }
    }
}
