using System;

namespace ternaryHeadsTails
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int flip = rnd.Next(1, 3);
            Console.WriteLine($"Coin toss resulted in {(flip == 1 ? "Heads" : "Tails")}");

            flip = rnd.Next(1, 3);
            Console.WriteLine($"Coin toss resulted in {(flip == 1 ? "Heads" : "Tails")}");

            // simplified with other Random range values
            Console.WriteLine($"Coin toss resulted in {((rnd.Next(0, 2) == 0) ? "Heads" : "Tails")}");

            Console.WriteLine($"Coin toss resulted in {((rnd.Next(7, 9) == 7) ? "Heads" : "Tails")}");

            Console.WriteLine("\n\n");
        }
    }
}
