using System;

namespace loopsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            // tracking the book examples
            const int MONTHS = 12;
            decimal monthlyInterestRate = 0.02m;

            int i = 1;
            decimal futureValuei = 0m;
            decimal monthlyInvestmenti = 100.00m;
            while (i <= MONTHS)
            {
                futureValuei = (futureValuei + monthlyInvestmenti) * (1 + monthlyInterestRate);
                i++;

            }
            Console.WriteLine($"Monthly Investment of {monthlyInvestmenti:C} @ {monthlyInterestRate:P1} 12M/Result: {futureValuei:C}");
            Console.WriteLine();

            int j = 1;
            decimal futureValuej = 0m;
            decimal monthlyInvestmentj = 150.00m;
            do
            {
                futureValuej = (futureValuej + monthlyInvestmentj) * (1 + monthlyInterestRate);
                j++;

            } while (j <= MONTHS);
            Console.WriteLine($"Monthly Investment of {monthlyInvestmentj:C} @ {monthlyInterestRate:P1} 12M/Result: {futureValuej:C}");
            Console.WriteLine();

            decimal futureValuek = 0m;
            decimal monthlyInvestmentk = 200.00m;
            for (int k = 1; k <= MONTHS; k++)
            {
                futureValuek = (futureValuek + monthlyInvestmentk) * (1 + monthlyInterestRate);
            }
            Console.WriteLine($"Monthly Investment of {monthlyInvestmentk:C} @ {monthlyInterestRate:P1} 12M/Result: {futureValuek:C}");
            Console.WriteLine();

            // break
            int x = 30;
            while (x >= 0)
            {
                if(x % 2 != 0)
                {
                    Console.WriteLine($"Odd: {x}");
                }
                if (x % 2 == 0)
                {
                    Console.WriteLine($"Even: {x}");
                }

                if((x <= 21) && (x % 2 == 0))
                {
                    Console.WriteLine("EVEN FOUND AT LESS THAN 21 - Break!");
                    break;
                }
                x--;
            }
            Console.WriteLine();

            // continue
            for (int y = 0; y <= 19; y++)
            {
                if (y == 4 || y == 8 || y == 12 || y == 16)
                {
                    Console.WriteLine("--SKIP");
                    continue;
                }
                else
                {
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine();


            Console.WriteLine("\n\n");
        }
    }
}
