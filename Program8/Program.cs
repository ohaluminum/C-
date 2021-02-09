using System;
using System.Collections.Generic;


namespace Program8
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program creates a priority queue class

            Console.WriteLine("Create a priority queue:");

            //The PriorityQueue is a customized class (special queue) 
            PriorityQueue<Package> pq = new PriorityQueue<Package>();

            Console.WriteLine("Add packages to the queue:");

            //The Package class stores all information about the packages
            Package pack;

            //The PackageFactory class can create new package with random priority
            PackageFactory fact = new PackageFactory();

            Console.WriteLine("Enter the number of packages to add:");
            
            string addInput = Console.ReadLine();
            int numToCreate = Convert.ToInt32(addInput);

            for (int i = 0; i < numToCreate; i++)
            {
                Console.Write("\tGenerating and adding random package {0}", i);

                pack = fact.CreatePackage();
                        
                Console.WriteLine(" with priority {0}", pack.Priority);
                
                //Add to the priority queue based on the priority
                pq.Enqueue(pack);    
            }

            Console.WriteLine("Packages received: {0}", pq.Count);

            Console.WriteLine("Enter the number of packages to ship:");

            string removeInput = Console.ReadLine();
            int numToRemove = Convert.ToInt32(removeInput);
            
            //Check user input for the number of packages to remove from the queue
            while (numToRemove > pq.Count)
            {
                Console.WriteLine("Exceed the number of packages that stored in thge queue");
                Console.WriteLine("Enter Again!");

                removeInput = Console.ReadLine();
                numToRemove = Convert.ToInt32(removeInput);
            }

            Console.WriteLine("\tRemoving up to {0} packages", numToRemove);

            for (int i = 0; i < numToRemove; i++)
            {
                pack = pq.Dequeue();

                if (pack != null)
                {
                    Console.WriteLine("\tShipped package with priority {0}", pack.Priority);
                }
            }
            
            Console.WriteLine("Packages shipped: {0}", numToCreate - pq.Count);

            //Wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }

        //Priority enumeration: Defines priority option (Check chapter 10 for more information about enumeration)
        enum Priority
        {
            Low, Medium, High
        }
        
        //IPrioritizable interface: Defines ability to prioritize
        //Define a custom interface: Classes that can be added to PriorityQueue must implement this interface
        interface IPrioritizable
        {
            //Implement thgis interface: must provide the priority information
            Priority Priority { get; }
        }

        //PriorityQueue class: A generic priority queue class
        //NOTE: the "where T : IPrioritizable" restricts that object that added to the queue must implement IPrioritizable interface
        class PriorityQueue<T> where T : IPrioritizable
        {
            //Generic Queues
            private Queue<T> _queueHigh = new Queue<T>();
            private Queue<T> _queueMedium = new Queue<T>();
            private Queue<T> _queueLow = new Queue<T>();

            //Enqueue(): Prioritize T and add an item of type T to correct queue
            public void Enqueue(T item)
            {
                switch (item.Priority)
                {
                    //Add to the high priority queue
                    case Priority.High:

                        _queueHigh.Enqueue(item);
                        break;

                    //Add to the medium priority queue
                    case Priority.Medium:

                        _queueMedium.Enqueue(item);
                        break;

                    //Add to the low priority queue
                    case Priority.Low:
                        _queueLow.Enqueue(item);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(item.Priority.ToString(), "bad priority in PriorityQueue.Enqueue");
                }
            }

            //Dequeue(): Remove T from highest-priority queue available.
            public T Dequeue()
            {
                //Get the highest priority queue with items
                Queue<T> queueTop = TopQueue();

                //Chekc if the queue is empty or not
                if (queueTop != null & queueTop.Count > 0)
                {
                    //Return the front package
                    return queueTop.Dequeue();
                }

                //If all queues empty then return null
                return default(T);
            }

            //TopQueue(): Return the highest priority queue with items
            private Queue<T> TopQueue()
            {
                if (_queueHigh.Count > 0)
                {
                    return _queueHigh;
                }

                if (_queueMedium.Count > 0)
                {
                    return _queueMedium;
                }
                    
                if (_queueLow.Count > 0)
                {
                    return _queueLow;
                }
                
                //Return an empty list
                return _queueLow;
            }

            //IsEmpty(): Check whether the priority queue is empty
            public bool IsEmpty()
            {
                //True if all queues are empty
                return (_queueHigh.Count == 0) & (_queueMedium.Count == 0) & (_queueLow.Count == 0);
            }

            //Count: queue counter
            public int Count
            {
                //Read only property
                get
                {
                    return _queueHigh.Count + _queueMedium.Count + _queueLow.Count;
                }
            }
        }

        //Package class: Must implement the IPrioritizable interface
        class Package : IPrioritizable
        {
            private Priority _priority;

            //Constructor
            public Package(Priority priority)
            {
                this._priority = priority;
            }

            //Priority: Return package priority
            public Priority Priority
            {
                //Read only property
                get 
                { 
                    return _priority; 
                }
            }
        }

        //PackageFactory class: Help to create a new package
        class PackageFactory
        {
            //A random-number generator
            Random _randGen = new Random();

            public Package CreatePackage()
            {

                int rand = _randGen.Next(3);

                //Cast it to Priority
                return new Package((Priority)rand);
            }
        }
    }
}
