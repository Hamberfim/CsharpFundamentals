/***************************************************************
* Name        : refactorRecursiveMethod
* Author      : Anthony Hamlin
* Created     : 02/08/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program generates a factorial and then refactors 
*               it a number of times based int num/max call to computeFactorials(num, max); 
***************************************************************/
using System;

namespace refactorRecursiveMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //output display
            static void computeFactorials(int num, int max)
            {
                while (num <= max)
                {
                    Console.WriteLine($"Factorial of {num} :{factorial(num)}");
                    num++;
                }
            }

            // return the factorial
            static int factorial(int num) 
            {
                int result;
                if(num == 1)
                {
                    result = 1;
                }
                else
                {
                    result = (factorial(num - 1) * num);
                }
                return result;

            }

            computeFactorials(1, 9);  // call 


            Console.WriteLine("\n\n\n");
        }
    }
}
