using System;

namespace baseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the Person object
            Person billy = new Person();
            // properties of billy
            billy.FName = "William";
            billy.LName = "Tell";
            billy.Age = 35;

            // call the method that concatenates the person info
            Console.WriteLine(billy.GetPersonInfo());

            // call the property that mimics part of the method
            Console.WriteLine(billy.FullName);


            Console.WriteLine("\n\n");
        }
    }
}
