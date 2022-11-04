using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_3
{
    internal class Geometri
    {
        public double Pi = Math.PI;
        public Geometri()
        {

        }
        /// <summary>
        /// Method that is derived later to return Area of an object.
        /// </summary>
        /// <returns>Area of object specified in double</returns>
        public virtual double Area()
        {
            return 0;
        }
    }
}
