using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double
                .Parse).ToList();
            double sum = 0;
            for (int i = 0; i <= input.Count-2; )
            {
                if (input[i] == input[i + 1])
                {
                    sum = input[i] + input[i + 1];
                    input.RemoveRange(i, 2);
                    input.Insert(i, sum);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
