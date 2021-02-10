using System;

namespace CastingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Casting data Types";

            double sum1 = 7 / 2;
            double sum2 = (double)7 / 2;
            double sum3 = (double)(7) / 2;
            double sum4 = (double)(7 / 2);

            Console.WriteLine("double sum1 = 7 / 2; " + sum1);
            Console.WriteLine("double sum2 = (double)7 / 2; " + sum2);
            Console.WriteLine("double sum3 = (double)(7) / 2; " + sum3);
            Console.WriteLine("double sum4 = (double)(7 / 2); " + sum4);

            double num;
            double dnum = 10.5;
            int integer = 2;

            Console.WriteLine($"Implicit cast. {dnum} + {integer} = " + (num = dnum + integer));
            Console.WriteLine($"Explicit cast. (double) 7 / {integer} = " + (num = (double) 7 / integer));

            char letter = (char)65;
            Console.WriteLine("Cast integer to char: " + letter);

            int ascii = (int)'A';
            Console.WriteLine("Cast letter to int: " + ascii);
        }
    }
}
