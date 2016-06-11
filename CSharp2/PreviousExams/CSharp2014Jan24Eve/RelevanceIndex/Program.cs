using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{

    class Program
    {
        static string specialWord;
        static int paragraphsCount;
        static List<List<string>> paragraphs;
        static void Main(string[] args)
        {
            specialWord = Console.ReadLine().ToLower();
            paragraphsCount = int.Parse(Console.ReadLine());
            Initialize();
            paragraphs = paragraphs.OrderByDescending(x => x.Count(z => z == specialWord)).ToList();

            for (int i = 0; i < paragraphs.Count; i++)
            {
                for (int j = 0; j < paragraphs[i].Count; j++)
                {
                    if (paragraphs[i][j] == specialWord)
                    {
                        paragraphs[i][j] = specialWord.ToUpper();
                    }
                }
            }

            foreach (var paragraph in paragraphs)
            {
                Console.WriteLine(string.Join(" ", paragraph));
            }
        }


        static void Initialize()
        {
            paragraphs = new List<List<string>>();
            for (int i = 0; i < paragraphsCount; i++)
            {
                paragraphs.Add(Console.ReadLine()
                    .Split(new[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToList());
            }
        }
    }
}
