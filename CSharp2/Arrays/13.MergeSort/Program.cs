using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var ordered = numbers.OrderBy(x => x).ToList();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ordered[i]);
            }
        }
    }
}
