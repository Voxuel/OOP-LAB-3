using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    internal class Geometri
    {
        private double _pi = 3.141;
        public double Radius { get; set; }

        public Geometri()
        {

        }

        public virtual double Area()
        {
            return 0;
        }
    }
}
