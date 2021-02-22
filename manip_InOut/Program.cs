/***************************************************************
* Name        : manip_InOut
* Author      : Anthony Hamlin
* Created     : 02/22/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Manipulate Input and Output      
***************************************************************/
using System;
using System.IO;

namespace manip_InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // Get project dir up 3 levels
            path = $"{path}\\TopFive.csv";
            Console.WriteLine(path);

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.IndexOf("Rank") != -1) line = line.ToUpper();
                        if (line.IndexOf("Sia") != -1) line += " *ft.Sean Paul";

                        string[] sub = line.Split(",");
                        line = String.Format("{0,-30}{1,-20}", sub[1], sub[2]);  // manipulate padding
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine();  // space


            Console.WriteLine("\n\n\n");
        }
    }
}
