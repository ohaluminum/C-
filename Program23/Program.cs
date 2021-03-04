using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "";           

            //Get a list of filenames from the user using while loop.
            while (true)
            { 
                try
                {
                    //Enter output filename.
                    Console.Write("Enter output filename (Enter blank filename to quit): ");

                    //Read and store the filename.
                    fileName = Console.ReadLine();

                    if (fileName.Length == 0)
                    {
                        break;
                    }

                    //This is a good way to open an file and create a file stream: File.Open() return a FileStream object.
                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    /* Notes:
                     * - File Name: the name of the file to open.
                     * - File Mode: the mode of writing:
                     *    - CreateNew: create a new file if it doesn't already exist or throw an exception if file exists.
                     *    - Create: create a new file or overwrite an existing file.
                     *    - Append: append to an existing file or create a new file if it doesn't exist.
                     * - File Access Type: the type of access - Read, Write, and ReadWrite.
                     */

                    //There are other ways to create file stream, such as create a FileStream object directly (require provide file path instead of file name):
                    //FileStream fs1 = new FileStream(@"D:\Test.txt", FileMode.Append, FileAccess.Write);

                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //StreamWriter object exists only within the using block (local scope).
                        
                        Console.WriteLine("Enter text (enter blank line to stop): ");

                        while (true)
                        {
                            //Read next line from Console (quit if line is blank).
                            string input = Console.ReadLine();

                            if (input.Length == 0)
                            {
                                break;
                            }

                            //Write the line just read to output file.
                            sw.WriteLine(input);
                        }
                    }
                }
                catch (IOException ioErr)
                {
                    //Tell the user the full name of the file: Tack the name of the default directory to the filename.

                    //Directory class
                    string dir = Directory.GetCurrentDirectory();

                    //System.IO.Path class
                    string path = Path.Combine(dir, fileName);
                    Console.WriteLine("Error on file {0}", path);

                    //Now output the error message in the exception.
                    Console.WriteLine(ioErr.Message);
                }
            }

            //Get a single filename from the user.
            try
            {
                //Enter input filename.
                Console.Write("Enter input filename (Enter blank filename to quit): ");

                //Read and store the filename.
                fileName = Console.ReadLine();

                if (fileName.Length == 0)
                {
                    throw new IOException("You need to enter a filename.");
                }

                FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read);

                /* Notes:
                 * - File Name: the name of the file to open.
                 * - File Mode: the mode of reading:
                 *    - Open: open the file if it exists or throw an exception if it doesn’t.
                 *    - OpenNew: creates a zero-length file if the file doesn’t exist.
                 *    - Append: append to an existing file or create a new file if it doesn't exist.
                 * - File Access Type: the type of access - Read, Write, and ReadWrite.
                 */

                using (StreamReader sr = new StreamReader(fs))
                {
                    //StreamReader object exists only within the using block (local scope).

                    Console.WriteLine("\nContents of file:");

                    while (true)
                    {
                        //Read line by line.
                        string input = sr.ReadLine();

                        //Quit if reach the end of the file.
                        if (input == null)
                        {
                            break;
                        }

                        //Write what you read to the console.
                        Console.WriteLine(input);
                    }
                }
            }
            catch (IOException ioErr)
            {
                //Directory class
                string dir = Directory.GetCurrentDirectory();

                //System.IO.Path class
                string path = Path.Combine(dir, fileName);
                Console.WriteLine("Error on file {0}", path);

                //Now output the error message in the exception.
                Console.WriteLine(ioErr.Message);
            }

            //Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }
    }
}
