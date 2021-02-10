using System;

namespace ifBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "If Branching - conditional control";

            // user input
            Console.Write("Enter a number between 1-10: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Now enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine());
            letter = char.ToLower(letter);
            Console.WriteLine();  // space in output

            // branch conditional control
            if (num >= 6)
            {
                Console.WriteLine("Your number is greater than 5.");
                // nest an if
                if (letter == 'c')
                {
                    Console.WriteLine("You chose the letter 'C'");
                }
                else
                {
                    Console.WriteLine($"The letter you chose is {char.ToUpper(letter)}.");
                }
            }
            else
            {
                Console.WriteLine($"Your number is five or less and your letter is {char.ToUpper(letter)}.");
            }

            Console.ReadKey();
        }
    }
}
