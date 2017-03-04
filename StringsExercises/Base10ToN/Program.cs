using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;
namespace Base10ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger Base = input[0];
            BigInteger number = input[1];
            string output = string.Empty;
            do
            {
                if (number % Base == 0)
                {
                    output = output + "0";
                }
                else
                {
                    output = output + (number%Base).ToString();
                }
                number = number / Base;
            } while (number != 0);

            for (int i = output.Length-1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            
        }
    }
}
