using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] numbers = new int[len];
            for (int i = 0; i < len; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int currentSum = 0, maxSum = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    currentSum += numbers[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
                currentSum = 0;
            }
            Console.WriteLine(maxSum);
        }
    }
}
