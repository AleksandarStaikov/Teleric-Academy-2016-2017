using System;
namespace MoonGravity
{
    class Program
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F3}", weight * 17 / 100);
        }
    }
}
