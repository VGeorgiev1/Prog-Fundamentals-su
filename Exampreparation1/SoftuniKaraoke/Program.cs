using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> people = new List<string>();
            foreach (var item in participants)
            {
                people.Add(item.Trim());
            }
            string[] songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> playlist = new List<string>();
            foreach (var item in songs)
            {
                playlist.Add(item.Trim());
            }
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "dawn")
            {
                
                string Name = input[0].Trim();
                string song = input[1].Trim();
                string award = input[2].Trim();
                if(people.Contains(Name) && playlist.Contains(song))
                {
                    if (!output.ContainsKey(Name))
                    {
                        output[Name] = new List<string>();
                        output[Name].Add(award);
                    }
                    else
                    {
                        if (!output[Name].Contains(award))
                        {
                            output[Name].Add(award);
                        }
                    }

                }
                input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            }
            if (output.Count==0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var man in output.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine(man.Key + ": " + man.Value.Count + " awards");
                    foreach (var award in man.Value.OrderBy(x => x))
                    {
                        Console.WriteLine("--" + award);
                    }
                }
            }

        }
    }
}
