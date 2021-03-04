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
            //Create a StreamWriter object.
            StreamWriter sw = null;
            string fileName = "";

            //Get a list of filenames from the user using while loop.
            while (true)
            {
                try
                {
                    //Enter output filename.
                    Console.Write("Enter filename (Enter blank filename to quit): ");

                    //Read and store the filename.
                    fileName = Console.ReadLine();

                    if (fileName.Length == 0)
                    {
                        break;
                    }

                    //Call a method (below) to set up the StreamWriter.
                    sw = GetWriterForFile(fileName);

                    //Read one string from console at a time.
                    WriteFileFromConsole(sw);

                    //Closes the stream.
                    sw.Close();

                    //A file object is useless after the file has been closed. 
                    //It is good programming practice to null a reference after it becomes invalid.
                    sw = null;  
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

            //Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }

        //GetWriterForFile(): Setup a StreamWriter to write to the specified file (passed in as parameter).
        private static StreamWriter GetWriterForFile(string fileName)
        {
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

            //Generate a stream writer and connect it to this file: the parameter is the stream to write to.
            StreamWriter sw = new StreamWriter(fs);
            
            return sw;
        }

        //WriteFileFromConsole(): Read lines of text from the console and spit them back out to the file.
        private static void WriteFileFromConsole(StreamWriter sw)
        {
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
}
