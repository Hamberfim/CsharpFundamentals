/***************************************************************
* Name        : refactoringMadLib
* Author      : Anthony Hamlin
* Created     : 02/08/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program creates random output for a Madlib and then refactors 
*               it a number of times based int num/max call to displayMadLib(num, max); 
***************************************************************/
using System;

namespace refactoringMadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // random 'excused' from class mad lib (funny nouns) using refactor
            static void displayMadLib(int num, int max)
            {
                while (num <= max)
                {
                    string[] noun = new string[5];
                    noun[0] = "oxter";
                    noun[1] = "dongle";
                    noun[2] = "spondulicks";
                    noun[3] = "spleenwort";
                    noun[4] = "teazel";

                    string[] adjective = new string[5];
                    adjective[0] = "taradiddlic";
                    adjective[1] = "redolent";
                    adjective[2] = "collywobbled";
                    adjective[3] = "slap happy";
                    adjective[4] = "conjubilant";

                    string[] name = new string[5];
                    name[0] = "Kelly Ann Long and Eric Paul Wiwi";
                    name[1] = "Shelby Looney and Joe Warde";
                    name[2] = "Linday Bayne Rather and James Michael Grimm";
                    name[3] = "Brenda Wendt and Larry Adaway";
                    name[4] = "Karla Butt and Tom Pepper";

                    string myNames;
                    string myAdjective;
                    string myNoun;

                    Random rnd = new Random();
                    myNames = name[rnd.Next(0, 5)];
                    rnd = new Random();
                    myAdjective = adjective[rnd.Next(0, 5)];
                    rnd = new Random();
                    myNoun = noun[rnd.Next(0, 5)];

                    Console.WriteLine($"Please excuse {myNames} who are far too {myAdjective} to attend {myNoun} class.\n");
                    num++;
                }

            }

            // call
            displayMadLib(1, 5);


            Console.WriteLine("\n\n\n");
        }
    }
}
