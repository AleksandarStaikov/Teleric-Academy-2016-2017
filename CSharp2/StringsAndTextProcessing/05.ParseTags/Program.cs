using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool inUpperCase = false;
            StringBuilder parsedText = new StringBuilder();

            var splitedText = text.Split(new[] { "<upcase>", "</upcase>" } ,StringSplitOptions.None);

            for (int i = 0; i < splitedText.Length; i++)
            {
                if (i % 2 == 0)
                {
                    parsedText.Append(splitedText[i]);
                }
                else
                {
                    parsedText.Append(splitedText[i].ToUpper());
                }
            }

            Console.WriteLine(parsedText);

        }
    }
}
