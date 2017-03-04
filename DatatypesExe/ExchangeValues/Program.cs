using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c=a;
            Console.WriteLine("Before:");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            Console.WriteLine("After:");
            a = b;
            b = c;
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
        }
    }
}
