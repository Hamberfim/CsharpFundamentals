using System;

namespace convertChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Split up the data depending on its type and either concatenate or add the data accordingly
            // Rule 1: If the value is alphanumeric, concatenate it to form a message
            // Rule 2: If the value is numeric, add it to the total
            // Rule 3: Make sure the result matches the following output:

            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            decimal sum = 0m;
            string message = "";

            foreach (var item in values)
            {
                decimal tempNumber;
                if (decimal.TryParse(item, out tempNumber))
                {
                    sum += tempNumber;
                }
                
                else
                {
                    message += item;
                }
            }
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine();

            // Second challenge
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            int result1 = value1 / (int)value2;  // 2 expected
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = value2 / (decimal)value3;  // 1.4418604651162790697674418605 expected
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = value3 / value1;  // 0.3583333 expected
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}"); 

            Console.WriteLine("\n\n");
        }
    }
}
