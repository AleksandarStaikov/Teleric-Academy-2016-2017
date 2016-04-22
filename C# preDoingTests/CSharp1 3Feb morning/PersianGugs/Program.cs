using System;
namespace PersianGugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int triangle = first - second - 1;//5 and 2 => 5-2-1 =>2 // 3 and 0 => 3-0-1 => 2 

            for (int i = 0; i < first; i++)
            {
                //Checks if there will be a triangle in the middle
                if (i >= triangle)//no
                {
                    Console.Write(new string('#', i));
                    Console.Write("\\");
                    Console.Write(new string(' ', (first * 2 + 1) - ((i + 1) * 2)));
                    Console.Write("/");
                    Console.Write(new string('#', i));
                }
                else//yes
                {
                    Console.Write(new string('#', i));
                    Console.Write("\\");
                    Console.Write(new string(' ', second));
                    Console.Write("\\");
                    Console.Write(new string('.', first * 2 + 1 - (i * 2 + second * 2 + 4)));
                    Console.Write("/");
                    Console.Write(new string(' ', second));
                    Console.Write("/");
                    Console.Write(new string('#', i));
                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}X{0}", new string('#', first));

            for (int i = first - 1; i > -1; i--)
            {
                //Checks if there will be a triangle in the middle
                if (i >= triangle)//no
                {
                    Console.Write(new string('#', i));
                    Console.Write("/");
                    Console.Write(new string(' ', (first * 2 + 1) - ((i + 1) * 2)));
                    Console.Write("\\");
                    Console.Write(new string('#', i));
                }
                else//yes
                {
                    Console.Write(new string('#', i));
                    Console.Write("/");
                    Console.Write(new string(' ', second));
                    Console.Write("/");
                    Console.Write(new string('.', first * 2 + 1 - (i * 2 + second * 2 + 4)));
                    Console.Write("\\");
                    Console.Write(new string(' ', second));
                    Console.Write("\\");
                    Console.Write(new string('#', i));
                }
                Console.WriteLine();
            }
        }
    }
}
