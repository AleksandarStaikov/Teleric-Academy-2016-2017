using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.selectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int smalest = numbers[i];
                int smalestIndex = i;
                for (int k = i; k < n; k++)
                {
                    if (smalest > numbers[k])
                    {
                        smalestIndex = k;
                        smalest = numbers[k];
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[smalestIndex];
                numbers[smalestIndex] = temp;
            }
            Print(numbers);
        }
        static void Print(int[] numbers) 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
