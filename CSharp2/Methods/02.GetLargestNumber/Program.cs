using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int[] numbers = a.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(GetMax(numbers[0], GetMax(numbers[1], numbers[2])));
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
