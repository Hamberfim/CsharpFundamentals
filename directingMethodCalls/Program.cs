using System;

namespace directingMethodCalls
{
    class Program
    {
        public class Bird
        {
            public virtual void talk()
            {
                Console.WriteLine("A bird talks...");
            }

            public virtual void fly()
            {
                Console.WriteLine("A bird flies...");
            }
        }

        // derived class
        public class Pigeon : Bird
        {
            public override void talk()
            {
                Console.WriteLine("Pigeon says: coo! coo!");
            }

            public override void fly()
            {
                Console.WriteLine("A pigeon flies away...");
                base.fly();  // use the 'base' keyword to call a base class method from a derived class
            }
        }

        public class Chicken : Bird
        {
            public override void talk()
            {
                Console.WriteLine("Chicken says: cluck! cluck!");
            }

            public override void fly()
            {
                Console.WriteLine("I'm a chicken. I really can't fly much...");
                base.fly();  // use the 'base' keyword to call a base class method from a derived class
            }
        }


        static void Main(string[] args)
        {
            // method to call Bird class
            static void describeBird(Bird obj)
            {
                obj.talk();
                obj.fly();
            }

            Pigeon knuckles = new Pigeon();
            describeBird(knuckles);

            Console.WriteLine();

            Chicken mrcluckcluck = new Chicken();
            describeBird(mrcluckcluck);



            Console.WriteLine("\n\n");
        }
    }
}
