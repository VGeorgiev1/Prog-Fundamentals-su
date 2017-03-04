using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> output = new List<int>();

            foreach (var item in input)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    output.Add(item);
                }

            }
            output.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
