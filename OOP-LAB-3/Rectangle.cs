using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    internal class Rectangle : Geometri
    {
        public double Side { get; set; }

        public Rectangle()
        {
            Side = 7;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
