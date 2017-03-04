using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
          
            int currentNum = 0;
            int seq = 1;
            for (int i = 0; i < input.Count; i++)
            {
                currentNum = input[i];
                if (i + 1 == input.Count)
                {
                    Console.WriteLine(input[i] + " -> " + seq);
                }
               else  if (currentNum == input[i + 1])
                {
                    seq++;
                }
                else if(currentNum!=input[i+1] && i + 1 == input.Count-1)
                {
                    Console.WriteLine(input[i] + " -> 1");
                }
                else
                {
                    Console.WriteLine(input[i] + " -> " + seq);
                    seq = 1;
                }
                
               
            }
                

            
        }
    }
}
