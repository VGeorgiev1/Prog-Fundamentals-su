using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheker
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long j = 0;
            long i = 0;
            List<long> primes = new List<long>();
            do
            {
                if (IsPrime(a+j) == true)
                {
                    primes.Add(a + j);
                }
                j++;
                
            } while (a+j <= b);
            Console.Write(string.Join(", ", primes));
        }


        private static bool IsPrime(long a)
        {
            long i = 2;
            bool IsIt = true;
            if(a==1 || a == 0)
            {
                IsIt = false;
            }
            else if ( a==2)
            {
                IsIt = true;
                
            }
            else
            {
                do
                {
                    if (a % i == 0)
                    {
                        IsIt = false;
                        break;
                    }
                    i++;
                } while (i <= Math.Sqrt(a));
                
            }
            return IsIt;
            
        }
    }
}
