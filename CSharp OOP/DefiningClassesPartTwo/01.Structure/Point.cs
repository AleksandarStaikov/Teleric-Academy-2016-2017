using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structure
{
    public struct Point
    {
        private int x { get; set; }
        private int y { get; set; }
        private int z { get; set; }
        private static Point o = new Point(0, 0, 0);

        public Point(int X, int Y, int Z)
            : this()
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public static string O
        {
            get { return o.ToString(); }
            private set { }
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", x, y, z);
        }
    }
}
