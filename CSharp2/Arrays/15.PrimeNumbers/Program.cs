using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) + 1;
            bool[] numbers = new bool[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = true;
            }

            for (int i = 2, len = (int)Math.Sqrt(n); i < len; i++)
            {
                for (int j = 2; (i * j) < n; j++)
                {
                    numbers[j * i] = false;
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (numbers[i])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
