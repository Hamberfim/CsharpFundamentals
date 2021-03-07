/***************************************************************
* Name        : partialClasses - Program.cs
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
    public partial class Sailboat
    {
        // decribe() and describeFull() display methods here, constructors in partial Vehicle.cs class
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

    public partial class Motorhome
    {
        // decribe() and describeFull() diplay method/constructors in partial Vehicle.cs class
    }

    public partial class Moped
    {
        // decribe() and describeFull() diplay method/constructors in partial Vehicle.cs class
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Partial Classes -  Vehicle Stock";

            Console.WriteLine("===== Sailboat Stock =====");
            Sailboat laserBoat = new Sailboat("Laser", "Classic");
            laserBoat.describe();
            laserBoat = new Sailboat("Laser", "Classic", 2004, 45999);
            laserBoat.describeFull();
            Sailboat pocketCruiser = new Sailboat("Beneteau", "First 24-Pocket Cruiser");
            pocketCruiser.describe();
            pocketCruiser = new Sailboat("Beneteau", "First 24-Pocket Cruiser", 2019, 88401);
            pocketCruiser.describeFull();


            Console.WriteLine("===== RV Stock =====");
            Motorhome smallRV = new Motorhome("Moto-Craft", "Tahoe");
            smallRV.describe();
            smallRV = new Motorhome("Moto-Craft", "Tahoe", 2021, 89999);
            smallRV.describeFull();
            Motorhome wayfarer = new Motorhome("Tiffin", "Wayfarer");
            wayfarer.describe();
            wayfarer = new Motorhome("Tiffin", "Wayfarer", 2019, 114995);
            wayfarer.describeFull();


            Console.WriteLine("===== Moped Stock =====");
            Moped vespa = new Moped("Vespa", "Sei-Giorni");
            vespa.describe();
            vespa = new Moped("Vespa", "Sei-Giorni", 2021, 7749);
            vespa.describeFull();
            Moped kisbee = new Moped("Peugeot", "Kisbee 50 4T RS");
            kisbee.describe();
            kisbee = new Moped("Peugeot", "Kisbee 50 4T RS", 2019, 2538);
            kisbee.describeFull();

            Console.WriteLine("\n\n");

        }
    }

}
