using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOcurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!words.ContainsKey(item))
                {
                    words[item] = 1;
                }
                else
                {
                    words[item]++;
                }
            }
            var result = new List<string>();
            foreach (var item in words)
            {
                if(item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
