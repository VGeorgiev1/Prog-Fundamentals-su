using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            i = 0;
            n = int.Parse(Console.ReadLine());
            decimal sum;
            sum = 0;
            decimal numb;
            do
            {
                numb = decimal.Parse(Console.ReadLine());
                sum = sum + numb;
                i++;
            } while (i < n);
            Console.WriteLine(sum);
        }
    }
}
