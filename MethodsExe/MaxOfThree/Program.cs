using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMax(a, b, c);
        }

        private static void GetMax(int a, int b, int c)
        {
            if (c > Math.Max(a, b))
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(Math.Max(a, b));
            }
        }
    }
}
