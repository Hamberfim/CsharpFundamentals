using System;
using Humanizer;

namespace usingHumanizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Using the Humanizer NuGet package";

            string[] singularWords = new string[]
            {
                "phenomenon", "focus", "fungus", "hippopotamus", "vertebra", "lady", "spy", "leaf", "woman", "foot", "person"
            };
            Console.WriteLine("===== Pluralize Examples =====");
            foreach (string word in singularWords)
            {
                Console.Write($" {word} = ");
                Console.WriteLine($"{word}".Pluralize());
            }
            Console.WriteLine();
            string pascalPhrase = "PascalStyledPhrase";
            Console.WriteLine($"This '{pascalPhrase} as humanized = " + pascalPhrase.Humanize());
            pascalPhrase = pascalPhrase.Humanize();
            Console.WriteLine($"This humanized '{pascalPhrase}' as dehumanize = " + pascalPhrase.Dehumanize());
            Console.WriteLine();

            string underScoredStr = "this_string_is_full_of_underscores";
            Console.WriteLine($"{underScoredStr} = " + underScoredStr.Humanize());
            Console.WriteLine();

            string acronym = "NCCP";
            Console.WriteLine($"'{acronym}' Any unbroken upper case string is treated as an acronym = " + acronym.Humanize(LetterCasing.Title));
            acronym = "NCCP IS AN ACRONYM";
            Console.WriteLine($"'{acronym}' Any unbroken upper case string is treated as an acronym = " + acronym.Humanize(LetterCasing.Title));
            acronym = "NCCP is an acronym";
            Console.WriteLine($"'{acronym}' Any unbroken upper case string is treated as an acronym = " + acronym.Humanize(LetterCasing.Title));
            Console.WriteLine();

            string name = "bill van garde";
            Console.WriteLine($"{name} transform(To.TitleCase) = " + name.Transform(To.TitleCase));
            Console.WriteLine();

            string phrase = "This is a long sentance to use Humanize truncate";
            Console.WriteLine($"{phrase} .truncate(16, '...') = " + phrase.Truncate(16, "..."));
            Console.WriteLine($"{phrase} .truncate(16, '---') = " + phrase.Truncate(16, "---"));
            Console.WriteLine($" .truncate(20, '...', Truncator.FixedLength, TruncateFrom.Left) = " + phrase.Truncate(20, "...", Truncator.FixedLength, TruncateFrom.Left));
            Console.WriteLine();

            phrase = "To be formatted -> {0}/{1}";
            Console.WriteLine($"{phrase}.FormatWith(1, 'A') " + phrase.FormatWith(1, "A"));
            phrase = "{0}*{1}+{2}={3}";
            Console.WriteLine($"{phrase}.FormatWith(9, 'A', 2, '11A') = " + phrase.FormatWith(9, "A", 2, "11A"));
            Console.WriteLine();

            DateTime now = DateTime.Now;
            Console.WriteLine($"{now} plus 1 day = " + now.AddDays(1));
            Console.WriteLine($"{now} plus 1 day humanzied = " + now.AddDays(1).Humanize());
            Console.WriteLine($"{now} minus 2 days = " + now.AddDays(-2));
            Console.WriteLine($"{now} minus 2 days humanzied = " + now.AddDays(3).Humanize());
            Console.WriteLine($"{now} plus 17 days = " + now.AddDays(17));
            Console.WriteLine($"{now} plus 17 days using TimeSpan.FromDays(17).Humanize(precision:2) \n\t= " + TimeSpan.FromDays(17).Humanize(precision: 2));
            Console.WriteLine();

            string quantityForm = "foot";
            Console.WriteLine($"{quantityForm} given a quantity of two = " + quantityForm.ToQuantity(2, ShowQuantityAs.Words));
            Console.WriteLine($"{quantityForm} given a quantity of 3 = " + quantityForm.ToQuantity(3, ShowQuantityAs.Numeric));
            quantityForm = "bottle";
            Console.WriteLine($"{quantityForm} given a quantity of six = " + quantityForm.ToQuantity(6, ShowQuantityAs.Words) + " of beer.");
            Console.WriteLine();

            Console.WriteLine($"Convert 4 to Roman Numeral = " + 4.ToRoman());
            Console.WriteLine($"Convert 23 to Roman Numeral = " + 23.ToRoman());
            Console.WriteLine($"Convert 137 to Roman Numeral = " + 137.ToRoman());
            Console.WriteLine($"Convert VII from Roman Numerals = " + "VII".FromRoman());
            Console.WriteLine($"Convert XXIII from Roman Numerals = " + "XXIII".FromRoman());
            Console.WriteLine($"Convert MCLXXXII from Roman Numerals = " + "MCLXXXII".FromRoman());


            Console.WriteLine("\n\n\n");
        }
    }
}
