using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine(IsSequenceIncreasing(GetAbsoluteDifferences(Console.ReadLine())));
            }
        }

        static int[] GetAbsoluteDifferences(string input)
        {
            var differences = new List<int>();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                differences.Add(Math.Abs(numbers[i] - numbers[i + 1]));
            }
            return differences.ToArray();
        }

        static bool IsSequenceIncreasing(int[] differences)
        {
            for (int i = 0; i < differences.Length - 1; i++)
            {
                if (differences[i] > differences[i + 1])
                {
                    return false;
                }
                if (Math.Abs(differences[i] - differences[i + 1]) > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
