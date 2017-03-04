using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (input.Count >= 3)
            {
                var output = input.OrderByDescending(x => x).Take(3);
                Console.WriteLine(string.Join(" ", output));
            }
            else
            {
                var output = input.OrderByDescending(x => x);
                Console.WriteLine(string.Join(" ", output));
            }

        }
    }
}
