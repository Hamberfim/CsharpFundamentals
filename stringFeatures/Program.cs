using System;

namespace stringFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // some string features
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("\nERROR: No text found! Program exiting.");
            }
            else
            {
                
                Console.WriteLine($"\nHi {name}! Thanks for entering your name.");
                Console.WriteLine($"Your name character length is {name.Length}.");

                string query = name.StartsWith("A") ? "Does" : "Does Not";
                Console.WriteLine($"Your name {query} start with an 'A'.");

                query = name.EndsWith("e") ? "Does" : "Does Not";
                Console.WriteLine($"Your name {query} end with an 'e'.");

                query = name.Contains("pizza") ? "Does" : "Does Not";
                Console.WriteLine($"The entered text {query} contain the word 'pizza'.");
            }



            Console.WriteLine("\n\n\n");
        }
    }
}
