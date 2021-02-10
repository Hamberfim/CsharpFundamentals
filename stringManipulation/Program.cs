using System;

namespace stringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Title";

            Console.Write("Please enter some text: ");
            string text = Console.ReadLine();

            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("\nERROR: No text found! Program exiting.");
            }
            else
            {
                // some string manipulation
                Console.WriteLine($"You entered '{text}', thanks!");
                Console.WriteLine($"Text length is {text.Length}.");
                Console.WriteLine();  // space in output

                string upperCase = text.ToUpper();
                Console.WriteLine("Your text to upper case:");
                Console.WriteLine($"\t{upperCase}");
                Console.WriteLine();  // space in output

                upperCase = upperCase.PadLeft(40);
                Console.WriteLine("Your text with pad left 40 chars:");
                Console.WriteLine($"\t{upperCase}");
                Console.WriteLine();  // space in output

                string lowerCase = text.ToLower();
                Console.WriteLine("Your text to lower case:");
                Console.WriteLine($"\t{lowerCase}");
                Console.WriteLine();  // space in output

                lowerCase = lowerCase.PadRight(40);
                Console.WriteLine("Your text with pad right 40 chars:");
                Console.WriteLine($"\t{lowerCase}");
                Console.WriteLine();  // space in output

                text = text.PadLeft(30, '=').PadRight(45, '=');  // very finicky
                Console.WriteLine($"{text}");
                Console.WriteLine();  // space in output

                text = "     This is new text that needs trimmed at both ends.     ";
                Console.WriteLine($"{text}");
                Console.WriteLine();  // space in output

                text = text.TrimStart().TrimEnd();
                Console.WriteLine("...with both ends trimmed:");
                Console.WriteLine($"{text}");

            }


            Console.WriteLine("\n\n\n");
        }
    }
}
