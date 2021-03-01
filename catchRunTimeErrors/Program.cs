/***************************************************************
* Name        : catchRunTimeErrors
* Author      : Anthony Hamlin
* Created     : 03/01/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Catch Run Time Erorrs   
***************************************************************/
using System;

namespace catchRunTimeErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter another number: ");
                double num2 = Convert.ToInt16(Console.ReadLine());

                Console.Write("Total: " + (num1 + num2));
            }
            catch (OverflowException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Maximum value: " + Int16.MaxValue);
            }


            Console.WriteLine("\n\n");
        }
    }
}
