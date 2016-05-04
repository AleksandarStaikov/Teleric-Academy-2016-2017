using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.maximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            for (int i = 0; i < n; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            int currentLen = 1, maxLen = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (first[i] <= first[i + 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                    }
                }
                else
                {
                    currentLen = 1;
                }

            }
            Console.WriteLine(maxLen);

        }
    }
}
