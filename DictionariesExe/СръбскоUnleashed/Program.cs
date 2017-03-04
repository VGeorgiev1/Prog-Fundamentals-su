using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            double ad=1.23;
            double ac = 1.56;
            int res = (int)(ad + ac);
            Dictionary<string, SortedDictionary<string, int[]>> stats = new Dictionary<string, SortedDictionary<string, int[]>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string type = input[0];
                string name = input[1];
                int damage;
                int health;
                int armor;
                

                    if (input[2] == "null")
                    {
                        damage = 45;
                    }
                    else
                    {
                        damage = int.Parse(input[2]);
                    }
                    if (input[3] == "null")
                    {
                        health = 250;
                    }
                    else
                    {
                        health = int.Parse(input[3]);
                    }
                    if (input[4] == "null")
                    {
                        armor = 10;
                    }
                    else
                    {
                        armor = int.Parse(input[4]);
                    }   
                

                if (!stats.ContainsKey(type))
                {
                    stats.Add(input[0], new SortedDictionary<string, int[]>());
                }
                if (!stats[type].ContainsKey(name))
                {
                    stats[type][name] = new int[3];
                }
                stats[type][name][0]=damage;
                stats[type][name][1] = health;
                stats[type][name][2] = armor;
            }
            double avgHealth = 0;
            foreach (var item in stats)
            {
                var avgDmg = item.Value.Values.Average(a => a[0]);
                var avghp = item.Value.Values.Average(a => a[1]);
                var avgAr = item.Value.Values.Average(a => a[2]);
                Console.WriteLine($"{item.Key}: :({avgDmg:F2}/{avghp:F2}/{avgAr:F2})");
                foreach (var dragon in item.Value)
                {
                    Console.WriteLine("-"+dragon.Key + " -> damage: " + dragon.Value[0]+", health: " + dragon.Value[1] + ", armor: " + dragon.Value[2]);
                }
                
               
            }
        }
    }
}
