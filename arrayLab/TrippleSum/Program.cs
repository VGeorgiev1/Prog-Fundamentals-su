using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int found = 0;
            int[] notSame=new int[input.Length - 2];
            int okey = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int b = 1; b <= input.Length - 1; b++)
                {
                    if (i != b)
                    {
                        sum = input[i] + input[b];
                        for (int c = 0; c < input.Length; c++)
                        {
                            if (sum == input[c])
                            {
                                for (int h = 0; h < notSame.Length; h++)
                                {
                                    if (input[b] == notSame[h])
                                    {
                                        okey--;
                                        break;
                                    }
                                }
                                if (okey != 0) { }
                                Console.WriteLine(input[i] + " + " + input[b] + " == " + sum);
                                found++;

                            }
                        }
                        sum = 0;
                    }
                }
            }
            if (found == 0)
            {
                Console.WriteLine("No");
            }
        }

    }
}
