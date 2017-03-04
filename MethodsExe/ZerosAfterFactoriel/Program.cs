using System;
using System.Numerics;

namespace ZerosAfterFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            int b = 0;
          
           // do
          //  {
          //      factoriel = factoriel * i;
          //      i++;
         //   } while (i <= a);
        
            do
            {
                a = a / 5;
                b = b + a;
               
            } while (a > 0);
            Console.WriteLine(b);
        }
    }
}
