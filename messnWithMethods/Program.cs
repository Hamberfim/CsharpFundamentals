using System;

namespace messnWithMethods
{
    class Program
    {
        private static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if(subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else
            {
                discountPercent = .1m;
            }

            return discountPercent;
        }

        private static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate = 0.02m, int months = 12)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue ;
        }

        static void Main(string[] args)
        {
            decimal cust1Discount = GetDiscountPercent(499.99m);
            Console.WriteLine($"Customer Discount on 499.99: {cust1Discount:P1}");
            decimal cust2Discount = GetDiscountPercent(509.99m);
            Console.WriteLine($"Customer Discount on 509.99: {cust2Discount:P1}");
            Console.WriteLine();


            decimal monthlyInvestment1 = 100.00m;
            decimal monthlyInterestRate1 = .04m;
            int months = 12;
            decimal yourFutureValue1 = CalculateFutureValue(monthlyInvestment1, monthlyInterestRate1, months);
            Console.WriteLine($"Your monthly investment of {monthlyInvestment1:C} at {monthlyInterestRate1:P1} for {months} months will have a future value of {yourFutureValue1:C}");
            decimal yourFutureValue2 = CalculateFutureValue(monthlyInvestment1);
            Console.WriteLine($"Your monthly investment of {monthlyInvestment1:C} at 2% over 12 months will have a future value of {yourFutureValue2:C}");
            Console.WriteLine();

            // passing arguments by name C# 7.2 and up
            decimal investment = 125.00m;
            decimal rate = 0.034m;
            int lengthM = 10;
            // note that the order does not match the methods' parameter list order
            decimal nameArgResult = CalculateFutureValue(months: lengthM, monthlyInterestRate: rate, monthlyInvestment:investment);
            Console.WriteLine($"Your investment of {investment} at {rate:P1} over {lengthM} months will result in a value of {nameArgResult:C}");

            Console.WriteLine("\n\n");
        }
    }
}
