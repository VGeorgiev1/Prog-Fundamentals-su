using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] firstrow = new int[input.Length / 4];
            int[] secondrow= new int[input.Length / 4];
            int b = 1;
            for (int i = 0; input.Length / 4 - b>=0; i++)
            {
                firstrow[i] = input[input.Length / 4 - b];
                
                b++;
            }
            b = 1;
            for (int i = 0;i<secondrow.Length; i++)
            {
                secondrow[i] = input[input.Length - b];
                b++;
            }
            b = 0;
            for (int i = input.Length/4;b<firstrow.Length; i++)
            {
                input[i] = input[i] + firstrow[b];
                b++;
            }
            b = secondrow.Length-1;
            for (int i = input.Length-secondrow.Length-1; b >=0; i--)
            {
                input[i] = input[i] + secondrow[b];
                b--;
            }
            // Console.WriteLine(string.Join(" ",firstrow));
            // Console.WriteLine(string.Join(" ", secondrow));
            // Console.WriteLine(string.Join(" ",input));
            for (int i = firstrow.Length; i < input.Length-secondrow.Length; i++)
            {
                Console.Write(input[i] + " ");

            }


        }
    }
}
