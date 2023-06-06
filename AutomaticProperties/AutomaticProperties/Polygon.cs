using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    internal class Polygon
    {
        public int NumSides { get; set; }
        public double SideLength { get; set; }

        public Polygon()
        {
            this.NumSides = 4;
            this.SideLength = 10.0;
        }
    }
}
