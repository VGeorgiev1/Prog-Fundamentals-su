using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InttoHextoBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(numb, 16).ToUpper());
            Console.WriteLine(Convert.ToString(numb, 2));
        }
    }
}
