/***************************************************************
* Name        : fileWriteTest
* Author      : Anthony Hamlin
* Created     : 02/19/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : write a file        
***************************************************************/
using System;
using System.IO;

namespace fileWriteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Write File Test";

            //string dir_path = Path.Combine(Environment.CurrentDirectory);
            //Console.WriteLine($"The current Environment Directory is {dir_path}");

            // When ran path is '...\<current project directory>\bin\Debug\netcoreapp3.1'
            string path = Directory.GetCurrentDirectory();
            // I wan to use a relative path to the project directory - this directory/control may not be correct if the app was deployed
            Console.WriteLine($"The current full directory is {path}");

            // Write ro Project directory - up three directories (NOTE: 'Path' is not the same as 'path')
            string projDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // each call gets its parent directory
            Console.WriteLine($"Get the projectdirectory {projDir}");  // write/read file at this directory
            Console.WriteLine();  //space in output

            string phrase = "\r\n\tI never saw a man who looked";  // carrage return, new line, tab
            phrase += "\r\n\twith such a wistful eye";
            phrase += "\r\n\tupon that little text of blue";
            phrase += "\r\n\twhich prisoners call the sky";


            // check if text file exists
            if(File.Exists(projDir))
            {
                Console.WriteLine($"File Already Exist as: {projDir}");
            }
            else
            {
                // write text file
                try
                {
                    File.WriteAllText(projDir, phrase);
                    Console.WriteLine($"File written to: {projDir}");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
