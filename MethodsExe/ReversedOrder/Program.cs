using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Reversed(a);
        }

        private static void Reversed(string a)
        {
            for (int i = a.Length-1; i>=0 ; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
