using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWordsApp
{
    class Program
    {
        static void Print(string text)
        {
            Console.Write(text + " ");
        }

        static string[] SplitText(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }

        static string[] ReversWords(string text)
        {
            string[] words = SplitText(text);
            Array.Reverse(words);
            foreach (var word in words)
            {
                Print(word);
            }
            return words;
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            ReversWords(line);
            Console.ReadKey();
        }
    }
}
