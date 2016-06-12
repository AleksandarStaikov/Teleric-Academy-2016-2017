using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Points
{
    public static class PathStorage
    {
        private static List<Point> path = new List<Point>();
        private static string fileLoacation = @"../../ReadNWrite";
        private static List<string> paths = new List<string>();

        public static void WritePath(List<Point> path)
        {
            File.Delete(fileLoacation);
            foreach (var point in path)
            {
                paths.Add(point.ToString());
            }
            File.AppendAllLines(fileLoacation, paths);
        }

        public static List<Point> ReadPath()
        {
            path.Clear();
            string[] readText = File.ReadAllLines(fileLoacation);
            foreach (string item in readText)
            {
                string[] coords = item.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                path.Add(new Point(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2])));
            }
            return path;
        }
    }
}
