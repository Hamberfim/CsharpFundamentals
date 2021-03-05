/***************************************************************
* Name        : capableClasses
* Author      : Anthony Hamlin
* Created     : 03/05/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Provide capabilities to a derived classes        
***************************************************************/
using System;

namespace capableClasses
{
    class Program
    {
        // abstract class to be implemented in a derived class
        public abstract class Vehicle
        {
            public abstract void engineSound();

            public abstract void hornSound();
        }

        // sealed prevents the class from being used as a base class
        public sealed class Truck : Vehicle
        {
            public override void engineSound()
            {
                Console.WriteLine("Truck engine sounds like a low rummbling sound");
            }

            public override void hornSound()
            {
                Console.WriteLine("Truck horn sounds like a low tugboat whistle");
            }
        }

        public sealed class Vespa : Vehicle
        {
            public override void engineSound()
            {
                Console.WriteLine("Vespa engine sounds like a pitchy lawn mower sound");
            }

            public override void hornSound()
            {
                Console.WriteLine("Vespa horn sounds like a tiny clown horn");
            }
        }

        public sealed class Caller
        {
            public void describeVehicle(Vehicle obj)
            {
                obj.engineSound();
                obj.hornSound();
            }
        }

        static void Main(string[] args)
        {
            Truck dumpTruck = new Truck();
            Vespa vespa = new Vespa();
            Caller call = new Caller();

            call.describeVehicle(dumpTruck);
            Console.WriteLine();
            call.describeVehicle(vespa);

            Console.WriteLine("\n\n");
        }
    }
}
