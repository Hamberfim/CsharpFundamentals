using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title of console app
            Console.Title = "User Input";

            // prompt user for input
            Console.Write("Please enter your name: ");
            // capture that user input
            string name = Console.ReadLine();

            // output message with captured user input
            Console.WriteLine("Hello, " + name + ". Welcome to C#!");
            Console.ReadKey();

        }
    }
}
