using System;

namespace enumerationsReview
{
    class Program
    {
        enum Language { PL, DE, EN };
        enum Season { Spring, Summer, Autumn, Winter };
        enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

        static void Main(string[] args)
        {
            Language lang = Language.EN;
            switch (lang)
            {
                case Language.PL: 
                    Console.WriteLine("Polish language chosen");
                    break;
                case Language.EN:
                    Console.WriteLine("English language chosen");
                    break;
                default:
                    Console.WriteLine("German language chosen");
                    break;
            }

            Season fall = Season.Autumn;
            Console.WriteLine($"I love {fall} in Iowa.");

            DayOfWeek thirdDay = DayOfWeek.Tuesday;
            Console.WriteLine($"It happened on a {thirdDay}.");


            Console.WriteLine("\n\n");
        }
    }
}
