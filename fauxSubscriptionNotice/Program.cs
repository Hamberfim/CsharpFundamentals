/***************************************************************
* Name        : fauxSubscriptionNotice
* Author      : Anthony Hamlin
* Created     : 03/31/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program generates a random number of days till a subscription expires 
*               and used logic to determin the notice and/or discount about a subscription renewal     
***************************************************************/
using System;

namespace fauxSubscriptionNotice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                // run this four times to see the random days generated and the reults
                Random rnd = new Random();

                int experationInDays = rnd.Next(12);
                decimal discountPercent = 0;

                if ((experationInDays > 5) && (experationInDays <= 10))
                {
                    Console.WriteLine($" Your subscription will expire in {experationInDays} days.  Renew now!");
                }
                else if ((experationInDays >= 2) && (experationInDays <= 5))
                {
                    discountPercent = 0.10m;
                    Console.WriteLine($" Your subscription expires in {experationInDays} days.\n Renew now and save {discountPercent:p0}!");
                }
                else if (experationInDays == 1)
                {
                    discountPercent = 0.20m;
                    Console.WriteLine($" Your subscription expires in {experationInDays} day.\n Renew now and save {discountPercent:p0}!");
                }
                else
                {
                    Console.WriteLine($" Your subscription has expired.");
                }

                Console.WriteLine();  // space in console output

            }
            Console.WriteLine("\n\n");
        }
    }
}
