using System;
using System.Collections.Generic;

namespace forEachIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Each In Iteration - Dictionary key/value pairs";

            // Dictionary < data-type, data-type > dictionary-name = new Dictionary < data-type, data-type > ();
            Dictionary < string, string > BookList = new Dictionary < string, string >();

            // add to the dictionary
            BookList.Add("Stuart Yarnold", "Arduino");
            BookList.Add("Nick Vandome", "Windows 10");
            BookList.Add("Mike McGraht", "Java");

            Console.WriteLine("Popular Title");

            foreach(KeyValuePair <string, string> book in BookList)
            {
                Console.WriteLine($"Key: {book.Key}, Value: {book.Value} in easy steps.");
            }

            Console.ReadKey();

        }
    }
}
