using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray().OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
