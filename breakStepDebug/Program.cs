/***************************************************************
* Name        : breakStepDebug
* Author      : Anthony Hamlin
* Created     : 02/26/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This has nested loops to see debuggin stepinto/stepover
*               It also tags the value 3 with an asterisk to further understand the loop logic      
***************************************************************/
using System;

namespace breakStepDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i, k, j;
            int pass = 1;

            // nested counter loops
            Console.WriteLine("'i' Loop Count \t\t'j' Loop Count \t\t'k' Loop Count \t\t'pass' Count");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            for (i = 1; i < 4; i++)
            {
                for (j = 1; j < 4; j++)
                {
                    for (k = 1; k < 4; k++)
                    {
                        // check to see if i, j, or k have a value of 3 - expecting 27 interations (3x3x3)
                        // i and k = 3
                        if ((i == 3) && (j != 3) && (k == 3))
                        {
                            Console.WriteLine($" {i}*     \t\t{j}    \t\t\t{k}*    \t\t\t{pass}");
                            pass++;
                        }

                        // j and k = 3
                        if ((i != 3) && (j == 3) && (k == 3))
                        {
                            Console.WriteLine($" {i}     \t\t\t{j}*    \t\t\t{k}*    \t\t\t{pass}");
                            pass++;
                        }

                        // i and j = 3
                        if ((i == 3) && (j == 3) && (k != 3))
                        {
                            Console.WriteLine($" {i}*     \t\t{j}*    \t\t\t{k}    \t\t\t{pass}");
                            pass++;
                        }

                        // k=3 value ONLY
                        if ((i != 3) && (j != 3) && (k == 3))
                        {
                            Console.WriteLine($" {i}     \t\t\t{j}    \t\t\t{k}*    \t\t\t{pass}");
                            pass++;
                        }

                        // j=3 value ONLY
                        if ((i != 3) && (j == 3) && (k != 3))
                        {
                            Console.WriteLine($" {i}     \t\t\t{j}*    \t\t\t{k}    \t\t\t{pass}");
                            pass++;
                        }

                        // i=3 value ONLY
                        if ((i == 3) && (j != 3) && (k != 3))
                        {
                            Console.WriteLine($" {i}*     \t\t{j}    \t\t\t{k}    \t\t\t{pass}");
                            pass++;
                        }

                        // all have 3 values
                        if ((k == 3) && (j == 3) && (i == 3))
                        {
                            Console.WriteLine($" {i}*     \t\t{j}*    \t\t\t{k}*    \t\t\t{pass}");
                            pass++;
                        }
                        
                        // No 3 values
                        if ((i != 3) && (j != 3) && (k != 3))
                        {
                            Console.WriteLine($" {i}     \t\t\t{j}    \t\t\t{k}    \t\t\t{pass}");
                            pass++;
                        }
                        
                    }
                }
            }

            Console.WriteLine("\n\n");
        }
    }
}
