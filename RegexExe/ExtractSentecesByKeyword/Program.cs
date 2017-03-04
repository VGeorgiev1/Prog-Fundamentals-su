using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] word = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = "\\b" + text + "\\b";

            Regex reges = new Regex(pattern);
            foreach (var words in word)
            {
                if (reges.IsMatch(words))
                {
                    Console.WriteLine(words.Trim());
                }

            }
        }
    }
}
