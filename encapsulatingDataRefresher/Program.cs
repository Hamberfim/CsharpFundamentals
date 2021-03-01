/***************************************************************
* Name        : encapsulatingDataRefresher
* Author      : Anthony Hamlin
* Created     : 03/01/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Class/Encapsulating Refresher        
***************************************************************/
using System;

namespace encapsulatingDataRefresher
{
    class Program
    {
        // a public class
        public class Food
        {
            private string foodName;
            private string foodType;
            private string foodColor;

            // member methods
            public void setFoodValues(string foodName, string foodType, string foodColor)
            {
                this.foodName = foodName;
                this.foodType = foodType;
                this.foodColor = foodColor;
            }

            // setters/getters
            public void setFoodName(string tagFoodName)
            {
                foodName = tagFoodName;
            }

            public string getFoodName()
            {
                return foodName;
            }

            public void setFoodType(string tagFoodType)
            {
                foodType = tagFoodType;
            }

            public string getFoodType()
            {
                return foodType;
            }

            public void setFoodColor(string tagFoodColor)
            {
                foodColor = tagFoodColor;
            }

            public string getFoodColor()
            {
                return foodColor;
            }

            // other methods


        }


        static void Main(string[] args)
        {
            // created an instance pf Food
            Food orange = new Food();

            // set the values of the new instance
            orange.setFoodValues("orange", "fruit", "orange");

            string orangeFruit = String.Format($"Food Name: {orange.getFoodName()}, Type: {orange.getFoodType()}, Food color: {orange.getFoodColor()}");

            Console.WriteLine(orangeFruit);
            Console.WriteLine($"The {orange.getFoodName()} gets its name from its {orange.getFoodColor()} color and is a type of {orange.getFoodType()}.");

            Console.WriteLine("\n\n");
        }
    }
}
