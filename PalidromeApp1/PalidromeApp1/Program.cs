using System;
using System.Collections.Generic;
using System.IO;

namespace PalidromeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrPalidrome = new List<string>();
            string filePath = @"C:\\Users\Desktop\palindromes.txt";
            string[] allLines = File.ReadAllLines(filePath);


            foreach (string line in allLines)
            {
                var tempWord = line;

                char[] charArray = line.ToCharArray();

                Array.Reverse(charArray);

                var reversedWord = new string(charArray);

                if (tempWord.Equals(reversedWord))
                {
                    arrPalidrome.Add(tempWord);
                }

            }

            for (int i = 0; i < arrPalidrome.Count; i++)
            {
                Console.WriteLine(arrPalidrome[i]);
            }
        }

    }
}

