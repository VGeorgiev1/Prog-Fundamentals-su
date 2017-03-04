using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterFromTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            if (type == "int")
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                Console.WriteLine(BiggerFromTwo(a, b));
            }
            else if (type == "char")
            {
                var a = char.Parse(Console.ReadLine());
                var b = char.Parse(Console.ReadLine());
               Console.WriteLine(BiggerFromTwo(a, b));

            }
            else
            {
                var a =Console.ReadLine();
                var b = Console.ReadLine();
                Console.WriteLine(BiggerFromTwo(a, b));
            }
            

        }

        private static int BiggerFromTwo(int a, int b)
        {
            return Math.Max(a, b);
        }
        private static char BiggerFromTwo(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
         }
        private static string BiggerFromTwo(string a, string b)
        {
            if (a.CompareTo(b)<0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

    }
}
