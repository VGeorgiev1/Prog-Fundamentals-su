using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbs.Add(currentNum);
                
            }

            int sum = numbs.Sum();
            int min = numbs.Min();
            int max = numbs.Max();
            double average = numbs.Average();
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Average = " + average);

        }
    }
}
