﻿using System;

namespace dataPresentationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Make the output look like this:
            Dear Mr. Jones,
            As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

            Currently, you own 2,975,000.00 shares at a return of 12.75 %.

            Our new product, Glorious Future offers a return of 13.13 %.Given your current volume, your potential profit would be ¤63,000,000.00.

            Here's a quick comparison:

            Magic Yield         12.75 %   ¤55,000,000.00
            Glorious Future     13.13 %   ¤63,000,000.00 
            */

            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.\n");


            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            // Your logic here
            comparisonMessage += currentProduct.PadRight(20);
            comparisonMessage += $"{currentReturn:P2}".PadRight(10);
            comparisonMessage += $"{currentProfit:C2}\n";

            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += $"{newReturn:P2}".PadRight(10);
            comparisonMessage += $"{newProfit:C2}";

            Console.WriteLine(comparisonMessage);



            Console.WriteLine("\n");
        }
    }
}
