using System;

namespace ternaryConditional
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // ternary via method and formating
            string getClubFee(bool isClubMember)
            {
                return isClubMember ? "0.25" : "0.10";
            }
            Console.WriteLine($"Club Memeber discounts are {Convert.ToDecimal(getClubFee(true)):p0}");
            Console.WriteLine($"Non-Club Member discounts are {Convert.ToDecimal(getClubFee(false)):p0}");
            Console.WriteLine();  // space

            // more ternary and formating
            decimal subtotalSale = 200.01m;
            string subtotalDiscount = subtotalSale > 200 ? "0.25" : "0.10";
            decimal discount = Convert.ToDecimal(subtotalDiscount);
            Console.WriteLine($"Your order of {subtotalSale:C2} will be discounted by {discount:p0}");
            Console.WriteLine();  // space

            // ternary and formating in console output
            decimal myOrderAmount = 189.99m;
            Console.WriteLine($"Orders below $200 recieve a discount of {Decimal.Parse(myOrderAmount > 200 ? "0.25" : "0.10"):p0}");
            Console.WriteLine();  // space

            // ternary via method and formating
            string getDiscount(decimal subtotalSale)
            {
                return subtotalSale > 200 ? "0.25" : "0.10";
            }
            decimal firstOrder = Convert.ToDecimal(getDiscount(175.48m));
            Console.WriteLine($"Your discount will be {firstOrder:p0}");
            decimal secondOrder = Convert.ToDecimal(getDiscount(226.99m));
            Console.WriteLine($"Your discount will be {secondOrder:p0}");
            Console.WriteLine();  // space

            // ternary via method and formating in console output
            Console.WriteLine($"Your order over $200 qualifies you for a discount of {Decimal.Parse(getDiscount(202.10m)):p0}");

            Console.WriteLine("\n\n");
        }
    }
}
