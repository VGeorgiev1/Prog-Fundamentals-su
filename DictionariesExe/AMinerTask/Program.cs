using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            while (input != "stop")
            {

                int quantity = int.Parse(Console.ReadLine());
                if (!inventory.ContainsKey(input))
                {
                    inventory[input] = quantity;
                }
                else
                {
                    inventory[input] = inventory[input] + quantity;
                }
                input = Console.ReadLine();

            }
            foreach (var item in inventory)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }

        }
    }
}
