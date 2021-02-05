using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15
{
    class Program
    {
        public class Person
        {
            public string firstName;
            public string lastName;

            public Person(string first, string last)
            {
                firstName = first;
                lastName = last;
            }

            //FirstName property
            public string FirstName { get { return firstName; } set { firstName = value; } }

            //LastName property
            public string LastName { get { return lastName; } set { lastName = value; } }

            public void Introduction()
            {
                Console.WriteLine("I'm {0} {1}.", firstName, lastName);
            }
        }

        public class Student : Person
        {
            public int studentID;
            
            

        }

        static void Main(string[] args)
        {
            //Object-oriented programming is based on four principles: 
            
            //1. Encapsulation: capability to control access 
            //2. Inheritance: inherit from other classes 
            //3. Polymorphism: respond appropriately 
            //4. Interfaces: refer from one object to another indirectly

            


        }
    }
}
