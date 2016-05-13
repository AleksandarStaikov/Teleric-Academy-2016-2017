using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string asa = Console.ReadLine();
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            int searched = int.Parse(Console.ReadLine());
            Console.WriteLine(numbers.Where(x => x == searched).Count());

        }
    }
}
