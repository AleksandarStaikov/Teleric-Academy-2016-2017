namespace _01.StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder MyStringBuilder = new StringBuilder("Hello World!");
            Console.WriteLine(MyStringBuilder.CustomSubstring(0, 5));
        }
    }

    public static class StringBuilderExtentionMethods
    {
        public static string CustomSubstring(this StringBuilder text, int startIndex, int Len)
        {
            var str = new StringBuilder();
            for (int i = startIndex; i < startIndex + Len; i++)
            {
                str.Append(text[i]);
            }
            return str.ToString();
        }
    }
}
