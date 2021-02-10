using System;
using System.Threading;

namespace BranchLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Initializing calculations...");

            int sum = 0;

            for (int i = 1; i < 51; i++)
            {
                if (i % 3 == 0) {
                    Thread.Sleep(120);  // mimic thinking
                    Console.WriteLine("\t" + i + " is divisible by 3 with no remainder.");
                    sum = sum + i;
                    
                }
                else
                {
                    Thread.Sleep(120);  // mimic thinking
                    Console.WriteLine($"\t\tskipping {i}...");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of all numbers divisible by 3 with no remainder is {sum}.");
            Console.WriteLine("\n\n\n");
        }
    }
}