#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        public Point()
        {
            Console.WriteLine("Default Constructor called");
        } 
        public Point(int x, int y)
        {
            Console.WriteLine($"x:{x}, y:{y}");
            this.x = x;
            this.y = y;
        }
    }
}
