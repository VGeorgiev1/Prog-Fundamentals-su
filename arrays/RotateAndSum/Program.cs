using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbs = input
                .Select(int.Parse)
                .ToArray();
            int[] numbs1 = new int[input.Length];
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[input.Length];
            for (int r = 1; r <= k; r++)
            {
                for (int i = 0; i <= numbs.Length - 1; i++)
                {
                    numbs1[(i + r) % input.Length] = numbs[i];

                }
               // Console.WriteLine(string.Join(" ",))
                for (int b = 0; b < numbs.Length; b++)
                {
                    sum[b] = sum[b] + numbs1[b];
                }
            }
            Console.WriteLine(string.Join(" ", sum));


        }
    }
}
