using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFruqantNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int freq = 1;
            int biggestfreq = 0;
            int numb=0;
            
            for (int i = 0; i <= input.Length-1; i++)
            {
                for (int b = 1; b <=input.Length-1; b++)
                {
                    if (input[i] == input[b])
                    {
                        freq++;
                    }
                }
                if (freq > biggestfreq)
                {
                    biggestfreq = freq;
                    numb = input[i];
                }
                freq = 0;

            }
            Console.WriteLine(numb);
        }
    }
}
