/***************************************************************
* Name        : formateDateStrings
* Author      : Anthony Hamlin
* Created     : 02/18/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : formatting date strings       
***************************************************************/
using System;

namespace formateDateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Date Formating";

            DateTime now = DateTime.Now;
            Console.WriteLine($"Current date and time: {now}.");
            Console.WriteLine("===============================");
            Console.WriteLine($"The day of the week is: {now.DayOfWeek}.");
            Console.WriteLine($"Today's date: {now.ToShortDateString()}.");
            Console.WriteLine($"The Time is: {now.ToShortTimeString()}.");
            Console.WriteLine();

            DateTime now4years = DateTime.Now.AddYears(4);
            Console.WriteLine($"In 4 years it will be: {now4years.ToShortDateString()}.");

            DateTime threeMonths = DateTime.Now.AddMonths(3);
            Console.WriteLine($"In 3 months it will be {threeMonths.ToShortDateString()}.");

            DateTime fiveDays = DateTime.Now.AddDays(5);
            Console.WriteLine($"In 5 days it will be {fiveDays.ToShortDateString()}.");

            DateTime threeHours = DateTime.Now.AddHours(3);
            Console.WriteLine($"In 3 hours it will be {threeHours.ToShortTimeString()}.");
            Console.WriteLine();

            // future date object
            DateTime futureDate = new DateTime(2025, 7, 4, 8, 15, 30);  // year, month, day, hour, minutes, seconds
            Console.WriteLine("Setting future date to: '2025, 7, 4, 8, 15, 30' = year, month, day, hour, minutes, seconds");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine($"Short date format: {futureDate:d}.");
            Console.WriteLine($"Long Date format: {futureDate:D}.");
            Console.WriteLine($"Short time format: {futureDate:t}.");
            Console.WriteLine($"Long time format: {futureDate:T}.");
            Console.WriteLine();
            Console.WriteLine($"Full date time format: {futureDate:f}.");
            Console.WriteLine($"Full date time with seconds format: {futureDate:F}.");
            Console.WriteLine($"Month and Day format: {futureDate:M}.");
            Console.WriteLine($"Month and Year format: {futureDate:Y}.");
            Console.WriteLine();
            Console.WriteLine($"Date day number format: {futureDate:dd}.");
            Console.WriteLine($"Day name format: {futureDate:dddd}.");
            Console.WriteLine($"Hour format: {futureDate:HH}.");
            Console.WriteLine($"Minute format: {futureDate:mm}.");
            Console.WriteLine();
            Console.WriteLine($"Seconds format: {futureDate:ss}.");
            Console.WriteLine($"Year format: {futureDate:yyyy}.");

            Console.WriteLine("\n\n\n");
        }
    }
}
