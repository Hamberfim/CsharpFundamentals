/***************************************************************
* Name        : dogClassObjects
* Author      : Anthony Hamlin
* Created     : 03/03/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : creating object instances        
***************************************************************/
using System;
using Humanizer;

namespace dogClassObjects
{
    class Program
    {
        public class Dog
        {
            private string name, color, breed;
            private int age;

            // member methods


            // setters/getters - setValues setter method
            public void setValues(string name, int age, string color, string breed)
            {
                this.name = name;
                this.age = age;
                this.color = color;
                this.breed = breed;
            }

            // getter methods
            public string getName()
            {
                return name;
            }

            public int getAge()
            {
                return age;
            }

            public string getColor()
            {
                return color;
            }

            public string getBreed()
            {
                return breed;
            }


            // class object behavior method
            public string smallBark()
            {
                return "\n Bark, Bark!\n";
            }

            public string bigBark()
            {
                return "\n Woof, Woof!\n";
            }

        }



        static void Main(string[] args)
        {
            // create an instance of the Dog class
            Dog sukha = new Dog();

            // set the values of the new instance
            sukha.setValues("sukha", 1, "red merle", "mini australian shepherd");

            // retrieve properties of the new instance
            string tagSukha = String.Format($"{sukha.getName().Transform(To.TitleCase)} is a {sukha.getAge()} year old {sukha.getColor().Transform(To.TitleCase)} {sukha.getBreed().Transform(To.TitleCase)}.");

            // display the properties and call the class object behavior method
            Console.WriteLine(tagSukha + sukha.smallBark());

            Console.WriteLine();  // space in console output

            // create another instance of the Dog class
            Dog chaucy = new Dog();

            // set the values of the new instance
            chaucy.setValues("chaucy", 3, "black with brown", "german shepherd");

            // retrieve properties of the new instance
            string tagchaucy = String.Format($"{chaucy.getName().Transform(To.TitleCase)} is a {chaucy.getAge()} year old {chaucy.getColor().Transform(To.TitleCase)} {chaucy.getBreed().Transform(To.TitleCase)}.");

            // display the properties and call the class object behavior method
            Console.WriteLine(tagchaucy + chaucy.bigBark());


            Console.WriteLine("\n\n\n");
        }
    }
}
