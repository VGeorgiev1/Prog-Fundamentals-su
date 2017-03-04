using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplyoddsbyEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           Console.WriteLine(GetMulttiplied(GetEvenSum(n), GetOddSum(n)));
        }

        private static int GetMulttiplied(int v1, int v2)
        {
            return v1 * v2;
        }

        private static int GetEvenSum(int n)
        {
            int evenSum = 0;
            n = Math.Abs(n);
            do
            {
                if ((n % 10) % 2 == 0)
                {
                    evenSum = evenSum + (n % 10);
                }
                n = n / 10;
            } while (n > 0);
            return evenSum;
        }

        private static int GetOddSum(int n)
        {
            int oddSum = 0;
            n = Math.Abs(n);
            do
            {
                if ((n % 10) % 2 != 0)
                {
                    oddSum = oddSum +(n % 10);
                }
                n = n / 10;
            } while (n > 0);
            return oddSum;
        }
    }
}
