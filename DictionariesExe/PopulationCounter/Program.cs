using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split('|');
            Dictionary<string ,Dictionary<string,long>> CountryCity= new Dictionary<string, Dictionary<string, long>>();
           
            while (data[0] != "report")
            {
                string country = data[1];
                string city = data[0];
                long population = long.Parse(data[2]);
                if (!CountryCity.ContainsKey(country))
                {
                    CountryCity.Add(country,new Dictionary<string, long>());
                }
                if(!CountryCity[country].ContainsKey(city))
                {
                    CountryCity[country][city]=0;
                }
                CountryCity[country][city] += population;
                data = Console.ReadLine().Trim().Split('|');
            }
           
            foreach (var item in CountryCity.OrderByDescending(x => x.Value.Values.Sum()))
            {
                
                Console.WriteLine(item.Key + " (total population: " + item.Value.Values.Sum()+")");
                foreach (var townpop in CountryCity[item.Key].OrderByDescending(k => k.Value))
                {
                    Console.WriteLine("=>" + townpop.Key + ": " + townpop.Value);
                }  
                
            }
        }
    }
}
