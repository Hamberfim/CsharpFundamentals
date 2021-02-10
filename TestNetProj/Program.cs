using System;
using System.Globalization;
using System.Text;

namespace TestNetProj
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo cf = new CultureInfo("en_US", false).TextInfo;
            DateTime dSTamp = DateTime.Now;

            if (args.Length > 0 && args.Length < 2) 
            {
                Console.WriteLine($"Hello {cf.ToTitleCase(args[0])}!");
            }
            else if (args.Length > 1 && args.Length < 3) 
            {
                Console.WriteLine($"Hello {cf.ToTitleCase(args[0])} {cf.ToTitleCase(args[1])}!");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }
            Console.WriteLine($"Current time is {dSTamp.ToString("hh:mm tt")}.");
        }
    }
}
