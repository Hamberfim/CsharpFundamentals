/***************************************************************
* Name        : fileWriteTest
* Author      : Anthony Hamlin
* Created     : 02/19/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : write a file - base program using File.WriteAllText 
*               will not work with Norton av running 
*               because it try's to create a registry key.
*               Using StreamWriter instead
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
            Console.WriteLine($"Current directory is {path}");

            // Write ro Project directory - up three directories (NOTE: 'Path' is not the same as 'path')
            string projDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // each call gets its parent directory
            Console.WriteLine($"Project directory is {projDir}");  // write/read file at this directory
            Console.WriteLine();  //space in output

            // absolute path - anti-virus issue
            // projDir = "C:\\Users\\adhamlin\\Documents\\GitHub\\Csharp_pubs\\CsharpFundamentals\\fileWriteTest";

            string phrase = "\t'The Ballad of Reading Gaol'";  // carrage return, new line, tab
            phrase += "\r\n\tI never saw a man who looked";
            phrase += "\r\n\twith such a wistful eye";
            phrase += "\r\n\tupon that little text of blue";
            phrase += "\r\n\twhich prisoners call the sky";
            phrase += "\r\n\tAnd at every drifting cloud that went";
            phrase += "\r\n\tWith sails of silver by.";
            phrase += "\r\n\t\t~Oscar Wilde";


            /*// check if text file exists - NOT USING - it try's to create a registry key and is blocked by Norton 360 AV
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
            Console.WriteLine("^^^ Using 'File.WriteAllText' attempt completed ^^^");
            Console.WriteLine();  //space in output
            Console.WriteLine();  //space in output*/

            // ======= USING StreamWriter =======
            // will overwrite existing file(s)
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter($"{projDir}\\SWTest.txt");
                // write poem
                sw.WriteLine(phrase);
                //Write a line of text
                sw.WriteLine("\n\nHello World!!");
                //Write a second line of text
                sw.WriteLine("~From the StreamWriter class");
                //Close the file
                sw.Close();
                Console.WriteLine($"File written to: {projDir}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine("^^^ Using 'StreamWriter' attempt completed ^^^");
            Console.WriteLine();  //space in output


            Console.WriteLine("===== Reading Text FILE back into Console=====");
            Console.WriteLine();  //space in output
            try
            {
                // ======= USING StreamReader =======
                // read file using StreamReader
                // pass path and file name into StreamReader
                StreamReader sr = new StreamReader($"{projDir}\\SWTest.txt");
                string line = sr.ReadLine();
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Then read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine("Exception: " + error.Message);
            } 

            Console.WriteLine("\n\n\n");
        }
    }
}
