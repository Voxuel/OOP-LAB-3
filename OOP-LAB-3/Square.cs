using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    class Square : Geometri
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 10;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
