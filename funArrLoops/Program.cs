using System;
using System.Collections.Generic;

namespace funArrLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArr = { "Billy", "Susan", "Alex", "Eddie", "Kathy", "David", "Kelly", "Michael", "Anthony", "Shelly" };
            string[] namesOne = new string[namesArr.Length / 2];
            string[] namesTwo = new string[namesArr.Length / 2];

            int k = 0;  // namesOne index positions
            int j = 0; // namesTwo index positions

            Console.WriteLine("Array names:");
            for (int i = 0; i < namesArr.Length; i++)
            {
                Console.WriteLine($"{i}, {namesArr[i]}");
                if (i % 2 == 0)
                {
                    namesOne[k++] = namesArr[i];
                }
                else 
                {
                    namesTwo[j++] = namesArr[i];
                }
                
            }
            Console.WriteLine();

            int idx1 = 0;
            int idx2 = 1;
            Console.WriteLine("Even index names:");
            foreach (var name in namesOne)
            {
                Console.WriteLine($"{idx1}, {name}");
                idx1 = idx1 + 2;
            }
            Console.WriteLine();

            Console.WriteLine("Odd index names:");
            foreach (var name in namesTwo)
            {
                Console.WriteLine($"{idx2}, {name}");
                idx2 = idx2 + 2;
            }

            Console.WriteLine();
            Console.WriteLine("Reverse order Array names:");
            for (int i = namesArr.Length -1; i >= 0; i--)
            {
                Console.WriteLine($"{i}, {namesArr[i]}");
            }
            


            Console.WriteLine("\n\n");
        }
    }
}
