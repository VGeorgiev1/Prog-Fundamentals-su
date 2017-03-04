using System;
using System.Numerics;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
            BigInteger i = 1;
            BigInteger factoriel= 1;
            do
            {
               factoriel = factoriel * i;
                i++;
            } while (i<=a);
            Console.WriteLine(factoriel);
        }
    }
}
