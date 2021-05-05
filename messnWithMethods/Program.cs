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

        private static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        static void Main(string[] args)
        {
            decimal cust1Discount = GetDiscountPercent(499.99m);
            Console.WriteLine($"Customer Discount on 499.99: {cust1Discount:P1}");
            decimal cust2Discount = GetDiscountPercent(509.99m);
            Console.WriteLine($"Customer Discount on 509.99: {cust2Discount:P1}");
            Console.WriteLine();


            decimal monthlyInvestment = 100.00m;
            decimal monthlyInterestRate = .02m;
            int months = 12;
            decimal yourFutureValue1 = CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
            Console.WriteLine($"Your monthly investment of {monthlyInvestment:C} at {monthlyInterestRate:P1} for {months} months will have a futre value of {yourFutureValue1:C}");

            Console.WriteLine("\n\n");
        }
    }
}
