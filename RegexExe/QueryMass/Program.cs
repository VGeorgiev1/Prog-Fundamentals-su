using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace QueryMass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '&', '?' });
            Regex pattern = new Regex(@".+=.+");
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
            while (input[0] != "END")
            {

                for (int i = 0; i < input.Length; i++)
                {

                    if (pattern.IsMatch(input[i]))
                    {
                        string[] parsed = input[i].Split('=');

                        Regex pattern1 = new Regex(@"(%20|\+)+");
                        parsed[0] = pattern1.Replace(parsed[0], " ");
                        parsed[1] = pattern1.Replace(parsed[1], " ");
                        parsed[0] = parsed[0].Trim();
                        parsed[1] = parsed[1].Trim();

                        if (!results.ContainsKey(parsed[0]))
                        {
                            results[parsed[0]] = new List<string>();

                        }
                        results[parsed[0]].Add(parsed[1]);
                    }
                }
                foreach (var item in results)
                {
                    Console.Write(item.Key + "=[" + string.Join(", ", item.Value) + "]");
                }
                Console.WriteLine();
                input = Console.ReadLine().Split(new char[] { '&', '?' });
                results = null;
                results = new Dictionary<string, List<string>>();
            }




        }
    }
}