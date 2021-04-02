/***************************************************************
* Name        : generateFauxOrderIDs
* Author      : Anthony Hamlin
* Created     : 04/02/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program Produces 10 random fauxOrderIDs 
*               with a random customer name from an array appended to the end 
*               and a transaction amount.
*               
*               fauxOrderIDs consist of a letter from A - F, 
*               a four digit number, 
*               a dash, 
*               another four digit number, 
*               a letter from U-Z 
*               another dash,
*               and a last name. Ex. B0347-0439Y-Garcia $147.58.        
***************************************************************/
using System;

namespace generateFauxOrderIDs
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate 10
            bool runAgain = true;
            while(runAgain)
            {
                Random rnd = new Random();

                string[] fauxOrderIDs = new string[10];
                string[] rndNames = {"Garcia", "Smith", "Carson", "Thompson", "Bartinelli",
                                "Schultz", "Lee", "Isenburger", "Kuaph", "Riggs",
                                "Fox", "Katz", "Driscoll", "Simmons", "Finch",
                                "Bayvens", "Turner", "Shaw", "Oliver", "Miller",
                                "Jones", "McDonald", "Peterson", "Horner", "Clark"};

                // populate fauxOrderIDs array
                for (int i = 0; i < fauxOrderIDs.Length; i++)
                {
                    int generateCharIntValue = rnd.Next(65, 71);
                    string letterPrefix = Convert.ToChar(generateCharIntValue).ToString();
                    string numericSuffix = rnd.Next(0, 1000).ToString("0000");

                    int generateCharIntValue2 = rnd.Next(85, 91);
                    string letterSuffix = Convert.ToChar(generateCharIntValue2).ToString();
                    string numberPrefix = rnd.Next(0, 1000).ToString("0000");

                    string trans = $"{(new Random().NextDouble() * rnd.Next(1, 2001)):####.00}";

                    int rndNameIndex = rnd.Next(0, 25);
                    fauxOrderIDs[i] = letterPrefix + numericSuffix + "-" + numberPrefix + letterSuffix + "-" + rndNames[rndNameIndex] + $" ${trans}";
                }

                foreach (var fauxOrderID in fauxOrderIDs)
                {
                    Console.WriteLine($" Order: {fauxOrderID}");
                }

                Console.WriteLine();  // space in console output
                Console.WriteLine("Run again? (Y)es or (N)o: ");
                string answer = Console.ReadLine().ToLower();
                if (answer.Contains("y"))
                {
                    runAgain = true;
                    Console.WriteLine();
                }
                else
                {
                    runAgain = false;
                    Console.WriteLine();
                }
   
            }

            Console.WriteLine("\n\n");
        }
    }
}
