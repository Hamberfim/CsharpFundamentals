/***************************************************************
* Name        : fileStreamWrite
* Author      : Anthony Hamlin
* Created     : 02/22/2021 
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
*               
* Description : Write/Append a file - using StreamWriter
*               Read a file - using StreamReader
***************************************************************/
using System;
using System.IO;

namespace fileStreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "System.IO StreamWriter, StreamReader";
            // get current dir
            string path = Directory.GetCurrentDirectory();
            // Write to Project directory - up three directories (NOTE: 'Path' is not the same as 'path')
            string projDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // each call goes up its parent directory
            Console.WriteLine($"Project directory is {projDir}");  // write/read file at this directory
            projDir = $"{projDir}\\SWTest.txt";
            Console.WriteLine($"Project file path {projDir}");
            Console.WriteLine();  //space in output

            // text to write
            string poem = "\tPerfumes bloomed from a brood of dawns";
            poem += "\r\n\tThat always lies on the straw of the stars,";
            poem += "\r\n\tAs the day depends on innocence";
            poem += "\r\n\tThe whole world depends on your pure eyes";
            poem += "\r\n\tAnd all my blood flows in their looks.";

            string attrib = "\r\n\t\t'La Courbe de tes yeux'";
            attrib += "\r\n\t\t~by Paul Éluard";

            // ======= write file 
            try
            {
                // write file and close StreamWriter
                StreamWriter sw = new StreamWriter(projDir);
                sw.WriteLine(poem);
                //close the file
                sw.Close();
                Console.WriteLine();  //space in output
                Console.WriteLine($"File written to: {projDir}");
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine();  //space in output

            Console.WriteLine("===== Reading Text FILE =====");
            Console.WriteLine();  //space in output

            // ======= Read file
            try
            {
                // ======= USING StreamReader =======
                // read file using StreamReader
                // pass path/file name into StreamReader
                StreamReader sr = new StreamReader(projDir);
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
            Console.WriteLine();  //space in output


            // ======= append file
            try
            {
                // append the same file with 'using' - will auto close
                using (StreamWriter sa = new StreamWriter(projDir, true))
                {
                    sa.WriteLine(attrib);
                    Console.WriteLine();  //space in output
                    Console.WriteLine($"File appended: {projDir}");
                }
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine();  //space in output

            Console.WriteLine("===== APPENDED Reading FILE again =====");
            Console.WriteLine();  //space in output

            // ======= read file again
            try
            {
                // ======= USING StreamReader =======
                // read file using StreamReader
                // pass path/file name into StreamReader
                StreamReader sr = new StreamReader(projDir);
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
