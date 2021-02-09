using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------- IF-ELSE ---------------------
            
            int max;
            int a = 5;
            int b = 3;

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            Console.WriteLine("Max: " + max);


            // ----------------- TERNARY OPERTOR ------------------

            max = a > b ? a : b;
            Console.WriteLine("Max: " + max);


            // --------------------- SWITCH ---------------------

            //If-Else ver.
            if (a == 1)
            {
                Console.WriteLine("a = 1");
            }
            else if (a == 2)
            {
                Console.WriteLine("a = 2");
            }
            else if (a == 3)
            {
                Console.WriteLine("a = 3");
            }
            else if (a == 4)
            {
                Console.WriteLine("a = 4");
            }
            else if (a == 5)
            {
                Console.WriteLine("a = 5");
            }
            else
            {
                Console.WriteLine("Other Value");
            }

            //Switch ver.
            switch (a)
            {
                case 1:
                    Console.WriteLine("a = 1");
                    break;

                case 2:
                    Console.WriteLine("a = 2");
                    break;

                case 3:
                    Console.WriteLine("a = 3");
                    break;

                case 4:
                    Console.WriteLine("a = 4");
                    break;

                case 5:
                    Console.WriteLine("a = 5");
                    break;

                default:
                    Console.WriteLine("Other Value");
                    break;
            }


            // ------------------ WHILE-LOOP -----------------------

            //While-Loop ver.
            Console.WriteLine();

            int index = 0;
            while (index < 10)
            {
                Console.WriteLine("Index: " + index);
                index++;
            }


            // ---------------- DO-WHILE-LOOP ---------------------

            //Do-While loop will execute at least once
            //Do-While-Loop ver.
            Console.WriteLine();

            index = 0;
            do
            {
                Console.WriteLine("Index: " + index);
                index++;

            }   while (index < 10);


            // ------------------- FOR-LOOP -----------------------

            //For-Loop ver.
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Index: " + index);
            }

            //Wait for user to acknowledge the result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
