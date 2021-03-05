using System;

namespace xunitSimpleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("===== TESTING - Square Root =====");
                Console.Write("Enter a whole number (or a text string to force error): ");
                int userNumber2 = (int)Convert.ToInt64(Console.ReadLine());
                double sqrRoot2 = Math.Sqrt(userNumber2);
                Console.WriteLine($"The square root of {userNumber2} is {sqrRoot2:.####}");
            }
            catch (FormatException error)
            {
                Console.WriteLine($"{error.Message}!\nUser input was not a whole number.");
            }


            Console.WriteLine("\n\n");
        }
    }
}
