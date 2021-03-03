/***************************************************************
* Name        : ClassInstanceConstructor
* Author      : Anthony Hamlin
* Created     : 03/03/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : A Constructor to provide default values        
***************************************************************/
using System;
using Humanizer;

namespace ClassInstanceConstructor
{
    class Program
    {
        public class Cat
        {
            private string name, color;
            private int age;

            // methods


            // contructors - to set default value for each variable
            public Cat()
            {
                name = "shameus";
                age = 5;
                color = "calico";

            }

            // setters and getters
            public void setName(string name)
            {
                this.name = name;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public void setColor(string color)
            {
                this.color = color;
            }


            public string getName()
            {
                // title case
                return name.Transform(To.TitleCase);
            }

            public int getAge()
            {
                return age;
            }

            public string getColor()
            {
                // title case
                return color.Transform(To.TitleCase);
            }

            // object behavior methods
            public string cry()
            {
                return "\n Meow, Meow!\n";
            }

            public string purr()
            {
                return "\n Purrrrr, purrrrrrr!\n";
            }


        }

        static void Main(string[] args)
        {

            // initialize object
            Cat shameus = new Cat();

            // get object prperties
            string tagShameus = String.Format($"Base on the Constructor:\n{shameus.getName()} is a {shameus.getAge()} year old {shameus.getColor()} cat.");

            // diplay properties
            Console.WriteLine(tagShameus + shameus.cry());

            Console.WriteLine();

            // initialize object
            Cat bella = new Cat();

            // set object properties by over-ridding the default constructor
            bella.setName("bella");
            bella.setAge(2);
            bella.setColor("marmalade tabby");

            // get object prperties
            string tagbella = String.Format($"Override the Constructor:\n{bella.getName()} is a {bella.getAge()} year old {bella.getColor()} cat.");

            // diplay properties
            Console.WriteLine(tagbella + bella.purr());


            Console.WriteLine("\n\n\n");
        }
    }
}
