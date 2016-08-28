namespace _02.IEnumerableExtentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new int[] { 69, 23, 43, 42 };
            Console.WriteLine(numbers.Maxx());
        }
    }
}
