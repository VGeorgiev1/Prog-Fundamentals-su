using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HornetComm
{
    class privateMsg
    {
        public string RecCode { get; set; }
        public string message { get; set; }


    }
    class broadcast
    {
        public string msg { get; set; }
        public string frequancy { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@".+ <-> .+");
            Regex messege = new Regex(@"^\d+ <-> [A-Za-z0-9]+$");
            Regex broadcast = new Regex(@"^[^0-9]+ <-> [A-Za-z0-9]+$");
            List<privateMsg> pr = new List<privateMsg>();
            List<broadcast> br = new List<broadcast>();
            string input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                if (pattern.IsMatch(input))
                {
                    string firstMessage = input.Substring(0, input.IndexOf(" <-> "));
                    string secondMessage = input.Substring(input.LastIndexOf(" <-> ") + 5);
                    if (messege.IsMatch(input))
                    {

                        privateMsg cur = new privateMsg();
                        char[] code = firstMessage.ToCharArray();
                        Array.Reverse(code);
                        firstMessage = new string(code);
                        cur.RecCode = firstMessage;
                        cur.message = secondMessage;
                        pr.Add(cur);

                    }
                    else if (broadcast.IsMatch(input))
                    {
                        broadcast cur = new broadcast();
                        StringBuilder sb = new StringBuilder(secondMessage);
                        for (int i = 0; i < sb.Length; i++)
                        {
                            if (sb[i] >= 'a' && sb[i] <= 'z')
                            {
                                sb[i] = char.ToUpper(sb[i]);
                            }
                            else if (sb[i] >= 'A' && sb[i] <= 'Z')
                            {
                                sb[i] = char.ToLower(sb[i]);
                            }
                        }
                        cur.frequancy = sb.ToString();
                        cur.msg = firstMessage;
                        br.Add(cur);

                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (br.Count > 0)
            {

                foreach (var item in br)
                {
                    Console.WriteLine(item.frequancy + " -> " + item.msg);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (pr.Count > 0)
            {
                foreach (var item in pr)
                {
                    {
                        Console.WriteLine(item.RecCode + " -> " + item.message);
                    }
                }

            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}

