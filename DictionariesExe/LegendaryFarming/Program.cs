using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            SortedDictionary<string, long> junk = new SortedDictionary<string,long>();
            string[] input = Console.ReadLine().ToLower().Split(' ');
            bool found = false;
            int remaining = 0;
            string legitem="";
            while (true)
            {


                for (int i = 1; i <= input.Length; i += 2)
                {
                    
                    int quantity = int.Parse(input[i - 1]);
                    if (input[i] == "fragments" || input[i] == "shards" || input[i] == "motes")
                    {

                        if (!keyMaterials.ContainsKey(input[i]))
                        {
                            keyMaterials.Add(input[i], quantity);
                        }
                        else
                        {
                            keyMaterials[input[i]] += quantity;
                        }

                    }
                    else
                    {
                        if (!junk.ContainsKey(input[i]))
                        {
                            junk.Add(input[i], quantity);
                        }
                        else
                        {
                            junk[input[i]] += quantity;
                        }
                    }
                    
                    foreach (var item in keyMaterials)
                    {
                        if (item.Value >= 250)
                        {

                            if (item.Key == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (item.Key == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            found = true;
                            legitem = item.Key;
                            remaining = item.Value - 250;
                           
                            break;

                        }
                    }

                    if (found == true)
                    {
                        break;
                    }

                }
                if (found == true)
                {
                    break;
                }
                input = Console.ReadLine().ToLower().Split(' ');
            }
            keyMaterials[legitem] = remaining;
            bool fragFound = false;
            bool shardsFound = false;
            bool motesFound = false;
            foreach (var item in keyMaterials)
            {
                if (item.Key == "fragments")
                {
                    fragFound = true;
                }
                 if (item.Key == "motes")
                {
                    motesFound = true;
                }
                 if (item.Key == "shards")
                {
                    shardsFound = true;
                }
            }
            if (fragFound == false)
            {
                keyMaterials["fragments"] = 0;
            }
            if (shardsFound == false)
            {
                keyMaterials["shards"] = 0;
            }
             if (motesFound == false)
            {
                keyMaterials["motes"] = 0;
            }
            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            foreach (var item in junk)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            

            

        }
    }
}
