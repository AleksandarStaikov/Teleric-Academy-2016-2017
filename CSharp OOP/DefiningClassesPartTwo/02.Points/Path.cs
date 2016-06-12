using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Points
{
    class Path
    {
        private List<Point> path;

        public Path()
        {
            this.path = new List<Point>();
        }

        public void AddPoint(Point p)
        {
            path.Add(p);
        }

        public void RemoveLastPoint()
        {
            path.RemoveAt(path.Count - 1);
        }

        public void DisplayPath()
        {
            foreach (var point in path)
            {
                Console.WriteLine(point.ToString());
            }
        }
    }
}
