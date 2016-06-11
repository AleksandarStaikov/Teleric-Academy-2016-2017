using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecript
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cypherLen = int.Parse(input[input.Length - 1].ToString());

            StringBuilder inputMassage = new StringBuilder();
            StringBuilder cypher = new StringBuilder();
            //Remove The Last Digit And DeEncode
            inputMassage.Append(input);
            inputMassage.Remove(inputMassage.Length - 1, 1);
            inputMassage = DeEncode(inputMassage);
            //Read the Cypher
            string extractCypher = inputMassage.ToString();
            cypher.Append(extractCypher.Substring(extractCypher.Length - cypherLen, cypherLen));
            //Remove The Cypher From The Massage
            inputMassage.Remove(inputMassage.Length - cypherLen, cypherLen);

            Console.WriteLine(DeEncrypt(inputMassage, cypher));

        }

        public static StringBuilder DeEncode(StringBuilder encoded)
        {
            var deEncoded = new StringBuilder();
            bool multiply = false;
            int multiplyRatio = 1;
            for (int i = 0; i < encoded.Length; i++)
            {
                char currentChar = encoded[i];
                if (multiply)
                {
                    deEncoded.Append(currentChar, multiplyRatio);
                    multiply = false;
                }
                else if (char.IsDigit(currentChar))
                {
                    multiply = true;
                    multiplyRatio = int.Parse(currentChar.ToString());
                }
                else
                {
                    deEncoded.Append(currentChar);
                }

            }

            return deEncoded;
        }

        public static StringBuilder DeEncrypt(StringBuilder massage, StringBuilder cypher)
        {
            int massagelen = massage.Length;
            int highestLen = Math.Max(massage.Length, cypher.Length);
            StringBuilder deEncryptedMassade = new StringBuilder();
            deEncryptedMassade.Append(massage);
            for (int i = 0; i < highestLen; i++)
            {
                deEncryptedMassade[i % massagelen] = (BitWiseXOR(deEncryptedMassade[i % massagelen], cypher[i % cypher.Length]));
            }
            return deEncryptedMassade;
        }

        public static char BitWiseXOR(char massage, char cypher)
        {
            massage = (char)(massage - 'A');
            cypher = (char)(cypher - 'A');
            int bitwised = int.Parse(Convert.ToString(massage ^ cypher));
            return (char)(bitwised + 65);
        }
    }
}
