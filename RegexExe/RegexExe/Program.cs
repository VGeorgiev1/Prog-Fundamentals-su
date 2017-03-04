using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ExtractSenteces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"[\s][A-Za-z0-9][A-za-z0-9.\-_]+@[A-za-z][A-Za-z-]+\.[A-Za-z\.]+\b");
            var matches = pattern.Matches(input);
            //    List<string> emails = new List<string>();
            foreach (Match item in matches)
            {

                Console.WriteLine(item.ToString().Remove(0, 1));

            }
        }
    }
}