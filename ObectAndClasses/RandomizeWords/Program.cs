using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < sentence.Length-1; i++)
            {
                string currentWord = sentence[i];
                int numb=rnd.Next(0, sentence.Length - 1);
                sentence[i] = sentence[numb];
                sentence[numb] = currentWord;

            }
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
        }
    }
}
