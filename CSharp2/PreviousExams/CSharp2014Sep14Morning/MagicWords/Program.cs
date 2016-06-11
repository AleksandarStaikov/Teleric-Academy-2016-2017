using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }
            Reorder(words, n);
            Print(words);
        }

        static void Reorder(List<String> words, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string currentWord = words[i];
                words[i] = null;
                words.Insert(currentWord.Length % (n + 1), currentWord);
                words.Remove(null);
            }
        }
        static void Print(List<String> words)
        {

            var length = words.Max(x => x.Length);
            var result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        result.Append(word[i]);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
