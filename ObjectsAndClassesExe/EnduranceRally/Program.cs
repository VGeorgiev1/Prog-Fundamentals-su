using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> Racer = new Dictionary<string, double>();
            Dictionary<string, int> Failed = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                int fuel = (int)input[i][0];
                if (!Racer.ContainsKey(input[i]))
                {
                    Racer[input[i]] = fuel;
                    list.Add(input[i]);
                }
            }
            double[] track = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int[] checkpoints= Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var item in list)
            {
                for (int i = 0; i < track.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        Racer[item] = Racer[item] + track[i];
                    }
                    else
                    {
                        Racer[item] = Racer[item] - track[i];
                        if (Racer[item] <= 0)
                        {
                            Racer[item] = i;
                            Failed.Add(item, i);
                            break;
                        }
                    }
                }
            }
            foreach (var item in Racer)
            {
                if (!Failed.ContainsKey(item.Key))
                {
                    Console.WriteLine(item.Key + " - fuel left " + string.Format("{0:F2}", item.Value));
                }
                else
                {
                    Console.WriteLine(item.Key + " - reached " + string.Format("{0}", item.Value));
                }
            }
            
        }
    }
}
