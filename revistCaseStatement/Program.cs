using System;

namespace revistCaseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic switch statement
            int subscriptionLevel;
            decimal discountPercent;

            Console.WriteLine("Enter your subscription level number(example: 1, 2, 3, etc.) ");
            string level = Console.ReadLine();
            try
            {
                subscriptionLevel = Convert.ToInt32(level);

                switch (subscriptionLevel)
                {
                    case 1:
                        discountPercent = 0.15m;
                        break;
                    case 2:
                        discountPercent = 0.25m;
                        break;
                    case 3:
                        discountPercent = 0.30m;
                        break;
                    default:
                        discountPercent = 0.1m;
                        break;
                }

                Console.WriteLine($"Your discount is {discountPercent:p0}");

            }
            catch (Exception error)
            {
                Console.WriteLine($"{error} Input must be a whole number");
            }

            Console.WriteLine();

            // switch expresssion using a lambda operator (=>) with a discard to catch all other input
            char subscriptionType;
            decimal discountAmount;

            Console.WriteLine("Enter your subscription type (B)ronze, (S)ilver, (G)old: ");
            string subType = Console.ReadLine();

            try
            {
                subType = subType.ToLower();  // lower case string
                subscriptionType = subType[0];  // get first character as a char

                discountAmount = subscriptionType switch
                {
                    // match char
                    'b' => 0.15m, 
                    's' => 0.25m,
                    'g' => 0.30m,
                    _ => 0.10m  // all others...discard
                };

                Console.WriteLine($"Your discount amount is {discountAmount:p0}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"{error} Input must be (B)ronze, (S)ilver, (G)old");
            }

            Console.WriteLine();

            // switch that calculates discount with relational operators and a lambda operator  | C# 9.0 & later
            decimal subTotal;
            decimal discount;

            Console.WriteLine("Enter the subtotal: ");
            string userSubTotal = Console.ReadLine();

            try
            {
                subTotal = Convert.ToDecimal(userSubTotal);
                discount = subTotal switch
                {
                    // relation          lambda (=>)
                    <= 0.0m => subTotal * 0.0m,
                    > 0.0m and < 50.0m => subTotal * 0.10m,
                    >= 50.0m and <= 200.0m => subTotal * 0.15m,
                    > 200.0m and <= 300.0m => subTotal * 0.20m,
                    > 300.0m => subTotal * 0.25m
                };

                Console.WriteLine($"Your subtotal of {subTotal:C2} with discount of {discount:C2} is {(subTotal - discount):C2}");

            }
            catch (Exception error)
            {
                Console.WriteLine($"{error} Input must be a numerical subtotal in decimal format.");
            }

            Console.WriteLine("\n\n");
        }
    }
}
