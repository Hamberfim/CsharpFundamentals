using System;

namespace switchCaseAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // title the console winddow
            Console.Title = "Swithc Case";

            Console.Write("Enter a numer between 1-7 to return a day of the week: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string day;

            // basic switch case
            switch(num)
            {
                case 1: 
                    day = "Monday";
                    break;
                case 2: 
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "Your input doesn't match a numeric day.";
                    break;
            }

            Console.WriteLine($"Your input of {num} is equal to {day}.");

            Console.ReadKey();

        }
    }
}
