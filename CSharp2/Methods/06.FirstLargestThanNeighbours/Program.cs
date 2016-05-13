using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstLargestThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(LargerThanNeighboursCount(numbers));
        }
        static int LargerThanNeighboursCount(int[] numbers)
        {
            int counter = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
