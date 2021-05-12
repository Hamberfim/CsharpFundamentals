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

        // simple cups to grams formula -  grams = cups * 125
        private static decimal CupsToGrams(decimal cups)
        {
            decimal grams = 0m;
            grams = cups * 125.0m;
            return grams;
        }

        // simple grams to cups formula -  cups = grams / 125
        private static (decimal cupsQtr, decimal cupsDeci) GramsToCups(decimal grams)
        {
            decimal cups = 0.000m;
            cups = grams / 125.000m;
            decimal cupsDeci = Math.Round(cups, 2);
            // rounding to nearest quarter  i.e. cups.25, cups.50 cups.75, cups.0
            decimal cupsQtr = Math.Round(cups * 4, MidpointRounding.ToEven) / 4;
            // return the tuple
            return (cupsQtr, cupsDeci);
        }


        static void Main(string[] args)
        {
            // switch chart conversions
            Console.WriteLine("=== Dry weight Conversions Chart ===");
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
            Console.WriteLine();

            // calculated cup to grams conversions
            Console.WriteLine("=== Dry weight cups to grams Conversions ===");
            decimal oneCup = CupsToGrams(1.0m);
            Console.WriteLine($"One cup of flour is equal to {oneCup} grams.");
            decimal threeAndOneHalfCups = CupsToGrams(3.5m);
            Console.WriteLine($"Three and One Half cups of flour is equal to {threeAndOneHalfCups} grams.");
            Console.WriteLine();

            // calculated grams to cups conversions
            Console.WriteLine("=== Dry weight grams to cups Conversions ===");
            var FourThirtyFive = GramsToCups(435.5m);
            Console.WriteLine($"435.5 grams of flour is equal to {FourThirtyFive.cupsDeci} or {FourThirtyFive.cupsQtr} cups (*rounded to nearest quarter)");
            var TwoTwentyEight = GramsToCups(228m);
            Console.WriteLine($"228 grams of flour is equal to {TwoTwentyEight.cupsDeci} or {TwoTwentyEight.cupsQtr} cups (*rounded to nearest quarter)");

            Console.WriteLine("\n\n");
        }
    }
}
