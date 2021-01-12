using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- CREATE ENUMERATION ------------------

            //Display all the names
            foreach (String color in Enum.GetNames(typeof(Color1)))
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();
                
            //Display all the values
            foreach (int color in Enum.GetValues(typeof(Color1)))
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            //Display all the names and values
            foreach (Color1 color in Enum.GetValues(typeof(Color1)))
            {
                Console.WriteLine("{0} = {1}", color, (int)color);
            }

            Console.WriteLine();

            // ---------------- CREATE ENUMERATION WITH INITIALIZATION ------------------

            //Display all the names
            foreach (String color in Enum.GetNames(typeof(Color2)))
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            //Display all the values
            foreach (int color in Enum.GetValues(typeof(Color2)))
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            //Display all the names and values
            foreach (Color2 color in Enum.GetValues(typeof(Color2)))
            {
                Console.WriteLine("{0} = {1}", color, (int)color);
            }

            // ---------------- ENUMERATION WITH SWITCH ------------------

            // Create a readable switch statement.
            Color1 myColorSelection = Color1.Yellow;

            //This switch make more sense now
            switch (myColorSelection)
            {
                case Color1.Red:

                    Console.WriteLine("You chose red.");
                    break;

                case Color1.Orange:
                    
                    Console.WriteLine("You chose orange.");
                    break;

                case Color1.Yellow:
                    
                    Console.WriteLine("You chose yellow.");
                    break;

                case Color1.Green:
                    
                    Console.WriteLine("You chose green.");
                    break;

                case Color1.Blue:
                    
                    Console.WriteLine("You chose blue.");
                    break;

                case Color1.Purple:
                    
                    Console.WriteLine("You chose purple.");
                    break;
            }
        }

        enum Color1
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Purple
        };

        enum Color2
        {
            Red = 1,
            Orange = 2,
            Yellow = Red + 10,
            Green = Orange + Yellow,
            Blue = 0x20,
            Purple = Red | Blue
        }
    }
}
