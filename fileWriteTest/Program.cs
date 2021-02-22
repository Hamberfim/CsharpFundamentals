/***************************************************************
* Name        : fileWriteTest
* Author      : Anthony Hamlin
* Created     : 02/19/2021
* Modified    : 02/22/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
*               
* Description : Write a file - using File.WriteAllText()
*               Append/Then Read a file - using File.AppendAllText(), File.ReadAllText()
***************************************************************/
using System;
using System.IO;

namespace fileWriteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Write, Read, Append File Test";

            // string dir_path = Path.Combine(Environment.CurrentDirectory);
            // Console.WriteLine($"The current Environment Directory is {dir_path}");  // When ran path is '...\<current project directory>\bin\Debug\netcoreapp3.1'
            string path = Directory.GetCurrentDirectory();
            // Console.WriteLine($"Current directory is {path}");  // I wan to use a relative path to the project directory - this directory/control may not be correct if the app was deployed
            // Write to Project directory - up three directories (NOTE: 'Path' is not the same as 'path')
            string projDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // each call gets its parent directory - up one level
            // Console.WriteLine($"Project directory is {projDir}");  // write/read file at this directory
            Console.WriteLine();  //space in output

            // Project directory path plus file name
            projDir = $"{projDir}\\FWTest.txt";
            Console.WriteLine($"File Write Path is {projDir}");

            string phrase1 = "\t'The Ballad of Reading Gaol'";  // carrage return, new line, tab
            phrase1 += "\r\n\tI never saw a man who looked";
            phrase1 += "\r\n\twith such a wistful eye";
            phrase1 += "\r\n\tupon that little text of blue";
            phrase1 += "\r\n\twhich prisoners call the sky";
            phrase1 += "\r\n\tAnd at every drifting cloud that went";
            phrase1 += "\r\n\tWith sails of silver by.";
            phrase1 += "\r\n\t\t~Oscar Wilde";


            // File.WriteAllText - check if text file exists
            if (File.Exists(projDir))
            {
                Console.WriteLine($"File Already Exists at {projDir}");
            }
            else
            {
                // write text file
                try
                {
                    File.WriteAllText(projDir, phrase1);
                    Console.WriteLine($"File written to: {projDir}");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Console.WriteLine("^^^ 'File.WriteAllText' attempt completed ^^^");
            Console.WriteLine();  // space

            // File.ReadAllText - check if text file exists
            if (File.Exists(projDir))
            {
                try
                {
                    Console.WriteLine("===== Reading FWTest.txt FILE =====");
                    // one of two ways to read/display output to console (1)
                    string text = File.ReadAllText(projDir);  // new lines and tabs are preserved when read by ReadAllText()
                    Console.WriteLine($"File Read: {projDir}\n");
                    Console.WriteLine($"{text}\n");
                    Console.WriteLine();  // space
                    // two of two ways to read/display output to console (2)
                    string[] lines = File.ReadAllLines(projDir);  // ONLY tab is preserved when read by ReadAllLine()
                    int num = 1;
                    foreach(string line in lines)
                    {
                        Console.WriteLine($"{num}: {line} ");
                        num++;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                Console.WriteLine($"File Not Found at {projDir}");
            }
            Console.WriteLine();  // space


            // File.AppendAllTest - check if text file exists
            string[] phrase2 = new string[]
            {
                "\tln Debtors' Yard the stones are hard",
                "\tAnd the dripping wall is high"
            };
            string attrib = "\r\n\tmore from 'The Ballad of Reading Gaol'";
            attrib += "\t\t(Oscar Wilde - 1898)";
            if(File.Exists(projDir))
            {

                File.AppendAllText(projDir, attrib);
                Console.WriteLine($"Appended To File at {projDir}");
            }
            else
            {
                Console.WriteLine($"File Not Found at {projDir}");
            }
            Console.WriteLine();  // space


            // File.ReadAllText - check if text file exists
            if (File.Exists(projDir))
            {
                try
                {
                    Console.WriteLine("===== Reading FWTest.txt FILE AFTER APPEND ====");
                    // one of two ways to read/display output to console (1)
                    string text = File.ReadAllText(projDir);  // new lines and tabs are preserved when read by ReadAllText()
                    Console.WriteLine($"File Read: {projDir}\n");
                    Console.WriteLine($"{text}\n");
                    Console.WriteLine();  // space
                    // two of two ways to read/display output to console (2)
                    string[] lines = File.ReadAllLines(projDir);  // ONLY tab is preserved when read by ReadAllLine()
                    int num = 1;
                    foreach(string line in lines)
                    {
                        Console.WriteLine($"{num}: {line} ");
                        num++;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                Console.WriteLine($"File Not Found at {projDir}");
            }
            Console.WriteLine();  // space

            Console.WriteLine("\n\n\n");
        }
    }
}
