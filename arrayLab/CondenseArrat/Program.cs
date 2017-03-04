using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int i;
            int[] condensed = new int[input.Length - 1];
            do
            {
                for (i = 0; i < condensed.Length; i++)
                {
                    if (i + 1 < input.Length)
                    {
                        condensed[i] = input[i] + input[i + 1];
                    }
                }
                input = condensed;
                //5 4 5 3
                //9 9 8
                //18 17

            } while (input.Length!=1);
            

        }
    }
}
