/***************************************************************
* Name        : stringConcatJoinCompare
* Author      : Anthony Hamlin
* Created     : 02/12/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Some string methods in use.        
***************************************************************/
using System;

namespace stringConcatJoinCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Strings and some String Methods";

            string[] a = new string[3] {"Alpha", "Beta", "Gamma"};
            Console.WriteLine("  ===== This is the string array =====  \n\tstring[] a = new string[3] {" + a[0] + ", " + a[1] + ", " + a[2] + "}");
            Console.WriteLine();  // new line - because I hate using \n ...it's just looks sloppy.

            // concatenation
            Console.WriteLine("  ===== Concatenation using String.Concat =====");
            string s = String.Concat(a[0], a[1]);
            Console.WriteLine("\tConcat a[0], a[1]: " + s);
            Console.WriteLine();  // new line - because I hate using \n ...it's just looks sloppy.

            // join with a declarded seperator
            Console.WriteLine("  ===== Concatenation using String.Join =====");
            s = String.Join("-", a[0], a[1]);
            Console.WriteLine("\tJoin a[0], a[1] with a seperator '-': " + s);

            // join with a declarded seperator
            s = String.Join("<br>", a[0], a[1]);
            Console.WriteLine("\tJoin a[0], a[1] with an html tag: " + s);
            Console.WriteLine();  // new line - because I hate using \n ...it's just looks sloppy.

            Console.WriteLine("  ===== Comparing using String.Compare =====");
            int num = String.Compare(a[0], a[1]);
            Console.WriteLine("\t" + a[0] + " v " + a[1] + ":\t" + num);

            num = String.Compare(a[2], a[1]);
            Console.WriteLine("\t" + a[2] + " v " + a[1] + ":\t" + num);
            Console.WriteLine();  // new line - because I hate using \n ...it's just looks sloppy.

            Console.WriteLine("  ===== Comparing using .CompareTo =====");
            num = a[1].CompareTo(a[1]);
            Console.WriteLine("\t" + a[1] + " v " + a[1] + ":\t" + num);
            Console.WriteLine();  // new line - because I hate using \n ...it's just looks sloppy.

            // Boolean comparison
            Console.WriteLine("  ===== Comparing using boolean/.Equals =====");
            bool flag = (a[0] == a[1]);
            Console.WriteLine("\t" + a[0] + " == " + a[1] + ":\t" + flag);

            flag = a[2].Equals(a[2]);
            Console.WriteLine("\t" + a[2] + " == " + a[2] + ":\t" + flag);

            Console.WriteLine("\n\n");  // push exit message down in console
        }
    }
}
