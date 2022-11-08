using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    // Leo F SUT22
    class Circle : Geometri
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 4;
        }
        public override double Area()
        {
            var area = Radius * Radius * Pi;
            return Math.Round(area, 2);
        }
    }
}
