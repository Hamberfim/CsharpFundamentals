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
                int userQtyNull = userQty.GetValueOrDefault();
                double totalSaleNull = totalSale.GetValueOrDefault();
                Console.WriteLine(($"You have chosen {userQtyNull} widgets @ {pricePerUnit:C2} per item for a total of {totalSaleNull:c2}"));
            }

            Console.WriteLine();
            if (userQty.HasValue)
            {
                int qty = userQty.Value;
                Console.WriteLine($"User Quantity not null: {qty}");
            }
            else
            {
                int qty = userQty ??= -1;
                Console.WriteLine($"User Quantity null: {qty}");
            }

            Console.WriteLine("\n\n");
        }
    }
}
