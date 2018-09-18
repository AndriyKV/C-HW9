using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    //Create struct Point
    public struct Point
    {
        //fields x and y
        public double X, Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //method Distance() to calculate distance between points
        public double Distance(Point p)
        {
            return Convert.ToDouble(Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y)));
        }

        //method ToString(), which return the Point in format "(x,y)"
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

    }
}
