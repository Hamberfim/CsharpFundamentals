using System;

namespace baseConstructorsMore
{
    class Program
    {
        // base class
        public class Vehicle
        {
            // default constructor
            public Vehicle()
            {
                Console.WriteLine("Vehicle: overly simplified - object only");
            }

            // overloaded constructor
            public Vehicle(string name)
            {
                Console.WriteLine($"Vehicle: {name}");
            }

            // overloaded constructor
            public Vehicle(string name, string powered)
            {
                Console.WriteLine($"Vehicle: {name}, Power: {powered}");
            }

            // overloaded constructor
            public Vehicle(string name, string powered, int wheels)  // **
            {
                Console.WriteLine($"Vehicle: {name}, Power: {powered}, Wheels: {wheels}");  
            }

        }

        public class Truck : Vehicle
        {
            // default constructor
            public Truck()
            {
                Console.WriteLine("Vehicle: Truck - overly simplified - object only");
            }
            
            // overloaded constructor drived class
            public Truck(string name, string type, string powered, int wheels) :base(name, powered, wheels)  // **
            {
                Console.WriteLine($"Vehicle: {name}, Type: {type}, Power: {powered}, Wheels: {wheels}");
            }
        }




        static void Main(string[] args)
        {
            // call Vehicle class and overloaded constructors
            Console.WriteLine("===== VEHICLES =====");
            Vehicle baseVehicle = new Vehicle();  // default constructor with no parameters
            Vehicle nameVehicle = new Vehicle("skate board");  //
            Vehicle bicycleVehicle = new Vehicle("bicycle", "human");
            Vehicle tricycleVehicle = new Vehicle("tricycle", "human", 3);
            Vehicle vespaVehicle = new Vehicle("vespa scooter", "single-cylinder four-stroke hpe", 2);

            Console.WriteLine();  // space in output

            Console.WriteLine("===== TRUCKS =====");
            // returns both the default constructors of the vehicle and the derive truck
            Truck pickup = new Truck();
            // returns both the overload constructors of the vehicle and the derive truck where the var-parameter match. -see **note mark
            Truck dump = new Truck("Kenworth T880", "dump truck", "PACCAR MX-13 12.9L I6 380-500hp", 6);  


            Console.WriteLine("\n\n");
        }
    }
}
