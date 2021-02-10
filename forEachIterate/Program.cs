using System;

namespace forEachIterate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Each";

            // foreach (data-type variable-name in array-name) {statements}

            string[] websites = new string[5]
            {
                "Google", "You-Tube", "Facebook", "Baidu", "Yahoo!"
            };

            Console.WriteLine("Popular Websites");
            int rank = 1;
            foreach(string site in websites)
            {
                Console.WriteLine("Position: " + rank + "\t" + site);
                rank++;
            }



            Console.ReadKey();
        }
    }
}
