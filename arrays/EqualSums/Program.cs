using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftsum = 0;
            int rightsum = 0;
            int i = 0;
            bool found = false;
            for (i = 0; i < input.Length; i++)
            {
                if (i - 1 < 0)
                {
                    rightsum=Right(input, i);
                    if (rightsum == 0)
                    {
                        Console.WriteLine(i);
                        found = true;
                        break;
                    }
                }
                else if (i + 1 >= input.Length)
                {
                    leftsum = Left(input, i);
                    if (leftsum == 0)
                    {
                        Console.WriteLine(i);
                        found = true;
                        break;
                    }
                }
                else
                {
                    rightsum= Right(input, i);
                    leftsum = Left(input, i);
                    if (leftsum == rightsum)
                    {
                        Console.WriteLine(i);
                        found = true;
                        break;
                    }
                }
                
                    
                
           }
            if (found == false)
            {
                Console.WriteLine("no");
            }
        }

        private static int Left(int[] input, int i)
        {
            int sum = 0;
            int b= i - 1;
            do
            {
                sum = sum + input[b];
                b--;
            } while (b >= 0);
            return sum;

        }

        private static int Right(int[] input, int i)
        {
            int sum = 0;
            for (int b = i+1; b < input.Length; b++)
            {
                sum = sum + input[b];
            }
            return sum;
        }

    }
}
