/***************************************************************
* Name        : subStrings
* Author      : Anthony Hamlin
* Created     : 02/16/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : using substring to seach and using replace       
***************************************************************/
using System;

namespace subStrings
{
    class Program
    {
        // result of substring search
        static void report (int pos, string sub)
        {
            if(pos != -1)
            {
                Console.WriteLine($"'{sub}' found at index position {pos}.");
            }
            else
            {
                Console.WriteLine($"'{sub}' NOT found.");
            }
        }

        static void noVowels (string subsearch)
        {
            // for fun - take substring search and return it minus all vowels  - should use regex
            subsearch = subsearch.ToLower();
            if (subsearch.Contains('a'))
            {

                string vowel = "a";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains('e'))
            {
                string vowel = "e";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains('i'))
            {
                string vowel = "i";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains('o'))
            {
                string vowel = "o";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains('u'))
            {
                string vowel = "u";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains(' '))
            {
                string vowel = " ";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains(','))
            {
                string vowel = ",";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains('.'))
            {
                string vowel = ".";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains("'"))
            {
                string vowel = "'";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains("?"))
            {
                string vowel = "?";
                subsearch = subsearch.Replace(vowel, "");

            }

            if (subsearch.Contains("!"))
            {
                string vowel = "!";
                subsearch = subsearch.Replace(vowel, "");

            }

            Console.WriteLine(subsearch);
        }

        static void Main(string[] args)
        {
            Console.Title = "Searching substrings";

            string phrase = "My dog is a cute dog but my dog sometimes keeps me up at night.";
            Console.WriteLine($"String phrase:\n{phrase}");
            Console.WriteLine();  // space
            Console.Write("Enter a substring to search for: ");
            string subsearch = Console.ReadLine();
            subsearch = subsearch.ToLower();

            // create a char array and copy the entered substring
            char[] arr = new char[subsearch.Length];
            subsearch.CopyTo(0, arr, 0, subsearch.Length);

            int pos = phrase.IndexOf(subsearch);

            // first occurance of substring
            report(pos, subsearch);

            //last occurance of substring
            pos = phrase.LastIndexOf(subsearch);
            report(pos, subsearch);

            // first occurance of any char in the array
            pos = phrase.IndexOfAny(arr);
            report(pos, phrase.Substring(pos, 1));

            // last occurance of any char in the array
            pos = phrase.LastIndexOfAny(arr);
            report(pos, phrase.Substring(pos, 1));

            Console.WriteLine();  //space
            // call method that removes vowels
            noVowels(subsearch);

            Console.WriteLine("\n\n\n");
        }
    }
}
