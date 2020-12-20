using System;

namespace Program1
{
    class Program
    {
        //This is where your program starts
        static void Main(string[] args)
        {
            //Prompt user to enter a name
            Console.WriteLine("Enter your name, please:");

            //Now read the name entered
            string name = Console.ReadLine();

            //Prompt user to enter an age
            Console.WriteLine("Enter your age, please: ");

            //Now read the age entered
            string age = Console.ReadLine();

            //Greet the user with the name and age that were entered
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            //Wait for user to acknowledge the result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}

/*
 * NOTE:
 * 
 * About C#:
 * 1. C# combines C++ with Visual Basic.
 * 
 * About .NET:
 * 1. Internet programming was difficult in older languages such as C and C++. 
 * 2. Sun Microsystems responded to that problem by creating the Java programming language.
 * 3. When Microsoft licensed Java some years ago, it ran into legal difficulties with Sun over changes it wanted to make to the Java language. 
 * 4. As a result, Microsoft gave up on Java and started looking for ways to compete with it.
 * 5. .NET is a framework, in many ways similar to Java’s libraries — and the C# language is highly similar to the Java language.
 */