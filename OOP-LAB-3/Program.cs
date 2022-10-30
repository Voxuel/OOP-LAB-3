using System;

namespace OOP_LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new object of Geo-class and the points base class from childclasses.
            var obj = new Geometri();
            obj = new Circle();
            Console.WriteLine($"Area of the circle is : {obj.Area()}");

            obj = new Rectangle();
            Console.WriteLine($"Area of the rectangle is : {obj.Area()}");

            obj = new Square();
            Console.WriteLine($"Area of the square is : {obj.Area()}");

            Console.ReadKey();

        }
    }
}
