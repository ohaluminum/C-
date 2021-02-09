using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here’s the exception handler.
            try
            {
                // Call factorial in a loop from 6 down to -6.
                for (int i = 6; i > -2; i--)
                {
                    // Calculate the factorial of the number.
                    int factorial = MathFunctions.Factorial(i);

                    // Display the result of each pass.
                    Console.WriteLine("i = {0}, factorial = {1}", i, factorial);
                }
            }
            catch (ArgumentException e)
            {
                //This is a last-chance exception handler
                Console.WriteLine("Fatal error:");
                Console.WriteLine(e.ToString());

                //NOTE: Can implement a customized exception (But should throw the customized exception first then the general exception)
            }
            finally
            {
                // Wait for user to acknowledge.
                Console.WriteLine("Press Enter to terminate…");
                Console.Read();
            }
        }

        class MathFunctions
        {
            //Factorial(): Return the factorial of the provided value
            public static int Factorial(int value)
            {
                //Negative numbers are not allowed
                if (value < 0)
                {
                    //Report negative argument
                    string s = String.Format("Illegal negative argument to Factorial {0}", value);

                    throw new ArgumentException(s);
                }

                int factorial = 1;
                
                while (value > 1)
                {
                    factorial *= value;

                    //Update the value
                    value--;
                }

                //Return the accumulated value
                return factorial;
            }
        }
    }
}
