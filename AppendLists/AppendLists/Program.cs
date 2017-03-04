using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        { 
        
            string[] input = Console.ReadLine().Split('|');
            List<char> appendNumbs = new List<char>();
            for (int i = input.Length-1; i>=0 ; i--)
            {
                foreach (var item in input[i])
                {
                    if (item != ' ')
                    {

                        appendNumbs.Add(item);
                    } 
                }
            }
            Console.Write(string.Join(" ", appendNumbs));
        }
    }
}
