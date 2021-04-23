using System;
using Humanizer;

namespace usingNuGetHumanizer
{
    class Program
    {
        static void HumanizeQuantities()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
            Console.WriteLine("piece".ToQuantity(0));
            Console.WriteLine("piece".ToQuantity(1));
            Console.WriteLine("piece".ToQuantity(3));
        }

        static void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-48).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize(2));

        }

        static void HumanizeNumbersToWords()
        {
            Console.WriteLine($"1. {1.ToWords()}");
            Console.WriteLine($"5. {5.ToWords()}");
            Console.WriteLine($"10. {10.ToWords()}");
            Console.WriteLine($"22. {22.ToWords()}");
            Console.WriteLine($"136. {136.ToWords()}");
            Console.WriteLine($"4436. {4436.ToWords()}");
        }

        static void Titleize()
        {
            Console.WriteLine("mississippi delta".Humanize(LetterCasing.Title));
            Console.WriteLine("los angles".Humanize(LetterCasing.Title));
            Console.WriteLine("critter fritter".Humanize(LetterCasing.Title));
            Console.WriteLine("all_the_hair".Humanize(LetterCasing.Title));
            Console.WriteLine("some-of-the-hair".Humanize(LetterCasing.Title));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quantities:");
            HumanizeQuantities();
            Console.WriteLine();

            Console.WriteLine("Date/Time Manipulation:");
            HumanizeDates();
            Console.WriteLine();

            Console.WriteLine("Numbers to words:");
            HumanizeNumbersToWords();
            Console.WriteLine();

            Console.WriteLine("Titleize (cap first leter of each word):");
            Titleize();

            Console.WriteLine("\n");
        }


    }
}
