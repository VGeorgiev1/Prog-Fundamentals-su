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
            long i = 2;
            bool IsIt = true;

            
            do
            {
                if (a == 2)
                {
                    IsIt = true;
                    break;
                }
                if (a == 1)
                {
                    IsIt = false;
                    break;
                }
                if (a % i == 0)
                {
                    IsIt = false;
                    break;
                }
                i++;
            } while (i <= Math.Sqrt(a));

            Console.WriteLine(IsIt);
        }
        }
    }

