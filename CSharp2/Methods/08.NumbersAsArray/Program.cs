using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersAsArray
{
    class Program
    {

        
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] resultArray = new int[ArrayLength(input[0], input[1])];
            int length = ArrayLength(input[0], input[1]);
            var firstArrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondArrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", AddLists(firstArrayOfNumbers, secondArrayOfNumbers, length)));
        }

        public static int[] AddLists(List<int> firstArray, List<int> secondArray, int length)
        {
            //List<int> resultArray = new List<int>();
            var resultArray = new int[length];
            EqualizeLists(firstArray, secondArray);

            for (int i = 0; i < resultArray.Length; i++)
            {
                int sum = firstArray[i] + secondArray[i];
                if (sum >= 10)
                {
                    resultArray[i] = sum - 10;
                    if (i < length - 1)
                    {
                        firstArray[i + 1] += 1;
                    }
                }
                else
                {
                    resultArray[i] = sum;
                }
            }

            return resultArray;
        }

        static int ArrayLength(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        public static void EqualizeLists(List<int> firstArray, List<int> secondArray)
        {
            int firstListLength = firstArray.Count;
            int secondListLength = secondArray.Count;

            if (firstListLength > secondListLength)
            {
                int numbersToAdd = firstListLength - secondListLength;
                for (int i = 0; i < numbersToAdd; i++)
                {
                    secondArray.Add(0);
                }
            }
            else
            {
                int numbersToAdd = secondListLength - firstListLength;
                for (int i = 0; i < numbersToAdd; i++)
                {
                    firstArray.Add(0);
                }
            }
        }







        //static void Main(string[] args)
        //
        //  Console.ReadLine();
        //  string[] firstNumbers = Console.ReadLine().Split(' ').ToArray();
        //  string[] secondNumbers = Console.ReadLine().Split(' ').ToArray();
        //  string result = SumArrays(firstNumbers, secondNumbers);
        //  string joined = SplitEachChar(result);
        //  Console.WriteLine(joined);
        //
        //static string SumArrays(string[] firstArray, string[] secondArray)
        //
        //  int shortestArrayLen = Math.Min(firstArray.Length, secondArray.Length);
        //  if (firstArray.Length < secondArray.Length)
        //  {
        //
        //      string paded = Reverse(string.Join("", firstArray)).PadLeft(secondArray.Length, '0');
        //      int numbersA = int.Parse(paded);
        //      int numbersB = int.Parse(Reverse(string.Join("", secondArray)));
        //      numbersA += numbersB;
        //
        //      return Reverse(numbersA.ToString());
        //  }
        //  else
        //  {
        //
        //      string paded = Reverse(string.Join("", secondArray)).PadLeft(firstArray.Length, '0');
        //      int numbersA = int.Parse(paded);
        //      int numbersB = int.Parse(Reverse(string.Join("", firstArray)));
        //      numbersA += numbersB;
        //      return Reverse(numbersA.ToString());
        //  }
        //
        //static string Reverse(string s)
        //
        //  char[] charArray = s.ToCharArray();
        //  Array.Reverse(charArray);
        //  return new string(charArray);
        //
        //static string SplitEachChar(string input)
        //{
        //    StringBuilder str = new StringBuilder();
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        str.Append(input[i]);
        //        if (i < input.Length - 1)
        //        {
        //            str.Append(" ");
        //        }
        //    }
        //    return str.ToString();
        //}
    }
}
