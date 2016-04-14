using System;
namespace _01.OddOrEven
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (Math.Abs(number % 2) == 1)
            {
                Console.WriteLine("odd {0}",number);
            }
            else
            {
                Console.WriteLine("even {0}", number);
            }
        }
    }
}
