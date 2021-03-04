using System;

namespace baseMethodHiding
{
    class Program
    {
        // base class
        public class Man
        {

            // default constructor
            public void speak()
            {
                Console.WriteLine("Hello ");
            }

            // overloading
            public void speak(string message)
            {
                Console.WriteLine(message + "!\n");
            }

        }

        // derived class
        public class Hombre : Man
        {
            public new void speak(string message)
            {
                Console.WriteLine(message);
                base.speak();
            }
        }

        static void Main(string[] args)
        {
            Man henry = new Man();
            henry.speak();  // defalut constructor call
            henry.speak("It's a beautiful day");

            Hombre enrique = new Hombre();
            enrique.speak("Hola ");
            ((Man)enrique).speak("Es una tarde hermosa");



            Console.WriteLine("\n\n");
        }
    }
}
