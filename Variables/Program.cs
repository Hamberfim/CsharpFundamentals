using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console title
            Console.Title = "Variables";

            // declare and intializes variables
            char letter; letter = 'A';  // Declared then initialized
            int number; number = 100;  // Declared then initialized
            float body; body = 98.6f;  // Declared then initialized
            double pi; pi = 3.14159;  // Declared then initialized
            decimal sum; sum = 1000.00m;  // Declared then initialized
            bool flag = false;  // Declared and initialized
            string text = "C# is fun.";  // Declared and initialized


            // output variables to console
            Console.WriteLine("char letter:\t" + letter);
            Console.WriteLine("int number:\t" + number);
            Console.WriteLine("float body:\t" + body);
            Console.WriteLine("double pi:\t" + pi);
            Console.WriteLine("decimal sum:\t" + sum);
            Console.WriteLine("bool flag:\t" + flag);
            Console.WriteLine("string text:\t" + text);
            Console.ReadKey();


        }
    }
}
