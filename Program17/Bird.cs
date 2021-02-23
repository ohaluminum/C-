using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    //Sort bird by name
    class Bird : IComparable<Bird>, IDisplayable
    {
        private string name;

        public static Bird[] birds;

        public Bird(string name)
        {
            Name = name;
        }

        public string Name { get => name; private set => name = value; }

        public static void AddBird(Bird bird)
        {
            //Empty bird list
            if (birds == null)
            {
                birds = new Bird[1];
                birds[0] = bird;
            }
            //Non-empty bird list
            else
            {
                //Concat with new created string array that contains the new bird name 
                birds = birds.Concat(new Bird[] { bird }).ToArray();
            }

        }

        //Implement the IComparable interface:
        //CompareTo(): Compare the birds by name (use the built-in String class compare method).
        public int CompareTo(Bird rightBird)
        {
            Bird leftBird = this;

            return String.Compare(leftBird.Name, rightBird.Name);
        }

        //Implement the IDisplayable interface:
        //Display(): Returns the name of the bird.
        public string Display() { return Name; }
    }
}
