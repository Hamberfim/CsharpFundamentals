using System;

namespace messnWithMethods
{
    class Program
    {
        private static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else
            {
                discountPercent = .1m;
            }

            return discountPercent;
        }

        // method parameters with default values
        private static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate = 0.02m, int months = 12)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        // single statement method
        private static void DisplayMessageOne(string message, string caption)
        {
            Console.WriteLine(message + ", " + caption);
        }
        // expression-bodied methods
        private static void DisplayMessageTwo(string message, string caption) => Console.WriteLine(message + ", " + caption);

        // single statement method
        private static decimal GetCustTypeDiscountOne(string customerType)
        {
            customerType = customerType.ToUpper();
            return customerType switch
            {
                "R" => 0.15m,
                "C" => 0.2m,
                "T" => 0.25m,
                _ => 0.1m // default
            };
        }
        // expression-bodied methods
        private static decimal GetCustTypeDiscountTwo(string customerType) => 
            customerType switch
            {
                "R" => 0.15m,
                "C" => 0.2m,
                "T" => 0.25m,
                _ => 0.1m // default
            };

        // refactor created a new method
        private static void GetSum()
        {
            int mySum = 0;
            for (int i = 0; i < 10; i++)
            {
                mySum = mySum + i;
            }
            Console.WriteLine($"my sum of 0-9: {mySum}");
        }

        // method by ref and value
        private static void CalFutValueRef(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            // no return value because the ref variable in the calling method is changed
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
            // method parameter arguments match methods listed order 
            decimal yourFutureValue1 = CalculateFutureValue(monthlyInvestment1, monthlyInterestRate1, months);
            Console.WriteLine($"Your monthly investment of {monthlyInvestment1:C} at {monthlyInterestRate1:P1} for {months} months will have a future value of {yourFutureValue1:C}");
            decimal yourFutureValue2 = CalculateFutureValue(monthlyInvestment1);
            Console.WriteLine($"Your monthly investment of {monthlyInvestment1:C} at 2% over 12 months will have a future value of {yourFutureValue2:C}");
            Console.WriteLine();

            // passing arguments by name C# 7.2 and up
            decimal investment = 125.00m;
            decimal rate = 0.034m;
            int lengthM = 10;
            // note that the order does not match the methods' parameter list order (<parameter name>:<argument name>)
            decimal nameArgResult = CalculateFutureValue(months: lengthM, monthlyInterestRate: rate, monthlyInvestment:investment);
            Console.WriteLine($"Your investment of {investment} at {rate:P1} over {lengthM} months will result in a value of {nameArgResult:C}");
            Console.WriteLine();

            // single statement method
            // private static void DisplayMessageOne(string message, string caption)
            // {
            //     Console.WriteLine(message, caption);
            // }
            DisplayMessageOne("Message One", "Caption One");
            // expression-bodied method
            // private static void DisplayMessageTwo(string message, string caption) => Console.WriteLine(message, caption);
            DisplayMessageTwo("Message Two", "Caption Two");
            Console.WriteLine();

            decimal custDiscOne = GetCustTypeDiscountOne("C");
            Console.WriteLine($"Customer type C discount: {custDiscOne:p1}");
            decimal custDiscTwo = GetCustTypeDiscountTwo("T");
            Console.WriteLine($"Customer type T discount: {custDiscTwo:p1}");
            decimal custDiscNonType = GetCustTypeDiscountTwo("");
            Console.WriteLine($"Customer type NONE discount: {custDiscNonType:p1}");
            Console.WriteLine();

            // refactor to create a new method
            //int mySum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    mySum = mySum + i;
            //}
            //Console.WriteLine($"my sum of 0-9: {mySum}");
            GetSum();
            Console.WriteLine();

            // ref/value
            decimal mInvest = 140.00m;
            decimal mInterest = 0.034m;
            int mLenght = 13;
            decimal futureValue = 0m;
            // futureValue variable- the method has no 'return value' because the ref variable in the calling method is changed when called
            CalFutValueRef(mInvest, mInterest, mLenght, futureValue: ref futureValue);
            Console.WriteLine($"Investment Amount: {mInvest:C}, Interest Rate: {mInterest:P1}, Number of months: {mLenght}, Future Value: {futureValue:C}");

            Console.WriteLine("\n\n");
        }
    }
}
