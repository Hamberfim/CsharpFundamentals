/***************************************************************
* Name        : capNames
* Author      : Anthony Hamlin
* Created     : 02/18/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Capitalize first latter of each word entered by user        
***************************************************************/
using System;
using System.Text.RegularExpressions;

namespace capNames
{
    class Program
    {
        // capitalize
        static string CapEachWord(string fullName)
        {
            string[] splitSeperators = { " ", ", ", ",", "-", "_"};  // declare mutiple Split() seperators
            string capWords = "";
            // split name string and put them in an array
            // string[] word_items = fullName.Split(" "); 
            string[] word_items = fullName.Split(splitSeperators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in word_items)
            {
                
                string capWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                capWords += capWord;
                capWords += " ";
                
            }
            return capWords;
        }


        static void Main(string[] args)
        {

            Console.Title = "Format name input";

            // get user input
            Console.Write("Please enter words or your full name: ");
            string allWords = Console.ReadLine();

            if(string.IsNullOrEmpty(allWords))
            {
                Console.WriteLine("\n");  //provide space in error output for readability
                Console.WriteLine("\tError reading input! Did you enter any words?");
            }
            //else if(!Regex.IsMatch(allWords.ToString(), "^[a-zA-Z]*$"))  // 'if not' only letters (alphabet)
            //{
            //    Console.WriteLine("\n");  //provide space in error output for readability
            //    Console.WriteLine("\tError reading input! Only enter letters.");
            //}
            else
            {
                Console.WriteLine($"What you entered: {allWords}.");
                Console.WriteLine($"\nWhat I did to it: {CapEachWord(allWords)}");
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
