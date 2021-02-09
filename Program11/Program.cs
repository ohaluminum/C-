using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    public class Vehicle
    {
        public string model;                //The name of the model
        public string manufacturer;         //The name of the manufacturer
        public int numOfDoors;              //The number of doors on the vehicle
        public int numOfWheels;             //The number of wheels on the vehicle

        public Motor motor;
        public static int numberOfCars;     //The number of cars built
    }

    public class Motor
    {
        public int power;                   //Power [horsepower]
        public double displacement;         //Engine Displacement [liter]
    }

    class Program
    {
        static void Main(string[] args)
        {
            // -------------------- INTRODUCTION --------------------------

            //Object Oriented Programs Features:

            //1. Controlled access
            //2. Specialization
            //3. Polymorphism
            //4. Indirection

            // -------------------- DESIGN A CLASS ------------------------
            
            Console.WriteLine("Enter the properties of my vehicle: ");

            //Create an instance of Vehicle
            Vehicle myCar = new Vehicle();

            Console.Write("Model name = ");
            myCar.model = Console.ReadLine();


            Console.Write("Manufacturer name = ");
            myCar.manufacturer = Console.ReadLine();

            Console.Write("Number of doors = ");
            string s = Console.ReadLine();
            myCar.numOfDoors = Convert.ToInt32(s);

            Console.Write("Number of wheels = ");
            s = Console.ReadLine();
            myCar.numOfWheels = Convert.ToInt32(s);

            //Motor information
            Motor myMotor = new Motor();
            myMotor.power = 230;
            myMotor.displacement = 4.0;

            //Attach the motor to the car
            myCar.motor = myMotor;

            //Static class member
            Vehicle.numberOfCars++;

            Vehicle yourCar = myCar;
            Vehicle.numberOfCars++;

            //Changing one also changes the other
            yourCar.model = "Henry J";

            //Display the information
            Console.WriteLine("\nMy vehicle: ");
            Console.WriteLine(myCar.manufacturer + " " + myCar.model 
                            + " with " + myCar.numOfDoors + " doors, "
                            + "riding on " + myCar.numOfWheels + " wheels.");
            Console.WriteLine("The motor power is " + myCar.motor.power + " horsepower, " 
                            + "and the displacement is " + myCar.motor.displacement);

            Console.WriteLine("\nYour vehicle: ");
            Console.WriteLine(yourCar.manufacturer + " " + yourCar.model
                            + " with " + yourCar.numOfDoors + " doors, "
                            + "riding on " + yourCar.numOfWheels + " wheels.");
            Console.WriteLine("The motor power is " + yourCar.motor.power + " horsepower, "
                            + "and the displacement is " + yourCar.motor.displacement);

            Console.WriteLine("\nThere are " + Vehicle.numberOfCars + " vehicles in total.");

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }

        
    }
}
