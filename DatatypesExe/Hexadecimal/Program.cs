using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.Write(Convert.ToInt32(hex, 16));

        }
    }
}
