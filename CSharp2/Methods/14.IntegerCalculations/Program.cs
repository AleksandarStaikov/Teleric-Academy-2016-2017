using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            Console.WriteLine(numbers.Min(x => x));
            Console.WriteLine(numbers.Max(x => x));
            Console.WriteLine("{0:F2}", numbers.Average(x => x));
            Console.WriteLine(numbers.Sum(x => x));
            Console.WriteLine(numbers.Aggregate((acc, val) => acc * val));

        }
    }
}
