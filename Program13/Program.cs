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
            public void printName()
            {
                Console.WriteLine("Color's name is {0}", this.name);
            }

            //setName(): Modify the color name (non-static)
            public void setName(string name)
            {
                this.name = name;
            }

            //setHue(): Modify the color hue (non-static)
            public void setHue(int hue)
            {
                this.hue = hue;
            }

            //setValue(): Modify the color value (non-static)
            public void setValue(int value)
            {
                this.value = value;
            }

            //setSaturation(): Modify the color saturation (non-static)
            public void setSaturation(int saturation)
            {
                this.saturation = saturation;
            }
        }

        static void Main(string[] args)
        {
            Color color = new Color();

            Console.WriteLine("Original: ");

            //Set color name directly
            color.name = "blue";

            color.printName();

            //Change the color name using a method
            Console.WriteLine("After modifying: ");

            color.setName("yellow");
            color.setHue(30);
            color.setValue(40);
            color.setSaturation(50);

            color.printName();

            //Wait for user to acknowledge
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }

        
    }
}
