using System;

namespace castingMathRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = 85.45;
            int letterNum = 65;
            int num1 = 15, num2 = 9, num3 = 2;
            
            Console.WriteLine($"double {grade} cast to an int '(int)85' is: {(int)grade}");
            Console.WriteLine($"int {letterNum} cast to a char '(char)65' is: {(char)letterNum}");
            Console.WriteLine($"int {num1}, {num2}, {num3} cast to double and averaged '((double)15+9+2) / 3)' is: {((double)num1 + num2 + num3) / 3}");


            //  DivRem() Calculates the quotient of two numbers and also returns the remainder in an output parameter
            int result;
            int quotent = Math.DivRem(num1, num2, out result);
            Console.WriteLine($"Math.DivRem(15, 9, out result) result:{result}, quotent:{quotent}");
            Console.WriteLine();

            Random randnumber = new Random();
            int number = randnumber.Next(100, 151);  // .Next(MinValue, MaxValue - exclusive)
            Console.WriteLine($"Initial random number between 100 and 150: {number}");
            number = randnumber.Next(1, 11);  // .Next(inclusive, exclusive)
            Console.WriteLine($"Second random number between 1 and 10: {number}");
            number = randnumber.Next(51);  // .Next(MaxValue - exclusive)
            Console.WriteLine($"A random number less than 51: {number}");
            double dnumber = randnumber.NextDouble();
            Console.WriteLine($"A random double number between 0.0 and 0.9999: {dnumber}");
            dnumber = randnumber.NextDouble();
            Console.WriteLine($"Another random double number between 0.0 and 0.9999: {dnumber}");

            Console.WriteLine("===== Random Die Roll =====");
            int die1 = randnumber.Next(1, 7);
            Console.WriteLine($"Roll one: {die1}");
            int die2 = randnumber.Next(1, 7);
            Console.WriteLine($"Roll two: {die2}");
            int dietotal = die1 + die2;
            Console.WriteLine($"Total roll: {dietotal}, move your game piece ahead {dietotal} spaces.");

            // a verbatim string 
            string verbatimString = @"Press the   ""Space Bar""   or   ""X""   to exit program.";
            Console.WriteLine(verbatimString);

            Console.WriteLine("\n\n");
        }
    }
}
