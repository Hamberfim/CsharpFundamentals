/***************************************************************
* Name        : partialClasses - Vehicles.cs
* Author      : Anthony Hamlin
* Created     : 03/07/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Employing Partial classes       
***************************************************************/
using System;

namespace partialClasses
{
    // SailBoat
    public partial class Sailboat
    {
        private string make;
        private string model;
        private int year;
        private double price;

        // constructor
        public Sailboat(string make, string model)
        {
            this.make = make;
            this.model = model;

        }

        // overloading constructor
        public Sailboat(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
    }

    // Motorhome
    public partial class Motorhome
    {
        private string make;
        private string model;
        private int year;
        private double price;

        // constructor
        public Motorhome(string make, string model)
        {
            this.make = make;
            this.model = model;

        }

        // overloading constructor
        public Motorhome(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;

        }

        // display method
        public void describe()
        {
            Console.WriteLine($"\tMake: {make}\n\tModel: { model}");
            Console.WriteLine();
        }

        // display method for overloaded constructor
        public void describeFull()
        {
            Console.WriteLine($"\tMake: {make}\n\tModel: { model}\n\tYear: {year}\n\tPrice: {price:C}");
            Console.WriteLine();
        }
    }

    // Moped
    public partial class Moped
    {
        private string make;
        private string model;
        private int year;
        private double price;

        // constructor
        public Moped(string make, string model)
        {
            this.make = make;
            this.model = model;

        }

        // overloading constructor
        public Moped(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;

        }

        // display method
        public void describe()
        {
            Console.WriteLine($"\tMake: {make}\n\tModel: { model}");
            Console.WriteLine();
        }

        // display method for overloaded constructor
        public void describeFull()
        {
            Console.WriteLine($"\tMake: {make}\n\tModel: { model}\n\tYear: {year}\n\tPrice: {price:C}");
            Console.WriteLine();
        }
    }

}