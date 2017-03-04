using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr= new int[n];
            int b = 0;
            
            for (int i =1 ; b < arr.Length; i++)
            {
                arr[b] = i;
                b++;
            }
            
            int moves = 0;
           
            for (int c = 2; c < arr.Length; c++)
            {
                if (arr[c-1] != 0)
                {
                    if (c * c <= n)
                    {
                        for (int i = c; i < arr.Length; i++)
                        {

                            moves++;
                            if (moves == c)
                            {
                                arr[i] = 0;
                                moves = 0;
                            }

                        }
                    }
                }
                moves = 0;
            }

            
            
                for (int i = 1; i < arr.Length; i++)
                {

                    if (arr[i] != 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            
        }

    }
}
