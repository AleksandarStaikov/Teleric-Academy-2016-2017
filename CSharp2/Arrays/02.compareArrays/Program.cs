using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.compareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 0; i < n; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                second[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Enumerable.SequenceEqual(first, second)?"Equal":"Not equal");
        }
    }
}
