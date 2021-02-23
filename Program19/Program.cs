using System;

using ProductInfo;
using MathFunction;

namespace Program19
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------- NAMESPACES ---------------------------

            //Security Level: Private -> Protected Internal -> Protected -> Internal -> Public 

            // ------------------------- STRUCTURE ----------------------------

            Console.WriteLine("Testing create two product:\n");

            //Fully qualify names: Prefix ProductInfo

            //Create the first product without quantity and unit price information
            ProductInfo.Product testProduct1 = new Product(001, "Apple");
            Console.WriteLine(testProduct1.ToString());

            //Create the second product with quantity and unit price information
            ProductInfo.Product testProduct2 = new Product(002, "Banana", 3, 1.0);
            Console.WriteLine(testProduct2.ToString());

            Console.WriteLine("Testing create a product list:\n");

            ProductInfo.ProductList testProductList1 = new ProductList();
            testProductList1.AddProduct(testProduct1);
            testProductList1.AddProduct(testProduct2);
            testProductList1.PrintProductList();

            // ---------------------- OPTIONAL PARAMETER -------------------------

            Console.WriteLine("Testing Add Function:\n");

            //Using MathFunction namespace

            Console.WriteLine("Addition:\t" + Calculator.Add(1, 2));
            Console.WriteLine("Addition:\t" + Calculator.Add(1));
            Console.WriteLine("Addition:\t" + Calculator.Add(1, 2, w: 3));
            Console.WriteLine("Addition:\t" + Calculator.Add(x: 1, y: 2, z: 3, w: 4));

            Console.WriteLine();

            Console.WriteLine("Testing Sub Function:\n");

            Console.WriteLine("Subtraction:\t" + Calculator.Sub(1, 2));
            Console.WriteLine("Subtraction:\t" + Calculator.Sub(1));

            Console.WriteLine();

            Console.WriteLine("Testing Mul Function:\n");

            Console.WriteLine("Multiplication:\t" + Calculator.Mul(1, 2));
            Console.WriteLine("Multiplication:\t" + Calculator.Mul(1));

            Console.WriteLine();

            Console.WriteLine("Testing Div Function:\n");

            Console.WriteLine("Divition:\t" + Calculator.Div(4, 2));
            Console.WriteLine("Divition:\t" + Calculator.Div(1));

            Console.WriteLine();

            Console.WriteLine("Testing Four Function:\n");

            //Argument must be passed with the 'out' keyword.
            Calculator.FourFunction(2, 1, out int add, out int sub, out int mul, out int div);

            Console.WriteLine("Addition:\t" + add);
            Console.WriteLine("Subtraction:\t" + sub);
            Console.WriteLine("Multiplication:\t" + mul);
            Console.WriteLine("Divition:\t" + div);

            Console.WriteLine();    
        }
    }
}
