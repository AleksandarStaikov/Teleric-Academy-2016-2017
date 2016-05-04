using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.frequentNumber
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

            var orderedNumbers = numbers.OrderBy(x => x).ToList();
            int currentSequence = 1, longestSequence = 1;
            int number = -1;
            for (int i = 0; i < len - 1; i++)
            {
                if (orderedNumbers[i] == orderedNumbers[i + 1])
                {
                    currentSequence++;
                    if (longestSequence < currentSequence)
                    {
                        longestSequence = currentSequence;
                        number = orderedNumbers[i];
                    }

                }
                else
                {
                    currentSequence = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", number, longestSequence);
        }
    }
}
