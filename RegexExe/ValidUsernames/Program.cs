using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"\b[A-Za-z][A-Za-z_0-9]{2,26}\b");
            var matches = pattern.Matches(input);
            List<string> usernames = new List<string>();
            foreach (Match username in matches)
            {
                usernames.Add(username.ToString());
            }
            int maxLenght = 0;
            List<string> longest = new List<string>(10);
            longest.Add(usernames[0]);
            longest.Add(usernames[1]);
            for (int i = 0; i < usernames.Count; i++)
            {
                if (i + 1 >= usernames.Count)
                {
                    break;
                }
                if (usernames[i].Length + usernames[i + 1].Length > maxLenght)
                {
                    maxLenght = usernames[i].Length + usernames[i + 1].Length;
                    longest[0] = usernames[i];
                    longest[1] = usernames[i + 1];
                }
            }
            foreach (var user in longest)
            {
                Console.WriteLine(user);
            }
        }
    }
}