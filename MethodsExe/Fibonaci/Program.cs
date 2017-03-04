using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Fib(a));
        }

        public static int Fib(int n) {
            if (n == 0) {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        
    }
}
