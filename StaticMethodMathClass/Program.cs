using System;
using System.Linq;

namespace StaticMethodMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Five Static methods of the Math Class";

            double myDecimal1 = 23.745;
            double myDecimal2 = 23.75;
            double myDecimal3 = 23.85;
            // Math.Round(decimalNumber[, precision[, mode]])
            // Math.Round(23.745, 2, MidpointRounding.AwayFromZero);
            double myDouble = Math.Round(myDecimal1, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{myDecimal1} using midpoint rounding is {myDouble}");


            // Math.Round(23.745, 2);  // uses default banker's rounding if ending in 5 rounds to the even number
            myDouble = Math.Round(23.745, 2);
            Console.WriteLine($"{myDecimal1} using banker's rounding is {myDouble} if it ends in 5 it rounds to the even number.");  //  uses default banker's rounding - if ending in 5 rounds to the even number

            Console.WriteLine();

            double myDouble2 = Math.Round(myDecimal2, 1);
            double myDouble3 = Math.Round(myDecimal3, 1);
            Console.WriteLine($"Using banker's rounding to one decimal place {myDecimal2} becomes {myDouble2} and {myDecimal3} becomes {myDouble3}");
            Console.WriteLine("Because if the ending number is 5 banker's rounding rounds to the even number");

            // Math.Pow(number, power)
            int myInt = 5;
            double myPower = Math.Pow(myInt, 2);
            Console.WriteLine($"Math.Pow(5, 2) is {myPower}");

            // Math.Sqrt()
            double mySqrt = Math.Sqrt(myInt);
            Console.WriteLine($"Math.Sqrt(5) is {mySqrt}");

            // Math.Min(num1, num2) | Math.Max(num1, num2)
            int num1 = 125;
            int num2 = 168;
            int num3 = 34;
            int num4 = 99;

            Console.WriteLine($"Math.Min(125, 168): {Math.Min(num1, num2)}");
            Console.WriteLine($"Math.Max(99, 34): {Math.Max(num4, num3)}");

            // .Min() | .Max() -- using System.Linq;
            int[] numArr = {num1, num2, num3, num4};
            Console.WriteLine($"Assume an Array called 'numArr' containing {{{num1}, {num2}, {num3}, {num4}}}");
            Console.WriteLine($" numArr.Min() is {numArr.Min()}");
            Console.WriteLine($" numArr.Max() is {numArr.Max()}");

            Console.WriteLine("\n\n");
        }
    }
}
