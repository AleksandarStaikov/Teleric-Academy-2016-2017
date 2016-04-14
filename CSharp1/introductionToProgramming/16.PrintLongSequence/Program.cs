using System;
namespace _16.PrintLongSequence
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("-{0}",i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
