using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------- ARITHMETIC ---------------

            int n1 = 5;
            int n2 = 2;

            int n3 = n1 + n2;
            int n4 = n1 - n2;
            int n5 = n1 * n2;
            int n6 = n1 / n2;
            int n7 = n1 % n2;
            int n8 = -n1;

            Console.WriteLine("First Int: {0}", n1);
            Console.WriteLine("Second Int: {0}", n2);
            Console.WriteLine("Addition: {0}", n3);         // 5 + 2 = 7
            Console.WriteLine("Subtraction: {0}", n4);      // 5 - 2 = 3
            Console.WriteLine("Multiplication: {0}", n5);   // 5 * 2 = 10
            Console.WriteLine("Division: {0}", n6);         // 5 / 2 = 2
            Console.WriteLine("Remainder: {0}", n7);        // 5 % 2 = 1
            Console.WriteLine("Degative Number: {0}", n8);  // (-)5 = -5

            //Note: most of these operators are binary operators (operate on two values)


            // --------------- ASSIGNMENT ---------------

            //The assignment operator stores the int on the right into the int on the left and returns the value 15

            int n9 = 5 * 3;
            int n10 = n9;
            int n11;
            int n12;

            //The assignment are evaluated in series from right to left:
            //The assignment on the right stores 10 into n12 and returns 10
            //The assignment on the left stores 10 into n11 and returns 10

            //Avoid chaining assignments because it is less clear to human readers!
            n11 = n12 = 10;

            Console.WriteLine("N9: {0}", n9); 
            Console.WriteLine("N10: {0}", n10);
            Console.WriteLine("N11: {0}", n11);
            Console.WriteLine("N12: {0}", n12);


            // ---------------- INCREMENT -----------------

            int n13 = 1;
            Console.WriteLine("N13 (Original Value): {0}", n13);

            //Increment -> Assignment
            int n14 = ++n13;
            Console.WriteLine("N14 (Prefix Increment): {0}", n14);

            n13 = 1;

            //Assignemnt -> Increment
            int n15 = n13++;
            Console.WriteLine("N15 (Postfix Increment): {0}", n15);


            // ---------------- LOGICAL -----------------

            bool b;
            b = 3 > 2;                  //True
            Console.WriteLine(b);

            b = 3.0 > 2.0;              //True
            Console.WriteLine(b);

            b = 2.9000000001 > 2.9;     //True
            Console.WriteLine(b);

            b = 'a' > 'b';              //False -- lower a is before lower b
            Console.WriteLine(b);

            b = 'A' < 'a';              //True  -- upper a is before lower a
            Console.WriteLine(b);

            b = 'A' < 'b';              //True  -- all uppers are before all lowers
            Console.WriteLine(b);

            b = 10M > 12M;              //False
            Console.WriteLine(b);

            //Wait for user to acknowledge the result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();

        }
    }
}
