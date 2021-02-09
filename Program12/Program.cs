using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1: Input the data user need to create the table

            decimal principal = 0M;
            decimal interest = 0M;
            decimal duration = 0M;

            InputInterestData(ref principal, ref interest, ref duration);

            //Part 2: Show user the input information

            Console.WriteLine();
            Console.WriteLine("Principal     = " + principal);
            Console.WriteLine("Interest      = " + interest + "%");
            Console.WriteLine("Duration      = " + duration + " years");
            Console.WriteLine();

            //Part 3: Output the interest table
            OutputInterestTable(principal, interest, duration);

            Console.WriteLine();

            //Bonus: Testing default argument
            OutputInterestTable();

            //Wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }

        //InputInterestData(): Retrieve principal, interest, and duration information
        public static void InputInterestData(ref decimal principal, ref decimal interest, ref decimal duration)
        {
            //Retrieve the principal
            principal = InputPositiveDecimal("principal");

            //Retrieve the interest rate
            interest = InputPositiveDecimal("interest");

            //Retrieve the duration
            duration = InputPositiveDecimal("duration");
        }

        //InputPositiveDecimal(): Return a positive decimal number
        public static decimal InputPositiveDecimal(string prompt)
        {
            //Keep enter until the input is valid
            while (true)
            {
                Console.Write("Enter " + prompt + ":");

                //Retrieve user input
                string input = Console.ReadLine();
                decimal value = Convert.ToDecimal(input);

                if (value >= 0)
                {
                    //Return the valid decimal value entered by the user
                    return value;
                }

                // Otherwise, generate an error on incorrect input.
                Console.WriteLine(prompt + " cannot be negative");
                Console.WriteLine("Try again");
                Console.WriteLine();
            }
        }

        //OutputInterestTable(): Show the interest table
        public static void OutputInterestTable(decimal principal = 1000M, decimal interest = 10M, decimal duration = 10M)
        {
            for (int year = 1; year <= duration; year++)
            {
                decimal interestPaid = principal * (interest / 100);
                
                principal = principal + interestPaid;

                //Round off the principal to the nearest cent
                principal = decimal.Round(principal, 2);

                //Output the result to the table
                Console.WriteLine(year + "-" + principal);
            }
        }
    }
}
