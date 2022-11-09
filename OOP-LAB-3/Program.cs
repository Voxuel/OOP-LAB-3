using System;

namespace OOP_LAB_3
{
    // Leo F SUT22
    class Program
    {
        static void Main(string[] args)
        {
            Geometri circle = new Circle();
            Console.WriteLine($"Area of the circle is : {circle.Area()}");

            Geometri rectangle = new Rectangle();
            Console.WriteLine($"Area of the rectangle is : {rectangle.Area()}");

            Geometri square = new Square();
            Console.WriteLine($"Area of the square is : {square.Area()}");

            Console.ReadKey();
        }
    }
}
