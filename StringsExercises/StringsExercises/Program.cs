using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string line1 = input[0];
            string line2 = input[1];
            int sum = 0;
            int i;
            string smaller;
            string bigger;
            if (line1.Length == line2.Length)
            {
                for (int b = 0; b < line1.Length; b++)
                {
                    sum = sum + line1[b] * line2[b];
                }
            }
            else
            {
                if (line1.Length > line2.Length)
                {
                     smaller = line2;
                     bigger = line1;
                }
                else
                {
                     smaller = line1;
                     bigger = line2;
                }
                for ( i = 0; i < smaller.Length; i++)
                {
                    sum = sum + smaller[i] * bigger[i];
                }
                for ( ;  i< bigger.Length; i++)
                {
                    sum = sum + bigger[i];
                }
                
            }
            Console.Write(sum);
        }
    }
}
