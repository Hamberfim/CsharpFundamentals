using System;

namespace nullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int? userQty;
            userQty = null;

            double pricePerUnit = 1.99;

            double? totalSale;
            totalSale = null;

            Console.Write("Enter a quanity as a whole number: ");
            try
            {
                userQty = Convert.ToInt32(Console.ReadLine());
                if (userQty.HasValue)
                {
                    totalSale = pricePerUnit * userQty;
                    Console.WriteLine($"You have chosen {userQty} widgets @ {pricePerUnit:C2} per item for a total of {totalSale:C2}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"{error.Message}  !!! You didn't enter a quantity !!!");
                userQty = userQty.GetValueOrDefault();
                totalSale = totalSale.GetValueOrDefault();
                Console.WriteLine(($"You have chosen {userQty} widgets @ {pricePerUnit:C2} per item for a total of {totalSale:c2}"));
            }

            Console.WriteLine("\n\n");
        }
    }
}
