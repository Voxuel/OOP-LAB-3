using System;

namespace OOP_LAB_3
{
    // Leo F SUT22
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new object of Geo-class and then points base class from childclasses.
            Geometri obj;
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
