using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitInEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            lastNumb(a);
        }

        private static void lastNumb(long a)
        {
            a = Math.Abs(a);
            if (a % 10 == 0)
            {
                Console.WriteLine("zero");
            }
            if (a % 10 == 1)
            {
                Console.WriteLine("one");
            }
            if (a % 10 == 2)
            {
                Console.WriteLine("two");
            }
            if (a % 10 == 3)
            {
                Console.WriteLine("three");
            }
            if (a % 10 == 4)
            {
                Console.WriteLine("four");
            }
            if (a % 10 == 5)
            {
                Console.WriteLine("five");
            }
            if (a % 10 == 6)
            {
                Console.WriteLine("six");
            }
            if (a % 10 == 7)
            {
                Console.WriteLine("seven");
            }
            if (a % 10 == 8)
            {
                Console.WriteLine("eight");
            }
            if (a % 10 == 9)
            {
                Console.WriteLine("nine");
            }
            
            
                 
        }
    }
}
