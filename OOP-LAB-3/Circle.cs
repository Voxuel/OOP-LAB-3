using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    class Circle : Geometri
    {
        public Circle()
        {
            _radius = 4;
        }
        public override double Area()
        {
            var area = _radius * _radius * _pi;
            return Math.Round(area, 2);
        }
    }
}
