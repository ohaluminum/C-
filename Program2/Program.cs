using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- DECLARE VARIABLE -----------
            
            //Declare a variable without initializing it 
            int n;

            //Assign the value to the variable
            n = 100;

            Console.WriteLine("Previous N: " + n);

            //Declare a variable and initialize it
            int m = 200;

            //Assign the value stored in m to the variable n.
            n = m;

            Console.WriteLine("Current N: " + n);

            //Can not use a variable until it been declared and been set to some value

            // x = 1;
            // int x;

            // int m;
            // int n = m; 


            // --------------- INTEGER -----------------

            //Integer truncation: cut off the fractional part of a number to get it to fit into an integer variable
            //Integer truncation is not rounding: 10.9 -> 10 (not 11), 0.5 -> 0 not 1

            int a = 109 / 10;
            int b = 1 / 2;

            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);


            // ----------- FLOATING-POINT --------------

            //Convert Celsius to Fahrenheit.
            int f = 40;
            double c = (f - 32.0) * (5.0 / 9.0);

            Console.WriteLine("Fahrenheit: " + f);
            Console.WriteLine("Celsius: " + c);

            //Floating-point variable can not be used as a counter


            // ---------------- BOOL --------------------

            //Bool variable can not be converted to any other types

            bool isTrue = true;

            Console.WriteLine("Is True: " + isTrue);


            // -------------- CHARACTER -----------------

            //Character variable surrounded by a pair of single quotation marks (')

            char letter = 'a';

            Console.WriteLine(letter);


            // ---------------- STRING ------------------

            //String vairable surrounded by a pair of double quotation marks (")

            string line1 = "This is a string, ";
            string line2 = "and this is another string.";

            //The + operator concatenates two strings into one
            string line3 = line1 + line2;

            Console.WriteLine(line3);

            //It's better to initialize strings using the String.Empty (a property of the string type)
            string emptyString = String.Empty;

            Console.WriteLine(emptyString);


            // --------------- VALUE TYPE ---------------

            //Intrinsic Variable Type:  int, double, bool...
            //             Value Type:  Intrinsic Variable Type + decimal
            //         Reference Type:  string, programmer-defined types


            // --------------- DATE TIME ----------------

            DateTime randomYear = new DateTime(2018, 12, 23);
            bool isLeapYear = DateTime.IsLeapYear(randomYear.Year);

            Console.WriteLine(randomYear.Year + " is leap year: " + isLeapYear);

            DateTime currentYear = DateTime.Now;
            isLeapYear = DateTime.IsLeapYear(currentYear.Year);

            Console.WriteLine(currentYear.Year + " is leap year: " + isLeapYear);

            DateTime currentMoment = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine("Current Date: "+ currentMoment.Date);
            Console.WriteLine("Current Year: " + currentMoment.Year);
            Console.WriteLine("Current Month: " + currentMoment.Month);
            Console.WriteLine("Current Day: " + currentMoment.Day);
            Console.WriteLine("Current Day of Week: " + currentMoment.DayOfWeek);
            Console.WriteLine("Current Day of Year: " + currentMoment.DayOfYear);
            Console.WriteLine("Current Hour: " + currentMoment.Hour);
            Console.WriteLine("Current Minute: " + currentMoment.Minute);
            Console.WriteLine("Current Second: " + currentMoment.Second);
        }
    }
}
