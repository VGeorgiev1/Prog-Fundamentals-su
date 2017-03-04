using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int seq = 1;
            int longest = 0;
            int numb=0;
            int firstbest = 0;
            int foundFirst = 0;
            for (int i = 0; i <= input.Length-2; i++)
            {
                if (input[i] == input[i + 1])
                {
                    seq++;
                    if (seq > longest)
                    {
                       
                        longest = seq;
                        numb = input[i];
                        firstbest = longest;
                    }
                    foundFirst++;

                }
                else
                {
                    if (foundFirst != 0 && seq == longest)
                    {
                        longest = firstbest;
                    }
                    
                        seq = 1;
                    
                }
               

            }
            //Console.WriteLine(longest);
            //Console.WriteLine(numb);
            int[] output = new int[longest];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = numb;
            }
            Console.Write(string.Join(" ", output));


        }
    }
}
