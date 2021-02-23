using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfo
{
    //NOTE: Structures are a value type
    public struct Product
    {
        private int productID;
        private string productName;
        private int quantity;
        private double unitPrice;
        private double totalPrice;

        public int ProductID { get => productID; private set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        //Using optional parameter
        public Product(int productID, string productName, int quantity = 5, double unitPrice = 5.0)
        {
            //Can not use property to initilize the fields?
            //ERROR: The 'this' object cannot be used before all of its fields have been assigned!
            this.productID = productID;
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;

            //Call the method to calculate the total price
            totalPrice = CalculateTotalPrice(unitPrice, quantity);
        }

        public static double CalculateTotalPrice(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }

        //The original ToString() method is unuseful.
        public override string ToString()
        {
            //Create a useful output string.
            return "Product ID:\t" + ProductID +
                   "\r\nQuantity:\t" + Quantity +
                   "\r\nUnit Price:\t" + "$" + UnitPrice +
                   "\r\nTotal Price:\t" + "$" + TotalPrice + "\n";
        }
    }

    public class ProductList
    {
        //Store product name in the string array
        private Product[] productList;

        public Product this[int i] { get => productList[i]; set => productList[i] = value; }
        public int Length { get => productList.Length; }

        public ProductList()
        {
            productList = null;
        }

        public void AddProduct(Product product)
        {
            //Empty product list
            if (productList == null)
            {
                productList = new Product[1];
                productList[0] = product;
            }
            //Non-Empty product list
            else
            {
                //Concat with new created string array that contains the new product name 
                productList = productList.Concat(new Product[] { product }).ToArray();
            }
        }

        public void PrintProductList()
        {
            foreach (Product product in productList)
            {
                Console.WriteLine("Product ID:\t" + product.ProductID +
                   "\r\nQuantity:\t" + product.Quantity +
                   "\r\nUnit Price:\t" + "$" + product.UnitPrice +
                   "\r\nTotal Price:\t" + "$" + product.TotalPrice + "\n");
            }
        }
    }
}