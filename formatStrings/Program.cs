/***************************************************************
* Name        : formatStrings
* Author      : Anthony Hamlin
* Created     : 02/17/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : ToString formating, formate specifiers, Plus other ways      
***************************************************************/
using System;

namespace formatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Formate Strings";
            // ways to format string output
            double numToFormat = 2500;

            // formate specifiers - GENERAL
            Console.WriteLine($"double with GENERAL specifier to String " + numToFormat.ToString("G"));
            Console.WriteLine($"Formate another way {numToFormat:G}");
            Console.WriteLine(String.Format("And another {0:G}", numToFormat));
            Console.WriteLine();  // space

            // formate specifiers - FIXED POINT
            Console.WriteLine($"double with FIXED POINT specifier to String " + numToFormat.ToString("F"));
            Console.WriteLine($"Formate another way {numToFormat:F}");
            Console.WriteLine(String.Format("And another {0:F}", numToFormat));
            Console.WriteLine();  // space

            // formate specifiers - NUMBER with Comma-seperated thousands
            Console.WriteLine($"double with NUMBER specifier to String " + numToFormat.ToString("N"));
            Console.WriteLine($"Formate another way {numToFormat:N}");
            Console.WriteLine(String.Format("And another {0:N}", numToFormat));
            Console.WriteLine();  // space

            // formate specifiers - CURRENCY
            Console.WriteLine($"double with CURRENCY specifier to String " + numToFormat.ToString("C"));
            Console.WriteLine($"Formate another way {numToFormat:C}");
            Console.WriteLine(String.Format("And another {0:C}", numToFormat));
            Console.WriteLine();  // space

            numToFormat /= 1000;
            // formate specifiers - PERCENTAGE
            Console.WriteLine($"double with PERCENTAGE specifier to String " + numToFormat.ToString("P"));
            Console.WriteLine($"Formate another way {numToFormat:P}");
            Console.WriteLine(String.Format("And another {0:P}", numToFormat));
            Console.WriteLine();  // space

            double numToFormat2 = 1.50/.33;
            // formate specifiers - ZERRO PADDING
            Console.WriteLine($"double with ZERRO PADDING specifier to String " + numToFormat.ToString("00.0000") + ", " + numToFormat2.ToString("00.0000"));
            Console.WriteLine($"Formate another way {numToFormat:00.0000}, {numToFormat2:00.0000}");
            Console.WriteLine(String.Format("And another {0:00.0000}, {1:00.0000}", numToFormat, numToFormat2));  // {0:xx.xxxx}  0 = numToFormat & {1:xx.xxxx}  1 = numToFormat2
            Console.WriteLine();  // space

            // split a string of comma-seperated items
            string listOfNames = "Bill, Grindle, Ally";
            string[] names = listOfNames.Split(", ");
            foreach(string name in names)
            {
                Console.WriteLine(String.Format($"{name}"));
            }
            Console.WriteLine();  // space

            // a way to format
            string listOfcars = "FORD, FIAT, NISSAN";
            string[] cars = listOfcars.Split(", ");
            foreach (string car in cars)
            {
                Console.WriteLine(String.Format(car.ToString()));
            }
            Console.WriteLine();  // space

            // another way to format
            string listOfFoods = "Pizza, Tacos, BBQ";
            string[] foods = listOfFoods.Split(", ");
            foreach (string food in foods)
            {
                Console.WriteLine(String.Format("{0}", food));
            }
            Console.WriteLine();  // space


            Console.WriteLine("\n\n\n");
        }
    }
}
