using System;

namespace classInheritance
{
    class Program
    {
        // polygon - base class
        public class Polygon
        {
            protected int width, height;

            // setter/getter methods
            public void setValues(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        // Rectangle -inherits width & height vars from polygon base class
        public class Rectangle:Polygon
        {
            public int area()
            {
                return (width * height);
            }
        }

        // Triangle -inherit width & height vars from from polygon base class
        public class Triangle:Polygon
        {
            public int area()
            {
                return ((width * height) / 2);
            }
        }


        static void Main(string[] args)
        {
            // instance of Rectangle that inherits from Polygon
            Rectangle rect = new Rectangle();
            rect.setValues(4, 5);

            // instance of Triangle that inherits from Polygon
            Triangle cone = new Triangle();
            cone.setValues(4, 5);

            // display properties of inherited objects
            Console.WriteLine($"Rectangle area is {rect.area()}");

            Console.WriteLine();

            Console.WriteLine($"Triangle area is {cone.area()}");


            Console.WriteLine("\n\n\n");
        }
    }
}
