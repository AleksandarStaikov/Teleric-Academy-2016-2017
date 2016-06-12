using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Points
{
    class StartinPoint
    {
        static void Main(string[] args)
        {
            //Testing The Distance Calculator
            var myPoint = new Point(4, 9, 2);
            Console.WriteLine(Distance.Calculate(myPoint, Point.O));
            
            //Testting The Path Class
            var path = new Path();
            var list = new List<Point>();
            for (int i = 0; i < 10; i++)
            {
                path.AddPoint(new Point(i, i + 1, i + 2));
                list.Add(new Point(i, i + 1, i + 2));
            }   

            //Testting The PathStorage Class
            PathStorage.WritePath(list);
            List<Point> read = PathStorage.ReadPath();
            foreach (var item in read)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
