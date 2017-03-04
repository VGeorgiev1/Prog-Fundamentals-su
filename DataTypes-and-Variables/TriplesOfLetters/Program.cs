using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch;
            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + b));
                        Console.WriteLine((char)('a' + c));
                    }
                }
            }
        }
    }
}
