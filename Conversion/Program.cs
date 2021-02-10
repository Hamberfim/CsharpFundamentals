using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Convertions - Casting data types";

            // user input is a string
            Console.Write("Please enter a number: ");
            // user input is converted to a double
            double num = Convert.ToDouble(Console.ReadLine());
            // user input is a string
            Console.Write("Please enter another number: ");
            // user input is converted to a double, added to the previous input
            double sum = num + Convert.ToDouble(Console.ReadLine());
            // output sum
            Console.WriteLine("Total of your two numbers is: " + sum);
            Console.ReadKey();

        }
    }
}
