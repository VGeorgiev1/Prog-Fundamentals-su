using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("[\\-]*[0-9.]+[0-9]*");
            string[] input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<double>> monsters = new Dictionary<string, List<double>>();
            for (int i = 0; i < input.Length; i++)
            {
                int health = 0;
                double damage = 0;
                int multi = 0;
                int delitel = 0;
                string name = input[i].Trim();
                for (int b = 0; b < name.Length; b++)
                {
                    if(name[b]!='.' && name[b]!='*' && name[b] != '+' && name[b] != '-' && name[b] != '/' && (name[b]<'0' || name[b]>'9'))
                    {
                        health = health + name[b];
                    }
                    if (name[b] == '*')
                    {
                        multi++;
                    }
                    if (name[b] == '/')
                    {
                        delitel++;
                    }   
                }
                var mathes = pattern.Matches(name);
                foreach (Match item in mathes)
                {
                    damage = damage + double.Parse(item.ToString(),CultureInfo.InvariantCulture);
                }
                for (int l = 0; l < multi; l++)
                {
                    damage = damage * 2;
                }
                for (int j = 0; j < delitel; j++)
                {
                    damage = damage / 2;
                }
                if (!monsters.ContainsKey(name))
                {
                    monsters.Add(name,new List<double>());
                    monsters[name].Add(health);
                    monsters[name].Add(damage);
                }
                damage = 0;
                health = 0;
            }
            foreach (var item in monsters.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key + " - " + item.Value[0]+" health, "+ string.Format("{0:F2}", item.Value[1])+" damage");   
                
            } 
        }
    }
}
