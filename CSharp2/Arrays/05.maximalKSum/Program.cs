using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.maximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            for (int i = 0; i < n; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            var numbers = first.OrderByDescending(x => x).ToList();
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
