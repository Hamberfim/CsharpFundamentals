using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arrays";

            // a single array
            string[] cars = new string[3] { "BMW", "Ford", "Opel" };

            // a 2-dimentional array
            int[,] co_ords = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("First car is (index zero): " + cars[0]);
            Console.WriteLine("Second car is (index one): " + cars[1]);
            Console.WriteLine("Third car is (index two): " + cars[2]);

            Console.WriteLine("X0, Y0: " + co_ords[0, 0]);
            Console.WriteLine("X1, Y0: " + co_ords[1, 0]);
            Console.WriteLine("X0, Y1: " + co_ords[0, 1]);
            Console.WriteLine("X1, Y1: " + co_ords[1, 1]);
            Console.WriteLine("X0, Y2: " + co_ords[0, 2]);
            Console.WriteLine("X1, Y2: " + co_ords[1, 2]);

            // a little more practice with arrays and type convertion
            Console.WriteLine();  // space in console output
            // I'm using this array like a row/column db
            string[,] products = new string[3, 5] { { "Products:", "BBQ Sauce", "Mustard", "Ketchup", "Mayonnaise" }, { "Stock Qty:", "5", "10", "1", "2" }, { "Price:", "2.38", "1.09", "2.10", "1.99" } };
            Console.WriteLine(products[0, 0] + " \t" + products[1, 0] + " \t" + products[2, 0] +" ");
            Console.WriteLine(products[0, 1] + " \t" + products[1, 1] + " \t\t" + products[2, 1] + " ");
            Console.WriteLine(products[0, 2] + " \t" + products[1, 2] + " \t\t" + products[2, 2] + " ");
            Console.WriteLine(products[0, 3] + " \t" + products[1, 3] + " \t\t" + products[2, 3] + " ");
            Console.WriteLine(products[0, 4] + " \t" + products[1, 4] + " \t\t" + products[2, 4] + " ");

            Console.WriteLine();  // space
            Console.WriteLine("products[2, 1]: " + products[2, 1] + ", is a " + products[2, 1].GetType());
            Console.WriteLine();  // space
            // convert qty/price System.string types to double for a total value of all products
            double prod21 = Convert.ToDouble(products[2, 1]);
            double prod22 = Convert.ToDouble(products[2, 2]);
            double prod23 = Convert.ToDouble(products[2, 3]);
            double prod24 = Convert.ToDouble(products[2, 4]);

            int qty11 = Convert.ToInt32(products[1, 1]);
            int qty12 = Convert.ToInt32(products[1, 2]);
            int qty13 = Convert.ToInt32(products[1, 3]);
            int qty14 = Convert.ToInt32(products[1, 4]);

            double sum = (prod21 * qty11) + (prod22 * qty12) + (prod23 * qty13) + (prod24 * qty14);
            sum = Math.Round(sum, 2);  // round to two decimals places
            Console.WriteLine($"Total in stock products value: ${prod21}(*{qty11}) + ${prod22}(*{qty12}) + ${prod23}(*{qty13}) + ${prod24}(*{qty14}) = ${sum}");


            Console.ReadKey();

        }
    }
}
