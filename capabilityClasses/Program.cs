/***************************************************************
* Name        : capabilityClasses
* Author      : Anthony Hamlin
* Created     : 03/05/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Provide capabilities to a derived class        
***************************************************************/
using System;

namespace capabilityClasses
{
    class Program
    {
        public abstract class Bird
        {
            public abstract void talk();

            public abstract void fly();
        }

        // derived class
        public sealed class Pigeon : Bird
        {
            public override void talk()
            {
                Console.WriteLine("Pigeon says: coo! coo!");
            }

            public override void fly()
            {
                Console.WriteLine("A pigeon flies away...");
            }
        }

        public sealed class Chicken : Bird
        {
            public override void talk()
            {
                Console.WriteLine("Chicken says: cluck! cluck!");
            }

            public override void fly()
            {
                Console.WriteLine("I'm a chicken. I really can't fly much...");

            }
        }

        public sealed class Caller
        {
            public void describeBird(Bird obj)
            {
                obj.talk();
                obj.fly();
            }
        }


        static void Main(string[] args)
        {
            Pigeon knuckles = new Pigeon();
            Chicken mrcluckcluck = new Chicken();
            Caller call = new Caller();

            call.describeBird(knuckles);
            Console.WriteLine();
            call.describeBird(mrcluckcluck);

            Console.WriteLine("\n\n");
        }
    }
}