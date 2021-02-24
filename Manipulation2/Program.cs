/***************************************************************
* Name        : Manipulation2
* Author      : Anthony Hamlin
* Created     : 02/24/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Using StreamReader Manipulate the read input 
*               and utilize user selection   
***************************************************************/
using System;
using System.IO;
using System.Linq;  // needed for 'Select'
using System.Text.RegularExpressions;

namespace Manipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Manipulate Read Input";

            string path = Directory.GetCurrentDirectory();
            path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // up three levels
            path += "\\_db";  // directory where csv files are located with in the project directory
            Console.WriteLine(path);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.csv");  // get name of csv files
            
            Console.WriteLine();  //space

            // FileInfo[] files straight to an array
            string[] arrCSVFiles = files.Select(f => f.Name).ToArray();  // using Linq to 'Select'

            // get lenght of array
            int numberOfChoices = arrCSVFiles.Length;
            Console.WriteLine($"Number of csv files found: {numberOfChoices}");
            int counter = 1;
            foreach (var name in arrCSVFiles)
            {
                Console.WriteLine($"\t{counter}.) {name}");
                counter++;
            }
            // each of the above csv file shares header titles of "'Rank', 'Restaurant', 'Sales', 'City', 'State'" but what if they are not always in the same index order
            Console.WriteLine();  //space

            // Allow user to select which file to read
            Console.Write($"Enter your choice from the {numberOfChoices} csv file above: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            userChoice -= 1;  // adjust for zero index
            path = $"{path}\\{arrCSVFiles[userChoice]}";  // path to specific files  [0]=Future50.csv, [1]=Top100IndependRestaurants.csv, [2]=Top250.csv
            Console.WriteLine($"Reading {path}");
            Console.WriteLine();

            // read csv file 
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Header names to uper case
                        if (line.IndexOf("Rank") != -1) line = line.ToUpper();
                        if (line.IndexOf("Restaurant") != -1) line = line.ToUpper();
                        if (line.IndexOf("Sales") != -1) line = line.ToUpper();
                        if (line.IndexOf("City") != -1) line = line.ToUpper();
                        if (line.IndexOf("State") != -1) line = line.ToUpper();

                        string[] sub = line.Split(",");


                        // Convert sales string to currency 
                        if (Regex.IsMatch(sub[2], @"^\d+$"))
                        {
                            sub[2] = string.Format("{0:C2}", Convert.ToDecimal(sub[2]));
                        }

                        line = String.Format("{0,-9}{1,-43}{2,-20}{3,-15}{4,-16}", sub[0], sub[1], sub[2], sub[3], sub[4]);  // manipulate padding
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();
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
