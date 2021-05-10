using System;

namespace tuplesAgainAgain
{
    class Program
    {

        static void Main(string[] args)
        {
            // un-named tuple - data type is inferred
            var business = ("Tony's Pizza", "218 E Lincolnway", "Valparaiso, IN", 46383);
            // reference tuple members by auto 'Item#'
            var bName = business.Item1;
            var bAddress = business.Item2;
            var bCityState = business.Item3;
            var bZip = business.Item4;
            Console.WriteLine($"{bName} of {bCityState}, {bZip}");
            Console.WriteLine();

            // named (synonyms) tuple  - data type is inferred
            var businessOwner = (Name:"Anthony Caraprese", Age:55, Location:"Valparaiso, IN");
            // reference tuple members by Declared Name
            Console.WriteLine($"{businessOwner.Name}, age {businessOwner.Age} of {businessOwner.Location}");
            Console.WriteLine();

            // variable name tuples - data type is declared via variable
            string name = "Michelle Caraprese";
            int age = 52;
            string loc = "Valparaiso, IN";
            var coOwner = (name, age, loc);
            // reference tuple members by declared variable name
            Console.WriteLine($"{coOwner.name} age {coOwner.age} of {coOwner.loc}");
            Console.WriteLine();

            // use a tuple as a return type
            (decimal FutureValue, decimal TotalInterest) = CalcFutureValue(125.00m, 0.023m, 12);
            // reference the FutureValue & TotalInterest tuple members
            Console.WriteLine($"Total interest of {TotalInterest:C} paid on monthly investment, for a future value of {FutureValue:C}");
            // or as string varables
            string FutureValueTxt = FutureValue.ToString("C");
            string TotalInterestTxt = TotalInterest.ToString("C");
            Console.WriteLine();

            // call the method and assign the methods return to a varable
            var calculate = CalcFutureValue(150.00m, 0.023m, 12);
            // reference the FutureValue & TotalInterest tuple members
            Console.WriteLine($"Total interest paid out is {calculate.TotalInterest:C} making the future value {calculate.FutureValue:C}");
            // or as string varables
            string tInterestTxt = calculate.TotalInterest.ToString("C");
            string fValueTxt = calculate.FutureValue.ToString("C");
            Console.WriteLine();

            Console.WriteLine("\n\n");
        }

        // use a tuple as a return type
        private static (decimal FutureValue, decimal TotalInterest) CalcFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            decimal totalInterest = 0m;
            decimal monthlyInterest = 0m;

            for (int i = 0; i < months; i++)
            {
                monthlyInterest = (futureValue + monthlyInvestment) * monthlyInterestRate;
                totalInterest += monthlyInterest;
                futureValue += monthlyInvestment + monthlyInterest;
            }

            return (futureValue, totalInterest);
        }


    }
}
