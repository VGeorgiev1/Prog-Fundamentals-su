using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators =
            {
                '=',' '

            };
            SortedDictionary<string, Dictionary<string, int>> info = new SortedDictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(separators);
            while (input[0] != "end")
            {
                var ip = input[1];
                var user = input[5];
                if (!info.ContainsKey(user))
                {
                    info.Add(user, new Dictionary<string, int>());
                }
                if (!info[user].ContainsKey(ip))
                {
                    info[user][ip] = 1;
                }
                else
                {
                    info[user][ip]++;
                }
                
                input = Console.ReadLine().Split(separators);

            }
            foreach (var item in info)
            {
                Console.WriteLine(item.Key + ": ");
                foreach (var ips in item.Value)
                {
                    if (ips.Key != item.Value.Keys.Last())
                    {
                        Console.Write(ips.Key + " => " + ips.Value+", ");
                    }
                    else
                    {
                        Console.WriteLine(ips.Key + " => " + ips.Value + ". ");
                    }
                }
            }
        }
    }
}
