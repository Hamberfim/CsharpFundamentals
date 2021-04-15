using System;

namespace whileLoopsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DO - WHILE");
            Console.WriteLine("----------");
            Random rnd = new Random();
            int myCounter = 0;
            // while/do-while statements will loop through a block of code.
            // the logic inside of the code block will affect when the looping stops
            // i.e., Evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block
            do
            {
                // This code executes at least once
                myCounter = rnd.Next(0, 10);
                Console.WriteLine(myCounter);

                // stops if the random number is 5 -note 5 is printed
            } while (myCounter != 5);
            Console.WriteLine($"Last Random Number: {myCounter}");
            Console.WriteLine();


            // runs only if true
            Console.WriteLine("WHILE - ONLY IF TRUE");
            Console.WriteLine("--------------------");
            int anotherCounter = 0;
            // stops if the random number is 5 -note 5 is NOT printed
            while (anotherCounter != 5)
            {
                Console.WriteLine(anotherCounter);
                anotherCounter = rnd.Next(0, 10);
            }
            Console.WriteLine($"Last Random Number: {anotherCounter}");
            Console.WriteLine();


            Console.WriteLine("WHILE - ONLY IF TRUE - initial value is 0 so the code block will never execute");
            Console.WriteLine("------------------------------------------------------------------------------");
            int ifTrueValue = 0;
            // runs only if true
            while (ifTrueValue >= 3)
            {
                Console.WriteLine(ifTrueValue);
                ifTrueValue = rnd.Next(0, 10);
            }
            Console.WriteLine($"Last Random Number: {ifTrueValue}");
            Console.WriteLine();


            // do-while with a continue
            Console.WriteLine("DO-WHILE - Continue");
            Console.WriteLine("-------------------");
            int toContinueValue = rnd.Next(0, 10);
            do
            {
                toContinueValue = rnd.Next(1, 11);

                // the continue keyword step immediately down to the Boolean expression
                if (toContinueValue >= 6) 
                continue;  // if toContinueValue is greater or equal to 6 we skip the console.writeline
                Console.WriteLine(toContinueValue);  // a number greater than 5 will never print

            } while (toContinueValue != 5);
            Console.WriteLine($"Last Random Number: {toContinueValue}");

            Console.WriteLine("\n\n");
        }
    }
}
