using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetArmada
{
    class Program
    {
        class Legion
        {

            public long Activity { get; set; }
            public Dictionary<string, long> typeAndCount { get; set; }

        }
        static void Main(string[] args)
        {
            Dictionary<string, Legion> legions = new Dictionary<string, Legion>();
            int N = int.Parse(Console.ReadLine());
            List<string> types = new List<string>();
            for (int i = 0; i < N; i++)
            {

                string[] input = Console.ReadLine().Split(new char[] { '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                long activity = long.Parse(input[0]);
                string legionName = input[1].Trim();
                string soldierType = input[2].Trim();
                long soldierAmount = long.Parse(input[3]);
                Legion curLeg = new Legion();


                if (!legions.ContainsKey(legionName))
                {
                    curLeg.Activity = activity;
                    curLeg.typeAndCount = new Dictionary<string, long>();
                    curLeg.typeAndCount.Add(soldierType, soldierAmount);
                    legions.Add(legionName, curLeg);
                    if (!types.Contains(soldierType))
                    {
                        types.Add(soldierType);
                    }
                }
                else
                {
                    if (activity > legions[legionName].Activity)
                    {
                        legions[legionName].Activity = activity;
                    }
                    if (legions[legionName].typeAndCount.ContainsKey(soldierType))
                    {
                        legions[legionName].typeAndCount[soldierType] = legions[legionName].typeAndCount[soldierType] + soldierAmount;
                    }
                    else
                    {
                        legions[legionName].typeAndCount.Add(soldierType, soldierAmount);
                    }

                }

            }
            string outputType = Console.ReadLine();
            Regex pat = new Regex(@"^\d+\\[^=:->]+$");
            if (pat.IsMatch(outputType))
            {

                string wantedType = outputType.Substring(outputType.IndexOf("\\") + 1);


                if (types.Contains(wantedType))
                {

                    Dictionary<string, Legion> prefixed = new Dictionary<string, Legion>();
                    long maxActivity = long.Parse(outputType.Substring(0, outputType.IndexOf("\\")));
                    foreach (var item in legions)
                    {
                        if (item.Value.typeAndCount.ContainsKey(wantedType))
                        {
                            prefixed.Add(item.Key, item.Value);
                        }
                    }
                    foreach (var leg in prefixed.OrderByDescending(x => x.Value.typeAndCount[wantedType]))
                    {
                        if (leg.Value.Activity < maxActivity && leg.Value.typeAndCount.ContainsKey(wantedType))
                        {
                            Console.WriteLine(leg.Key + " -> " + leg.Value.typeAndCount[wantedType]);
                        }
                    }
                }
            }
            else
            {
                string wanted = outputType.Trim();
                if (types.Contains(wanted))
                {

                    foreach (var leg in legions.OrderByDescending(x => x.Value.Activity))
                    {
                        if (leg.Value.typeAndCount.ContainsKey(wanted))
                        {
                            Console.WriteLine(leg.Value.Activity + " : " + leg.Key);
                        }
                    }
                }
            }
        }
    }
}