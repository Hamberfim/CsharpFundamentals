using System;

namespace debugStepInto
{
    class Program
    {
        static int square(int number)
        {
            return number * number;
        }
        static void Main(string[] args)
        {
            int pass = 0;
            int unit = 2;

            for (int i = 1; i < 8; i++)
            {
                pass = pass + 1;
                unit = square(unit);

                if (unit == 0)
                {
                    Console.WriteLine($"Pass: {pass}, Int Unit squared surpassed data type size limit, int value is {unit}");
                }
                else
                {
                    Console.WriteLine($"Pass: {pass}, Int Unit squared = {unit}");
                }
                
            }


            Console.WriteLine("\n\n");
        }
    }
}
