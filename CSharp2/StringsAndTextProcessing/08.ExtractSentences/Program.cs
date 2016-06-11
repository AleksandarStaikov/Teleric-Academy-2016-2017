using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string[] sentances = Console.ReadLine().Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var extractedSentances = new StringBuilder();

            foreach (var sentance in sentances)
            {
                var wordsInSentance = SplitByNonLetterSymbol(sentance);
                if (wordsInSentance.Contains(pattern))
                {
                    extractedSentances.Append(sentance);
                    extractedSentances.Append(".");
                }
            }
            Console.WriteLine(extractedSentances);
        }

        static string[] SplitByNonLetterSymbol(string sentance)
        {
            sentance = sentance.Trim();
            var words = new List<string>();
            int startingIndex = 0;
            for (int i = 0; i < sentance.Length; i++)
            {
                char currentSymbol = sentance[i];
                if (!char.IsLetter(currentSymbol))
                {
                    words.Add(sentance.Substring(startingIndex, i - startingIndex));
                    startingIndex = i + 1;
                }
            }
            return words.ToArray();
        }
    }
}
