using System;
using System.Collections.Generic;

namespace arrayHelperChallengeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            string[] pallets = orderStream.Split(',');

            foreach (var item in pallets)
            {
                if(item.Contains("B"))
                {
                    Console.WriteLine(item);
                }
                
            }

            Console.WriteLine("\n");
        }
    }
}
