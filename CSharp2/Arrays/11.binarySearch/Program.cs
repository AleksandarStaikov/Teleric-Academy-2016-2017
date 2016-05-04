using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _11.binarySearch
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
            int searched = int.Parse(Console.ReadLine());
            bool flag = true;
            int bottom = 0, top = len - 1;
            if (numbers[bottom] == searched)
            {
                Console.WriteLine(bottom);
                return;
            }
            if (numbers[top] == searched)
            {
                Console.WriteLine(top);
                return;
            }
            while (flag)
            {
                int middle = (bottom + top) / 2;
                if (numbers[middle] == searched)
                {
                    Console.WriteLine(middle);
                    flag = false;
                    break;
                }
                else if (numbers[middle] > searched)
                {
                    top = middle;
                }
                else
                {
                    bottom = middle;
                }
                if (bottom == top - 1)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }
        }
    }
}
