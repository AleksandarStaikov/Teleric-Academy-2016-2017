using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.indexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] letters = new char[26];
            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)(97 + i);
            }

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(Array.IndexOf(letters, text[i]));
            }

        }
    }
}
