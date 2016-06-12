using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Points
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        private static Point o = new Point(0, 0, 0);

        public Point(int X, int Y, int Z) 
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public static Point O
        {
            get { return o; }
            private set { }
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", x, y, z);
        }
    }
}
