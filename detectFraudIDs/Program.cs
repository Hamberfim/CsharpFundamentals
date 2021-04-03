/***************************************************************
* Name        : detectFraud
* Author      : Anthony Hamlin
* Created     : $time$
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : This program simulates flagging suspicious transactions        
***************************************************************/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace detectFraud
{
    class Program
    {
        static void Main(string[] args)
        {
            // allow looping to test for random negative transactions (as if a batch)
            bool runAgain = true;

            while(runAgain)
            {
                // faux order IDs via Guid
                string orderID0 = Guid.NewGuid().ToString();
                string orderID1 = Guid.NewGuid().ToString();
                string orderID2 = Guid.NewGuid().ToString();
                string orderID3 = Guid.NewGuid().ToString();
                string orderID4 = Guid.NewGuid().ToString();
                string orderID5 = Guid.NewGuid().ToString();
                string orderID6 = Guid.NewGuid().ToString();
                string orderID7 = Guid.NewGuid().ToString();
                string orderID8 = Guid.NewGuid().ToString();
                string orderID9 = Guid.NewGuid().ToString();
                string orderID10 = Guid.NewGuid().ToString();
                string orderID11 = Guid.NewGuid().ToString();
                string orderID12 = Guid.NewGuid().ToString();
                string orderID13 = Guid.NewGuid().ToString();
                string orderID14 = Guid.NewGuid().ToString();

                // Guid[] orderIds = {orderID0, orderID1, orderID2, orderID3, orderID4, orderID5, orderID6, orderID7, orderID8, orderID9};

                // random transaction values
                Random rnd = new Random();
                string trans0 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans1 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans2 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans3 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans4 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans5 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans6 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans7 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans8 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans9 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans10 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans11 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans12 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans13 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";
                string trans14 = $"{(new Random().NextDouble() * rnd.Next(-100, 2001)):####.00}";

                // guids and transactions as key/value
                var ordersDict = new List<KeyValuePair<string, string>>();

                // populate list
                ordersDict.Add(new KeyValuePair<string, string>(orderID0, trans0));
                ordersDict.Add(new KeyValuePair<string, string>(orderID1, trans1));
                ordersDict.Add(new KeyValuePair<string, string>(orderID2, trans2));
                ordersDict.Add(new KeyValuePair<string, string>(orderID3, trans3));
                ordersDict.Add(new KeyValuePair<string, string>(orderID4, trans4));
                ordersDict.Add(new KeyValuePair<string, string>(orderID5, trans5));
                ordersDict.Add(new KeyValuePair<string, string>(orderID6, trans6));
                ordersDict.Add(new KeyValuePair<string, string>(orderID7, trans7));
                ordersDict.Add(new KeyValuePair<string, string>(orderID8, trans8));
                ordersDict.Add(new KeyValuePair<string, string>(orderID9, trans9));
                ordersDict.Add(new KeyValuePair<string, string>(orderID10, trans10));
                ordersDict.Add(new KeyValuePair<string, string>(orderID11, trans11));
                ordersDict.Add(new KeyValuePair<string, string>(orderID12, trans12));
                ordersDict.Add(new KeyValuePair<string, string>(orderID13, trans13));
                ordersDict.Add(new KeyValuePair<string, string>(orderID14, trans14));

                Console.WriteLine("======= Transactions =======");
                foreach (KeyValuePair<string, string> item in ordersDict)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

                Console.WriteLine("======= Suspicious Transactions Below (if any are flagged) =======");
                foreach (KeyValuePair<string, string> item in ordersDict)
                {
                    // Assuming control of transaction numbering with no starting double letters or double numbers
                    // flag accounts starting with double characters or with negative transaction or high transaction above 1500
                    if ((Regex.IsMatch(item.Key, "^(aa|bb|cc|dd|ee|ff)")) || (Regex.IsMatch(item.Key, "^(00|11|22|33|44|55|66|77|88|99)")))
                    {
                        Console.WriteLine($"Transaction id: {item.Key} of ${item.Value} !! Beginning Account Numbers are Suspicious !!");
                    }
                    else if ((Convert.ToDecimal(item.Value) < 0) || (Convert.ToDecimal(item.Value) > 1500))
                    {
                        Console.WriteLine($"Transaction id: {item.Key} of ${item.Value} !! Amount suspicious !!");
                    }
                }

                // run again question
                Console.WriteLine();
                Console.WriteLine(" \nRun new batch? Enter (Y)es or (N)o:");
                string answer = Console.ReadLine();
                answer.ToLower();

                if (answer.Contains("y"))
                {
                    runAgain = true;
                    Console.WriteLine();
                }
                else
                {
                    // anything other than 'y'
                    runAgain = false;
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine("Exiting Simulation.");

            Console.WriteLine("\n\n");
        }
    }
}
