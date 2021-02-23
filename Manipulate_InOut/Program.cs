/***************************************************************
* Name        : Manipulate_InOut
* Author      : Anthony Hamlin
* Created     : 02/23/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program overall description here
*               Input:  list and describe
*               Output: list and describe        
***************************************************************/
using System;
using System.Globalization;
using System.IO;
using System.Linq;  // needed for 'Select'
using System.Text.RegularExpressions;

namespace Manipulate_InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FileInfo, Read CSV file";

            string path = Directory.GetCurrentDirectory();
            path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // up three levels
            Console.WriteLine(path);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.csv");  // get name of csv files
            Console.WriteLine();  //spacce

            // FileInfo[] files straight to an array
            string[] arrCSVFiles = files.Select(f => f.Name).ToArray();
            foreach (var name in arrCSVFiles)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Number of csv file: {arrCSVFiles.Length}");

            // each of the csv file shares header titles of "'Rank', 'Restaurant', 'Sales'" but not always in the same index order
            // using index 1 file = Top100IndependRestaurants.csv as it honors the order "'Rank' [0], 'Restaurant' [1], 'Sales' [2]"
            path = $"{path}\\{arrCSVFiles[1]}";
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
                        if (line.IndexOf("Rank") != -1) line = line.ToUpper();  // zero index
                        if (line.IndexOf("Restaurant") != -1) line = line.ToUpper();  // one index
                        if (line.IndexOf("Sales") != -1) line = line.ToUpper();  // two index
                        if (line.IndexOf("City") != -1) line = line.ToUpper();  // four index
                        if (line.IndexOf("State") != -1) line = line.ToUpper();  // five index

                        string[] sub = line.Split(",");

                        // Convert sales string to currency 
                        if(Regex.IsMatch(sub[2], @"^\d+$"))
                        {
                            sub[2] = string.Format("{0:C2}", Convert.ToDecimal(sub[2]));
                        }

                        line = String.Format("{0,-9}{1,-43}{2,-20}{3,-12}{4,-16}", sub[0], sub[1], sub[4], sub[5], sub[2]);  // manipulate padding
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
