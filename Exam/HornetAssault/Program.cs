using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetCommm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Trim().Split().Select(long.Parse).ToList();
            int indexes = beehives.Count;
            List<long> helping = new List<long>();
            foreach (var item in beehives)
            {
                helping.Add(item);
            }
            List<long> alive = new List<long>();
            List<long> hornets = Console.ReadLine().Trim().Split().Select(long.Parse).ToList();
            long hornetsPower = hornets.Sum();
            for (int i = 0; i < indexes; i++)
            {
                if (hornetsPower > beehives[i])
                {
                    helping.RemoveAt(0);
                }
                else
                {
                    long alivebees = beehives[i] - hornetsPower;
                    if (alivebees > 0)
                    {
                        alive.Add(alivebees);
                    }

                    hornets.RemoveAt(0);
                    if (hornets.Count == 0)
                    {
                        if (i < indexes - 1)
                        {
                            for (i = i + 1; i < beehives.Count; i++)
                            {
                                alive.Add(beehives[i]);
                            }
                        }
                        break;
                    }
                    hornetsPower = hornets.Sum();

                }

            }
            if (alive.Count > 0)
            {
                Console.WriteLine(string.Join(" ", alive));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}