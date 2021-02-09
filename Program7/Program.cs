using System;
using System.IO;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName;

            if (args.Length == 0)
            {
                //Get the current directory name
                directoryName = Directory.GetCurrentDirectory();
            }
            else
            {
                //Get the directory name from arguments
                directoryName = args[0];
            }

            Console.WriteLine(directoryName);

            //Get a list of all files in that directory.
            FileInfo[] files = GetFileList(directoryName);

            //Iterate through the file list and do "hex dump" for each file
            
            foreach (FileInfo file in files)
            {
                //Print file name
                Console.WriteLine("\n\nHex dump of file {0}:", file.FullName);

                //Now "dump" the file to the console.
                DumpHex(file);

                //Wait before outputting next file.
                Console.WriteLine("\nEnter return to continue to next file");
                Console.ReadLine();
            }
            
            //Finish
            Console.WriteLine("\nNo files left");

            //Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate…");
            Console.Read();
        }

        //GetFileList() - returning a list of all files in a specified directory
        public static FileInfo[] GetFileList(string directoryName)
        {
            //Start with an empty list
            FileInfo[] files = new FileInfo[0];
            
            try
            {
                //Get directory information
                DirectoryInfo di = new DirectoryInfo(directoryName);

                //That information object has a list of the contents
                files = di.GetFiles();
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory \"{0}\" invalid", directoryName);
                Console.WriteLine(e.Message);
            }

            return files;
        }

        //DumpHex() - given a file then dump the file contents to the console
        public static void DumpHex(FileInfo file)
        {
            FileStream fs;
            BinaryReader reader;
  
            try
            {
                //Open the file
                fs = file.OpenRead();
                
                //Wrap the file stream in a BinaryReader
                reader = new BinaryReader(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nCan't read from \"{0}\"", file.FullName);
                Console.WriteLine(e.Message);

                return;
            }

            //Iterate through the contents of the file one line at a time

            int line = 1;

            while (true)
            {
                //Read 10 bytes once
                byte[] buffer = new byte[10];

                //Use the BinaryReader to read bytes
                int numBytes = reader.Read(buffer, 0, buffer.Length);

                //Stop if reach the end
                if (numBytes == 0)
                {
                    return;
                }

                //Write the data in a single line preceded by line number
                Console.Write("{0:D3} - ", line);

                DumpBuffer(buffer, numBytes);

                //Stop every 20 lines
                if ((line % 20) == 0)
                {
                    Console.WriteLine("Enter return to continue another 20 lines");
                    Console.ReadLine();
                }

                line++;
            }
        }

        //DumpBuffer() -- write a buffer of characters as a single line in hex format.
        public static void DumpBuffer(byte[] buffer, int numBytes)
        {
            for (int index = 0; index < numBytes; index++)
            {
                byte b = buffer[index];

                Console.Write("{0:X2}, ", b);
            }

            Console.WriteLine();
        }
    }
}
