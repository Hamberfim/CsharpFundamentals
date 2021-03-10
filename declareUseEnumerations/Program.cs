/***************************************************************
* Name        : declareUseEnumerations
* Author      : Anthony Hamlin
* Created     : 03/10/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : declare and use enumerations - single topping pizza order         
***************************************************************/
using System;

namespace declareUseEnumerations
{
    class Program
    {
        enum SingleToppingPizza : int
        {
            pepperoni = 1,  //start at 1 instead of zero
            sausage,
            mushroom,
            black_olive,
            red_onion,
            green_olive,
            extra_cheese
        }
        static void Main(string[] args)
        {
            double specialPizzaPrice = 5.99;

            SingleToppingPizza pepperoni = SingleToppingPizza.pepperoni;
            SingleToppingPizza sausage = SingleToppingPizza.sausage;
            SingleToppingPizza mushroom = SingleToppingPizza.mushroom;
            SingleToppingPizza black_olive = SingleToppingPizza.black_olive;
            SingleToppingPizza red_onion = SingleToppingPizza.red_onion;
            SingleToppingPizza green_olive = SingleToppingPizza.green_olive;
            SingleToppingPizza extra_cheese = SingleToppingPizza.extra_cheese;

            Console.WriteLine("===== Avaiable Single Topping Pizza's =====");
            Console.WriteLine($"{(int)pepperoni}.) {pepperoni}");  // its index value and string value
            Console.WriteLine($"{(int)sausage}.) {sausage}");
            Console.WriteLine($"{(int)mushroom}.) {mushroom}");

            string blackOlive = black_olive.ToString();
            blackOlive = blackOlive.Replace("_", " ");
            Console.WriteLine($"{(int)black_olive}.) {blackOlive}");

            string redOnion = red_onion.ToString();
            redOnion = redOnion.Replace("_", " ");
            Console.WriteLine($"{(int)red_onion}.) {redOnion}");

            string greenOlive = green_olive.ToString();
            greenOlive = greenOlive.Replace("_", " ");
            Console.WriteLine($"{(int)green_olive}.) {greenOlive}");

            string extraCheese = extra_cheese.ToString();
            extraCheese = extraCheese.Replace("_", " ");
            Console.WriteLine($"{(int)extra_cheese}.) {extraCheese}");

            Console.WriteLine();

            Console.Write("Enter your pizza choice 1-7: ");
            try
            {
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.WriteLine($"Your {pepperoni} pizza @ {specialPizzaPrice:C} will be ready in 30 minutes or less.");
                }

                if (userChoice == 2)
                {
                    Console.WriteLine($"Your {sausage} pizza @ {specialPizzaPrice:C} will be ready in 30 minutes or less.");
                }

                if (userChoice == 3)
                {
                    Console.WriteLine($"Your {mushroom} pizza @ {specialPizzaPrice:C} will be ready in 30 minutes or less.");
                }

                if (userChoice == 4)
                {
                    Console.WriteLine($"Your {blackOlive} pizza @ {specialPizzaPrice:C} will be ready in 30 minutes or less.");
                }

                if (userChoice == 5)
                {
                    Console.WriteLine($"Your {redOnion} pizza @ {specialPizzaPrice:C} will be ready in 30 minutes or less.");
                }

                if (userChoice == 6)
                {
                    Console.WriteLine($"Your {greenOlive} pizza @ {specialPizzaPrice:C} will be ready in 30 minutes or less.");
                }

                if (userChoice == 7)
                {
                    Console.WriteLine($"Your {extraCheese} pizza @ {specialPizzaPrice:C} will be ready in 30 minutes or less.");
                }
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message + " !!! User input must be a whole number between 1-7 !!!");
            }
            
            Console.WriteLine("\n\n");
        }
    }
}
