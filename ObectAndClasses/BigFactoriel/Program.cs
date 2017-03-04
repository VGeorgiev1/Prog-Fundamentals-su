using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace BigFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine(factoriel);
        }
    }
    class Point
    {
        public int point { get; set;}

    }


}
