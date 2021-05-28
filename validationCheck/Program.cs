using System;
using System.Globalization;

namespace validationCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // TryParse bool
            Console.Write("Enter a number: ");
            string strNumber = Console.ReadLine();
            if(int.TryParse(strNumber, out int intNumber))
            {
                Console.WriteLine($"{intNumber} is an int");
            }
            else if(decimal.TryParse(strNumber, out decimal decNumber))
            {
                Console.WriteLine($"{decNumber} is an decimal");
            }
            else
            {
                Console.WriteLine($"{strNumber} input is not a number");
            }

            // TryParseExact
            Console.Write("Enter a date/time (M/d/yyy hh:mm): ");
            string strDateTime = Console.ReadLine();
            if(!DateTime.TryParseExact(strDateTime, "M/d/yyyy HH:mm", new CultureInfo("en-US"), DateTimeStyles.None, out DateTime dateTime))
            {
                dateTime = DateTime.Now;
                Console.WriteLine($"{dateTime} is the current date/time.");
            }
            else
            {
                Console.WriteLine($"Your {strDateTime} is in the correct format.");
            }

            // which keyboard character was pressed
            ConsoleKeyInfo key = Console.ReadKey();
            string pressedKey = key.Key.ToString().Substring(1);  // work with letter but not much else
            Console.WriteLine($" {pressedKey} was pressed.");

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
