using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace again
{
    class MerlahShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            string tests = input;
            while (true)
            {
                int start = tests.IndexOf(pattern);
                int last = tests.LastIndexOf(pattern);
                if(start!=-1 && last!=-1 && pattern.Length > 0 && last!=start)
                {
                    tests = tests.Remove(start, pattern.Length);
                    last = tests.LastIndexOf(pattern);
                    tests = tests.Remove(last, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(tests);
                    break;
                }
                int index = pattern.Length / 2;
                pattern = pattern.Remove(index, 1);
            };
        }
    }
}
