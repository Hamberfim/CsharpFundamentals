using System;
using System.Collections.Generic;

namespace ListSearchSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // list
            var cars = new List<string> {"BMW", "SAAB", "Land Rover", "Volve" };
            Console.WriteLine($"Number of items in the list is {cars.Count}.");
            Console.WriteLine($"Last item in the list is a {cars[cars.Count - 1]}");  // get the last item 

            // loop execution result is the same but without index positions
            // solution would be: foreach (var item in Model.Select((value, i) => new { i, value })){var value = item.value; var index = item.i;}
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToUpper());
            }

            Console.WriteLine();  //space in output

            // add items to list above
            cars.Add("Fiat");
            cars.Add("Volkswagen");

            Console.WriteLine($"Number of items in the list is {cars.Count}.");
            Console.WriteLine($"Last item in the list is a {cars[cars.Count-1]}");  // get the last item 

            // loops - execution result is the same outcome
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}, {cars[i].ToUpper()}");  // provides index/count position
            }

            Console.WriteLine();  //space in output

            // search for an items index position
            Console.WriteLine($"'Land Rover' index position is {cars.IndexOf("Land Rover")}.");
            var indexSAAB = cars.IndexOf("SAAB");
            Console.WriteLine($"'{cars[indexSAAB]}' index position is {indexSAAB}.");

            Console.WriteLine();  //space in output

            // if an item doesn't exist a '-1' will be returned
            var indexNotThere = cars.IndexOf("Kit Car");
            if (indexNotThere == -1)
            {
                Console.WriteLine("Item not found, index position can not be displayed.");
            }
            else
            {
                Console.WriteLine($"{cars[indexNotThere]} index position is {indexNotThere}.");
            }

            Console.WriteLine();  //space in output

            // if an item does exist it will be returned
            var indexIsThere = cars.IndexOf("Fiat");
            if (indexIsThere == -1)
            {
                Console.WriteLine("Item not found, index position can not be displayed.");
            }
            else
            {
                Console.WriteLine($"'{cars[indexIsThere]}' index position is {indexIsThere}.");
            }

            Console.WriteLine();  //space in output

            // sorting - sort method does it in place- does not create a copy
            cars.Sort();
            Console.WriteLine("List items have been sorted notice new index positions.");  
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}, {cars[i].ToUpper()}");  // provides index/count position
            }

            Console.WriteLine();  //space in output

            // sorting (reverse) - sort method does it in place- does not create a copy
            cars.Reverse();
            Console.WriteLine("List items have been Reverse() sorted notice new index positions.");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}, {cars[i].ToUpper()}");  // provides index/count position
            }

            Console.WriteLine();  //space in output
        }
    }
}
