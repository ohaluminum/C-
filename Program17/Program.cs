using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing IDisplayable and IComparable interface:\n");

            Student student1 = new Student("Homer", 0);
            Student student2 = new Student("Marge", 85);
            Student student3 = new Student("Bart", 50);
            Student student4 = new Student("Lisa", 100);
            Student student5 = new Student("Maggie", 30);

            Student.AddStudent(student1);
            Student.AddStudent(student2);
            Student.AddStudent(student3);
            Student.AddStudent(student4);
            Student.AddStudent(student5);

            //Use the IComparable interface to sort the array. 
            Array.Sort(Student.students);
            DisplayArray(Student.students);

            Console.WriteLine();

            Console.WriteLine("Testing IDisplayable and IComparable interface:\n");

            Bird bird1 = new Bird("Oriole");
            Bird bird2 = new Bird("Hawk");
            Bird bird3 = new Bird("Robin");
            Bird bird4 = new Bird("Cardinal");
            Bird bird5 = new Bird("Bluejay");
            Bird bird6 = new Bird("Finch");
            Bird bird7 = new Bird("Sparrow");

            Bird.AddBird(bird1);
            Bird.AddBird(bird2);
            Bird.AddBird(bird3);
            Bird.AddBird(bird4);
            Bird.AddBird(bird5);
            Bird.AddBird(bird6);
            Bird.AddBird(bird7);

            //Use the IComparable interface to sort the array.
            Array.Sort(Bird.birds);
            DisplayArray(Bird.birds);

            Console.WriteLine();
        }

        //DisplayArray(): Display an array of objects that implement the IDisplayable interface.
        //Any array that contains object that implement the IDisplayble interface can be passed in. 
        public static void DisplayArray(IDisplayable[] displayables)
        {
            foreach (IDisplayable displayable in displayables)
            {
                Console.WriteLine("{0}", displayable.Display());
            }
        } 
    }
}
