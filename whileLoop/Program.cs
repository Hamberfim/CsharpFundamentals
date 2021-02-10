using System;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "While Loop";

            // an array of ints
            int[] nums = new int[10];
            int i = 0;


            Console.WriteLine(nums.Length);
            // while loop
            while(i < nums.Length)
            {
                nums[i] = i;
                Console.Write(" | " + nums[i]);
                i++;
            }


            Console.WriteLine();  // space
            // do while loop
            do
            {
                // reverse order
                i--;

                if (i == 8)
                {
                    Console.Write(" | Skipped");
                    continue;
                }

                if (i == 3)
                {
                    Console.Write(" | Done");
                    break;
                }

                Console.Write(" | " + nums[i]);
            }
            while (i > 0);

            Console.ReadKey();
        }
    }
}
