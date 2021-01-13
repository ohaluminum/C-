using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    class Program
    {
        public class Color
        {
            public string name;

            public int hue;
            public int value;
            public int saturation;

            //NOTE: The method is now members of class Color and not class Program

            //printName(): Output the color name (non-static)
            public void printName(Color color)
            {
                Console.WriteLine("Color's name is {0}", color.name);
            }

            //setName(): Modify the color name (non-static)
            public void setName(Color color, string name)
            {
                color.name = name;
            }
            
            public void setHue(int hue)
            {
                this.hue = hue;
            }
        }

        static void Main(string[] args)
        {
            Color color = new Color();

            Console.WriteLine("Original: ");

            //Set color name directly
            color.name = "blue";

            //Pass this Color object to the method
            color.printName(color);

            //Change the color name using a method
            Console.WriteLine("After modifying: ");

            //Pass this Color object to the method
            color.setName(color, "yellow");

            //Pass this Color object to the method
            color.printName(color);

            //Wait for user to acknowledge
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }

        
    }
}
