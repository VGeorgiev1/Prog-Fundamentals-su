using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexidecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            foreach (var item in input)
            {
                Console.Write($"\\u{(int)item:x4}");
            }
        }
    }
}
