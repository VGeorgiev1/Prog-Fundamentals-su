using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortNumbersSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators =
            {

                '.',',',':',';','(',')','[',']','"','\'','\\','/','!','?',' '

            };
            var input = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            SortedDictionary<string, int> words = new SortedDictionary<string, int>();
            input = input
                .Where(x => x.Length < 5)
                .OrderBy(x =>x)
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ", input));
            
            
        }
    }
}
