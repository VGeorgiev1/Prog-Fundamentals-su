using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum=0;
            int j;
            for (int i = 1; i <= n; i++)
            {
                j = i;
                sum = 0;
                do
                {
                    sum = sum + i % 10;
                    i = i / 10;
                    
                } while (i > 0);
                i = j;
                if(sum==5 || sum==7 || sum == 11)
                {
                    Console.WriteLine(i + " -> True");
                }
                else
                {
                    Console.WriteLine(i + " -> False");
                }
            }
        }
    }
}
