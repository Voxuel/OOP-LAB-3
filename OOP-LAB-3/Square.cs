using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    class Square : Geometri
    {
        public Square()
        {
            _side = 10;
        }

        public override double Area()
        {
            return _side * _side;
        }
    }
}
