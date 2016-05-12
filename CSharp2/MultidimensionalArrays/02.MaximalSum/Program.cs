using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizes = Console.ReadLine();
            int n = int.Parse((string)sizes.Split(' ').ToArray()[0]);
            int m = int.Parse((string)sizes.Split(' ').ToArray()[1]);
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = int.MinValue, currentSum = 0;
            for (int row = 1; row < n - 1; row++)
            {
                for (int col = 1; col < m - 1; col++)
                {
                    currentSum = matrix[row, col]
                        + matrix[row - 1, col]           //top
                        + matrix[row - 1, col + 1]       //top-right
                        + matrix[row, col + 1]           //right
                        + matrix[row + 1, col + 1]       //right-bot
                        + matrix[row + 1, col]           //bot
                        + matrix[row + 1, col - 1]       //bot-left
                        + matrix[row, col - 1]           //left
                        + matrix[row - 1, col - 1];      //left-top

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;

                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
