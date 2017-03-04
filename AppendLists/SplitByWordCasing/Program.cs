using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
            {
                ',',';',':','.','!','(',')','"','\'','\\','/','[',']',' '
            };
            List<string> input = Console.ReadLine()
                .Split(separators,StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            int sumOfUpper = 0;
            int sumOfLower = 0;
            List<string> lowerCase = new List<string>();
            List<string> UpperCase = new List<string>();
            List<string> MixedCase = new List<string>();
            bool mixedWithbadSymbol = false;
            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if(item[i]>=65 && item[i] <= 90)
                    {
                        sumOfUpper++;
                    }
                    else if(item[i]>=97 && item[i]<=122)
                    {
                        sumOfLower++;
                    }
                    else
                    {
                        MixedCase.Add(item);
                        mixedWithbadSymbol = true;
                        break;
                    }
                }
                if (sumOfUpper == item.Length)
                {
                    UpperCase.Add(item);
                }
                else if (sumOfLower == item.Length)
                {
                    lowerCase.Add(item);
                }
                else
                {
                    if (mixedWithbadSymbol == false)
                    {
                        MixedCase.Add(item);
                    }
                }
                sumOfLower = 0;
                sumOfUpper = 0;
                mixedWithbadSymbol = false;
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", MixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", UpperCase));


        }
    }
}

