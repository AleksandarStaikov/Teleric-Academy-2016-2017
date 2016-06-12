using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Points
{
    public static class Distance
    {
        public static double Calculate(Point p1, Point p2)
        {
            double x = p2.x - p1.x;
            double y = p2.y - p1.y;
            double z = p2.z - p1.z;

            double partEcuasion = x*x + y*y + z*z;

            return Math.Sqrt(partEcuasion); 
        }
    }
}
