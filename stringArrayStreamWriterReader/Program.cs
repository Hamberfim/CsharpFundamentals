/***************************************************************
* Name        : stringArrayStreamWriterReader
* Author      : Anthony Hamlin
* Created     : 02/22/2021 
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
*               
* Description : Write/Append/Read a file - using a string array,
*               StreamWriter and StreamReader
***************************************************************/
using System;
using System.IO;

namespace stringArrayStreamWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            // Console.WriteLine(path);
            path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));
            // Console.WriteLine(path);
            path = $"{path}\\DeepThoughtsFile.txt";
            // Console.WriteLine(path);

            string[] deepthought = new string[]
            {
                "\tIf you work on a lobster boat,",
                "\tsneaking up behind someone",
                "\tand pinching him is probably",
                "\ta joke that gets old real fast."
            };

            string attrib = "\r\n\tDeep Thoughts";
            attrib += "\r\n\t\t~ Jack Handey";


            // Write deapthoughts to a file
            try
            {
                using (StreamWriter sw  = new StreamWriter(path))
                {
                    foreach(string line in deepthought)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine($"Done! File can be found at:\n{path}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            // read deapthoughts
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine("\t===== Reading File =====");
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

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine();  //space in output


            // append deapthoughts
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(attrib);
                }
                Console.WriteLine();  //space in output
                Console.WriteLine($"File Appended: {path}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine();  //space in output


            // read Appedned deapthoughts
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine("\t===== Reading Appended File =====");
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

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
