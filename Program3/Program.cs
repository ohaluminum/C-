using System;
using System.Text;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ STRING BASIC ----------------

            //(S)tring: string object
            //(s)tring: string variable

            //String is immutable

            string name1 = "Iris";
            string name2 = name1.ToLower();
            string name3 = name1.ToUpper();

            //Name1 is not been changed
            Console.WriteLine("Original: " + name1);
            Console.WriteLine("Lower Case:" + name2);
            Console.WriteLine("Upper Case: " + name3);


            // ------------ COMPARE STRING ---------------

            Console.WriteLine("\nBuild A Sentence: Each line you enter will be added to a sentence until you enter 'exit' or 'quit'");

            //Declare and initialize an empty string
            string sentence = "";
            bool isQuit = false; 

            //Infinite loop
            while (true)
            {
                //Get the next line
                Console.WriteLine("Enter A String: ");

                string line = Console.ReadLine();

                //String build-in function: Compare(String first, String second, bool caseSensitibity)
                if (String.Compare(line, "exit", true) == 0 || String.Compare(line, "quit", true) == 0)
                {
                    //The user enter 'exit' or 'quit' (case-insensitive)
                    isQuit = true;
                }

                //Break out of this infinite loop if 
                if (isQuit)
                {
                    break;
                }

                else
                {
                    //String build-in function: Concat(String first, String second)
                    sentence = String.Concat(sentence, line);

                    Console.WriteLine("\nYou've entered: " + sentence);
                }                
            }

            Console.WriteLine("\nFinal Sentence:\n" + sentence);


            // ----------- LOOP THROUGH STRING ------------

            string major = "Computer Science";
            int upperCount = 0;

            foreach (Char c in major)
            {
                Console.WriteLine("Current Character: " + c);

                //Character build-in function: IsUpper(char c) / IsLower(char c)
                if (Char.IsUpper(c))
                {
                    upperCount++;
                }
            }

            Console.WriteLine("There is(are) " + upperCount + " upper character(s) in total.");


            // -------------- SEARCH IN STRING -------------

            int index;

            //Function: IndexOf(char c) - returning the index of the first one found
            index = major.IndexOf('e');
            Console.WriteLine("\nFirst index of 'e': " + index);

            //Function: LastIndexOf(char c) - returning the index of the last one found
            index = major.LastIndexOf('e');
            Console.WriteLine("\nLast index of 'e': " + index);

            //Function: IndexOfAny(char[] c) - returning the index of the first one found
            index = major.IndexOfAny(new char[] { 'a', 'b', 'c' });
            Console.WriteLine("\nFirst index of any: " + index);

            //Function: LastIndexOfAny(char[] c) - returning the index of the last one found
            index = major.LastIndexOfAny(new char[] { 'a', 'b', 'c' });
            Console.WriteLine("\nLast index of any: " + index);
            Console.WriteLine();

            //Function: Contains(string sub) - returning true if given substring is found
            if (major.Contains("ute"))
            {
                Console.WriteLine("Found!");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }

            Console.WriteLine();

            if(major.Contains("com"))
            {
                Console.WriteLine("Found!");
            }
            else 
            {
                Console.WriteLine("Not Found!");
            }

            Console.WriteLine();

            //Function: SubString(int start) - returning the string or empty
            string sub = major.Substring(9);
            Console.WriteLine("Sub-String: " + sub);

            //Function: Substring(int startIndex, int length) - returning the string or empty
            sub = major.Substring(3, 5);
            Console.WriteLine("Sub-String: " + sub);

            sub = major.Substring(3, major.Length - 3);
            Console.WriteLine("Sub-String: " + sub);

            bool notThere;

            //Start index is the length of the string
            sub = major.Substring(16);

            //String build-in function: IsNullOrEmpty(string value) - returning true if the value is null or an empty string ("")
            notThere = String.IsNullOrEmpty(sub);

            if (notThere)
            {
                Console.WriteLine("Empty!");
            }

            //Sub-string length is zero 
            sub = major.Substring(0, 0);

            notThere = String.IsNullOrEmpty(sub);

            if (notThere)
            {
                Console.WriteLine("Empty!");
            }

            //There are two ways to set a string empty:

            //string temp = "";
            //string temp = string.Empty;


            // -------------- PARSE STRING ---------------

            string temp1 = " \nThis is a string.\t\n";
            string temp2 = temp1;
            string temp3 = temp1;

            Console.WriteLine() ;
            //Trim off extra spaces on either end of the string
            temp1 = temp1.Trim();
            Console.WriteLine(temp1);

            //Trim off extra spaces on the front of the string
            temp2 = temp2.TrimStart();
            Console.WriteLine(temp2);

            //Trim off extra spaces on the end of the string
            temp3 = temp3.TrimEnd();
            Console.WriteLine(temp3);

            string numList = " 1, 3, a 7 2 ,, 4a 4 b,";
            Console.WriteLine("\nParse number in this string: " + numList);

            //Convert the line into individual segments based upon either commas or spaces
            char[] delimiter = { ',', ' ' };
            string[] nums = numList.Split(delimiter);

            foreach (string num in nums)
            {
                //Skip any empty num string
                if (num.Length > 0)
                {
                    // Skip strings that aren't numbers.
                    if (IsAllDigits(num))
                    {
                        //Convert the string into a 32-bit int.
                        int numble = Convert.ToInt32(num);
                        
                        Console.WriteLine("Current number = {0}", numble);                        
                    }
                }
            }


            // -------------- JOIN STRING ---------------

            string[] names = { "Iris", "Bob", "Steve", "Mike" };
            string nameList = String.Join("-", names);

            Console.WriteLine("\nName List: " + nameList);


            // ------ REMOVE CHARACTERS IN STRING --------
            
            //Replace one character by another character
            string sign1 = "Dangerous Do Not Smoking";

            sign1 = sign1.Replace(' ', '-');

            Console.WriteLine(sign1);

            //Remove special characters in the string
            string sign2 = "  Dangerous \tDo  \r Not    Smoking\n\t\r";
            char[] whitespace = { ' ', '\n', '\t', '\r' };

            sign2 = RemoveSpecialChars(sign2, whitespace);

            Console.WriteLine(sign2);


            // ------------- STRING BUILDER -------------

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                builder.Append(i.ToString());
            }

            string result = builder.ToString();

            Console.WriteLine("\n"+result);


            //Wait for user to acknowledge the result
            Console.WriteLine("\nPress Enter to terminate...");
            Console.Read();
        }

        //IsAllDigits() - returning true if all characters are digit
        static public bool IsAllDigits(string raw)
        {
            //Ignore white space on either side
            string modified = raw.Trim();

            //Emply string
            if (modified.Length == 0)
            {
                return false;
            }

            //Loop through the string
            for (int i = 0; i < modified.Length; i++)
            {
                //A non-digit indicates that the string is not a number
                if (Char.IsDigit(modified[i]) == false)
                {
                    return false;
                }
            }

            //No non-digits found
            return true;
        }

        //RemoveSpecialChars() - returning modified string that removed the special characters 
        static public string RemoveSpecialChars(string input, char[] delimiter)
        {
            //Split the input string using delimiter
            string[] subStrings = input.Split(delimiter);

            string output = "";

            //Loop through the substrings list
            foreach (string subString in subStrings)
            {
                output = String.Concat(output, subString);
            }

            return output;
        }
    }
}
