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
            int[] numb = new int[input.Length];
            int b = 0;
            int firstbest = 0;
            int foundFirst = 0;
            for (int i = 0; i <= input.Length - 2; i++)
            {
                if (input[i+1]-input[i]>=1)
                {
                    seq++;
                    if (seq >= longest )
                    {
                        if (firstbest != 0 && seq != longest)
                        {
                            longest = seq;
                            numb[b] = input[i];
                            firstbest++;
                            b++;
                            numb[b] = input[i + 1];
                        }
                    }

                    foundFirst++;

                }
                else
                {
                    if (foundFirst != 0 && seq == longest)
                    {
                       longest = firstbest;
                    }
                    b = 0;
                    
                    seq = 1;
                }


            }



            for (int i = 0; i < numb.Length; i++)
            {
                if (i + 1 > numb.Length-1)
                {
                    Console.Write(numb[i]);
                    break;
                }
                    if (numb[i]==0 && numb[i + 1] == 0)
                    {
                        
                        break;
                    }
                    Console.Write(numb[i]+" ");
                }
            }


        }
    }

