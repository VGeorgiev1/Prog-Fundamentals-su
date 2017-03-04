using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsbyDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int dif = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (
                int i = 0; i <= input.Length-1; i++)
            {
                for (int b = i; b <= input.Length-1; b++)
                {
                    if (Math.Abs(input[i] - input[b])==dif)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
