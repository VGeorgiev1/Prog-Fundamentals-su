using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesExe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        phonebook[input[1]] = input[2];
                        break;
                    case "S":
                        if (!phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine("Contact " + input[1] + " does not exist.");
                        }
                        else
                        {
                            Console.WriteLine(input[1] + " -> " + phonebook[input[1]]);
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phonebook.OrderByDescending(x => x.Key))
                        {
                            Console.WriteLine(item.Key + " -> " + item.Value);
                        }

                        break;

                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}

