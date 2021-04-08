using System;

namespace fixCodeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* CODE TO FIX
             * 
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            foreach (int number in numbers)
            {
                int total;
                total += number;
                if (number == 42)
                {
                    bool found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("Set contains 42");
            }
            Console.WriteLine($"Total: {total}");
            
             */

            int[] numbers = { 4, 8, 15, 16, 23, 42 };

            int total = 0;
            foreach (int number in numbers)
            {
                if (number == 42)
                {
                    bool found = true;
                    if (found)
                    {
                        Console.WriteLine("Set contains 42");
                    }
                }
                total += number;
            }
            
            Console.WriteLine($"Total: {total}");



            Console.WriteLine("\n\n");
        }
    }
}
