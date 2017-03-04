using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> emailbook = new Dictionary<string, string>();
            while (name != "stop")
            {
                string[] email = Console.ReadLine().ToLower().Split('.');
                if (email[0] == "stop")
                {
                    break;
                }
                if(email[1]!="us" && email[1] != "uk")
                {
                    if (!emailbook.ContainsKey(name))
                    {
                        emailbook[name] = email[0] +"."+ email[1];
                    }

                }
                name = Console.ReadLine();

            }
            foreach (var item in emailbook)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
