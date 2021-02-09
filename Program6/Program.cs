using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------- ARRAY -------------------------------

            Console.WriteLine("The 5 planets closest to the sun, in order: \n");

            string[] planets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };

            foreach (string planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("\nNow listed alphabetically: \n");

            //Sort() Array Build-In Function - sort string array by alphabetically order

            string[] sortedPlanets = planets;

            Array.Sort(sortedPlanets);

            foreach (string planet in sortedPlanets)
            {
                Console.WriteLine(planet);
            }


            Console.WriteLine("\nList by name length - shortest first: \n");

            //The Array.Sort() method can not be used to sort by string length

            //From left to right
            for (int i = 0; i < planets.Length - 1; i++)
            {
                //Each inner loop put the longest name to the last position
                for (int j = 0; j < planets.Length - 1 - i; j++)
                {
                    if (planets[j].Length > planets[j + 1].Length)
                    {
                        string temp = planets[j];

                        planets[j] = planets[j + 1];

                        planets[j + 1] = temp;
                    }
                }
            }

            foreach (string planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("\nNow listed longest first: \n");

            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(planets[i]);
            }


            // --------------------------- LIST -------------------------

            List<string> wordList = new List<string>();

            //Add string
            wordList.Add("one");
            wordList.Add("two");
            wordList.Add("three");
            wordList.Add("four");
            wordList.Add("five");

            string[] wordArray = new string[] { "six", "seven", "eight", "nine", "ten" };

            //Add collection: AddRange() - put an array into the list (the element in the array will be added to the list in order)
            wordList.AddRange(wordArray);

            //ERROR! CAN ONLY ADD STRING TO THIS LIST!

            //wordList.Add(1);
            //wordList.Add(new Student("Mike"));

            Console.WriteLine("\nWord List: ");

            foreach (string word in wordList)
            {
                Console.WriteLine("Current Word: " + word);
            }

            //Search: IndexOf() - returning index of element
            Console.WriteLine("\nSearch: ");
            Console.WriteLine("#2 at " + wordList.IndexOf("two"));
            Console.WriteLine("#6 at " + wordList.IndexOf("six"));
            Console.WriteLine("#10 at " + wordList.IndexOf("ten"));

            if (wordList.Contains("three"))
            {
                Console.WriteLine("#3 contained in list");
            }

            if (wordList.Contains("five"))
            {
                Console.WriteLine("#5 contained in list");
            }

            //Insert:
            wordList.Insert(3, "dummy");

            Console.WriteLine("\nAfter Inserting: ");

            foreach (string word in wordList)
            {
                Console.WriteLine("Current Word: " + word);
            }

            //Remove:
            wordList.RemoveAt(3);

            Console.WriteLine("\nAfter Removing: ");

            foreach (string word in wordList)
            {
                Console.WriteLine("Current Word: " + word);
            }

            //Sort:
            wordList.Sort();

            Console.WriteLine("\nAfter Sorting: ");

            foreach (string word in wordList)
            {
                Console.WriteLine("Current Word: " + word);
            }

            //Count:
            Console.WriteLine("This list contains {0} words.", wordList.Count());


            // ------------------------ DICTIONARY -------------------------

            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("C#", 2);
            dict.Add("C++", 3);
            dict.Add("VB", 0);
            dict.Add("Java", 2);
            dict.Add("Fortran", 0);
            dict.Add("Cobol", 0);

            Console.WriteLine("\nSearch By Key: ");
            Console.WriteLine("Contains C#: " + dict.ContainsKey("C#"));
            Console.WriteLine("Contains C++: " + dict.ContainsKey("C++"));
            Console.WriteLine("Contains C: " + dict.ContainsKey("C"));
            Console.WriteLine("Contains Ruby " + dict.ContainsKey("Ruby"));

            Console.WriteLine("\nSearch By Value: ");
            Console.WriteLine("Contains 0: " + dict.ContainsValue(0));
            Console.WriteLine("Contains 1: " + dict.ContainsValue(1));
            Console.WriteLine("Contains 2: " + dict.ContainsValue(2));

            Console.WriteLine("\nContents of the dictionary:");

            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine("Key: " + pair.Key.PadRight(12) + "Value: " + pair.Value);
            }

            Console.WriteLine("\nJust the keys:");

            //KeyCollection is a collection of just the keys

            Dictionary<string, int>.KeyCollection keys = dict.Keys;

            foreach (string key in keys)
            {
                Console.WriteLine("Key: " + key);
            }

            Console.WriteLine("\nJust the values:");

            //ValueCollection is a collection of just the values

            Dictionary<string, int>.ValueCollection values = dict.Values;
            foreach (int value in values)
            {
                Console.WriteLine("Value: " + value);
            }

            Console.Write("\nNumber of items in the dictionary: " + dict.Count);


            // ------------------------ SET -------------------------

            //Union
            Console.WriteLine("\n\nCombining two collections with no duplicates:");

            List<int> numList1 = new List<int> { 1, 2, 3 };
            List<int> numList2 = new List<int> { 3, 4, 5 }; 

            //Initialize the set using list (or other collection)
            HashSet<int> union = new HashSet<int>(numList1);

            union.UnionWith(numList2);

            foreach (int num in union)
            {
                Console.WriteLine(num);
            }

            //Intersection
            Console.WriteLine("\nFinding the overlap in two lists:");

            List<int> numList3 = new List<int> { 1, 2, 3 };
            List<int> numList4 = new List<int> { 3, 4, 5 };

            //Initialize the set using list (or other collection)
            HashSet<int> intersection = new HashSet<int>(numList3);

            intersection.IntersectWith(numList4);

            foreach (int num in intersection)
            {
                Console.WriteLine(num);
            }

            //Unique (Non-overlapping)
            Console.WriteLine("\nFinding just the non-overlapping items in two lists:");

            List<int> numList5 = new List<int> { 1, 2, 3 };
            List<int> numList6 = new List<int> { 3, 4, 5 };

            //Initialize the set using list (or other collection)
            HashSet<int> unique = new HashSet<int>(numList5);

            unique.SymmetricExceptWith(numList6);

            foreach (int num in unique)
            {
                Console.WriteLine(num);
            }

            //Except
            Console.WriteLine("\nExcluding items from a list:");

            List<int> numList7 = new List<int> { 1, 2, 3 };
            List<int> numList8 = new List<int> { 3, 4, 5 };

            //Initialize the set using list (or other collection)
            HashSet<int> except = new HashSet<int>(numList7);

            except.ExceptWith(numList8);

            foreach (int num in except)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //Wait for user to acknowledge the result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();            

        }
    }
}
