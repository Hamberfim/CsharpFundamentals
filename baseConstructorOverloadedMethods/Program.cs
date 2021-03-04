using System;

namespace baseConstructorOverloadedMethods
{
    class Program
    {
        // base parent class
        public class Parent
        {
            // default constructor
            public Parent()
            {
                Console.WriteLine("Default Parent constructor called");
            }

            // overloaded constructor
            public Parent(int num)
            {
                Console.WriteLine("\tOverloaded Parent constructor called: " + num);
            }

        }

        // derived class
        public class Daughter : Parent
        {
            // default constructor
            public Daughter()
            {
                Console.WriteLine("\tDaughter : Parent derived class default constructor Called\n");
            }
        }

        // derived class
        public class Son : Parent
        {
            // default constructor

            public Son()
            {
                Console.WriteLine("\tSon : Parent derived class default constructor Called\n");
            }

            // overloaded constructor
            public Son(int num):base(num)
            {
                Console.WriteLine("\tSon : Parent derived class overloaded constructor called: " + num);
            }

        }


        static void Main(string[] args)
        {
            Parent Anthony = new Parent();
            Parent Shelly = new Parent(50);

            Daughter Lillie = new Daughter();

            Son Tony = new Son();
            Son Andrew = new Son(100);

            Console.WriteLine("\n\n\n");
        }
    }
}
