using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    internal class Rectangle : Geometri
    {
        private double Side { get; set; }

        public Rectangle()
        {
            _side = 7;
        }

        public override double Area()
        {
            return _side * _side;
        }
    }
}
