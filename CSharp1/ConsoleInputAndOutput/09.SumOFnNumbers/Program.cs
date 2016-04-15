using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOFnNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
