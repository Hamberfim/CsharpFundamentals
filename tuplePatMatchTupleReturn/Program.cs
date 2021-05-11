using System;

namespace tuplePatMatchTupleReturn
{
    class Program
    {
        // tuple pattern match - dry weight - tuple return is coversion weights - using method overloading
        // string input - cups
        private static (string cups, int grams, decimal ounces) ToEquivalencies(string inCups) => inCups switch
        {
            ("1/8 cup") => ("1/8 cup", 16, 0.563m),
            ("1/4 cup") => ("1 /4 cup", 32, 1.13m),
            ("1/3 cup") => ("1/3 cup", 43, 1.5m),
            ("1/2 cup") => ("1/2 cup", 64, 2.25m),
            ("2/3 cup") => ("2/3 cup", 85, 3.0m),
            ("3/4 cup") => ("3/4 cup", 96, 3.38m),
            ("1 cup") => ("1 cup", 128, 4.5m),
            (_) => ("no measurement match", 0, 0.0m)
        };
        // int input grams
        private static (string cups, int grams, decimal ounces) ToEquivalencies(int inGrams) => inGrams switch
        {
            (16) => ("1/8 cup", 16, 0.563m),
            (32) => ("1/4 cup", 32, 1.13m),
            (43) => ("1/3 cup", 43, 1.5m),
            (64) => ("1/2 cup", 64, 2.25m),
            (85) => ("2/3 cup", 85, 3.0m),
            (96) => ("3/4 cup", 96, 3.38m),
            (128) => ("1 cup", 128, 4.5m),
            (_) => ("no measurement match", 0, 0.0m)
        };
        // decimal input ounces
        private static (string cups, int grams, decimal ounces) ToEquivalencies(decimal inOunces) => inOunces switch
        {
            (0.563m) => ("1/8 cup", 16, 0.563m),
            (1.13m) => ("1/4 cup", 32, 1.13m),
            (1.5m) => ("1/3 cup", 43, 1.5m),
            (2.25m) => ("1/2 cup", 64, 2.25m),
            (3.0m) => ("2/3 cup", 85, 3.0m),
            (3.38m) => ("3/4 cup", 96, 3.38m),
            (4.5m) => ("1 cup", 128, 4.5m),
            (_) => ("no measurement match", 0, 0.0m)
        };


        static void Main(string[] args)
        {
            Console.WriteLine("=== Approximate Dry weight Conversions ===");
            // cups input
            var flour = ToEquivalencies("1 cup");
            Console.WriteLine($"Flour: {flour.cups} = {flour.grams}g = {flour.ounces}oz.");
            // grams input
            var choco = ToEquivalencies(64);
            Console.WriteLine($"Choco: {choco.cups} = {choco.grams}g = {choco.ounces}oz.");
            // ounces input 
            var butter = ToEquivalencies(1.13m);
            Console.WriteLine($"Butter: {butter.cups} = {butter.grams}g = {butter.ounces}oz. ");
            // no measurement match
            var salt = ToEquivalencies("1/4 tsp");
            Console.WriteLine($"Salt: {salt.cups} = {salt.grams}g = {salt.ounces}oz. ");

            Console.WriteLine("\n\n");
        }
    }
}
