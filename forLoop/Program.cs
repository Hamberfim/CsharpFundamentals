using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Loop";

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Loop iteration: {i}.");

                // nested loop
                for(int j = 1; j < 4; j++)
                {
                    Console.WriteLine($"\tInner Loop Interation: {i}.{j} ");
                };
            };

            Console.ReadKey();
        }
    }
}
