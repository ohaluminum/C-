using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15
{
    public class Person
    {
        protected string firstName;
        protected string lastName;

        //Default Constructor: The default base class constructor is invoked any time a subclass is constructed.
        public Person() : this("James", "Smith")
        {
            //The default constructor invokes the Person(string first, string last) constructor using the "this" keyword.
            Console.WriteLine("Calling base-class default constructor.");
        }

        //Customized Constructor 
        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;

            Console.WriteLine("Calling base-class customized constructor.");
        }

        //FirstName property
        public string FirstName { get { return firstName; } set { firstName = value; } }

        //LastName property
        public string LastName { get { return lastName; } set { lastName = value; } }

        public void PersonIntroduction()
        {
            Console.WriteLine("I'm {0} {1}.", firstName, lastName);
        }
    }

    public class Student : Person
    {
        protected int studentID;

        //Default Constructor: Just to show how constructord work (calling the default base-class constructor)
        public Student() : this("James", "Smith", -1)
        {
            Console.WriteLine("Calling sub-class default constructor.");
        }

        //Customized Constructor: Just to show how constructord work (calling the customized base-class constructor)
        public Student(string first, string last, int id) : base(first, last)
        {
            studentID = id;

            Console.WriteLine("Calling sub-class customized constructor.");
        }

        //StudentID property
        public int StudentID { get { return studentID; } set { studentID = value; } }

        public void StudentIntroduction()
        {
            Console.WriteLine("I'm {0} {1}, and my student ID is: {2}.", firstName, lastName, StudentID);
        }
    }

    class Program
    {
        // ------------- AVOIDING INVALID CONVERSIONS WITH THE IS OPERATOR -----------

        //Rule:
        //The "is" operator accepts an object on the left and a type on the right. 
        //The "is" operator returns true if the runtime type of the object on the left is compatible with the type on the right.

        public static void Introduction_is(Person person)
        {
            //If the object is a Student
            if (person is Student)
            {
                Student student = (Student)person;

                //Runtime error occurs if Person object calls this function
                student.StudentIntroduction();
                
                return;
            }

            person.PersonIntroduction();
        }

        // ------------- AVOIDING INVALID CONVERSIONS WITH THE AS OPERATOR -----------

        //Rule: 
        //The "as" operator accepts an object on the left and a type on the right.
        //The "as" operator converts the type on the left to the type on the right.

        //The "as" operator is more efficient, but "as" doesn’t work with value-type variables.

        public static void Introduction_as(Person person)
        {
            //Convert 
            Student student = person as Student;

            if (student != null)
            {
                //Runtime error occurs if Person object calls this function
                student.StudentIntroduction();

                return;
            }

            person.PersonIntroduction();
        }

        public static void Main(string[] args)
        {
            //Object-oriented programming is based on four principles: 

            //1. Encapsulation: capability to control access 
            //2. Inheritance: inherit from other classes 
            //3. Polymorphism: respond appropriately 
            //4. Interfaces: refer from one object to another indirectly

            //Example 1: call customized (this) first then default 
            Person person1 = new Person();
            Introduction_is(person1);
            Console.WriteLine();

            //Example 2: call customized
            Person person2 = new Person("Lejing", "Huang");
            Introduction_as(person2);
            Console.WriteLine();

            //Example 3: call customized (base) first then customized (sub) then default (sub)
            Student student1 = new Student();
            Introduction_is(student1);
            Console.WriteLine();

            //Example 4: call customized (base) first then customized (sub) 
            Student student2 = new Student("Dan", "Li", 201510400);
            Introduction_as(student2);
            Console.WriteLine();   
        }
    }
}
