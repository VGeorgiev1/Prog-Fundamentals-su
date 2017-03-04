using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                        .Split(' ')
                        .Select(double.Parse)
                        .ToList();
           SortedDictionary<double,int> numbers = new SortedDictionary<double, int>();

            foreach (var item in input)
            {
                if (!numbers.ContainsKey(item))
                {
                    numbers.Add(item, 1);
                }
                else
                {
                    numbers[item]++;
                }
            }
            
            foreach (var item in numbers)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
