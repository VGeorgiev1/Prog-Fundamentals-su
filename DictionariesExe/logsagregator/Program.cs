using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logsagregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            SortedDictionary<string, SortedDictionary<string,int>> nameTime = new SortedDictionary<string, SortedDictionary<string, int>>();
            List<string> ips = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                string name = info[1];
                string ip = info[0];
                int time = int.Parse(info[2]);
                if (!nameTime.ContainsKey(name))
                {
                    nameTime.Add(name, new SortedDictionary<string, int>());
                }
                if(!nameTime[name].ContainsKey(ip))
                {
                    nameTime[name][ip] = 0;
                }
                nameTime[name][ip] += time;
                 
            }
            foreach (var item in nameTime)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Values.Sum()+" ["+string.Join(", ",item.Value.Keys)+"]");
            }
            
            

        }
    }
}
