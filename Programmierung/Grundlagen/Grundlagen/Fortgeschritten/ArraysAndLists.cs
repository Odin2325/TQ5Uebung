using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Fortgeschritten
{
    internal class ArraysAndLists
    {
        private Outputs outputs;

        public int[] reverseArray = { 1, 2, 3, 4, 5 };
        public double[] findIndex = { 1.1, 2.2, 3.3, 4.4, 5.5 };

        public ArraysAndLists() 
        { 
            outputs = new Outputs();
        }

        public void ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            string result = string.Join(", ", reversedArray);
            outputs.NormalOutput(result);
        }

        public int FindIndex(double[] array, double target)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public string GenerateRandomWord(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Die Länge muss größer als 0 sein.");
            }

            Random random = new Random();
            StringBuilder wordBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int charType = random.Next(0, 52);

                char randomChar;
                if (charType < 26)
                {
                    randomChar = (char)(charType + 97); 
                }
                else
                {
                    randomChar = (char)(charType - 26 + 65);
                }

                wordBuilder.Append(randomChar);
            }

            return wordBuilder.ToString();
        }

        public Tuple<List<string>, List<string>> Pangram()
        {
            List<string> originalWords = new List<string>();
            List<string> reversedWords = new List<string>();

            Console.WriteLine("Geben Sie Wörter ein. Geben Sie 'stop' ein, um die Eingabe zu beenden:");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break;
                }

                originalWords.Add(input);
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                reversedWords.Add(new string(charArray));
            }

            Console.ResetColor();
            return Tuple.Create(originalWords, reversedWords);
        }
    }
}
