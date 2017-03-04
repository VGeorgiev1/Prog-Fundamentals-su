using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Srubso
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.*?) @(.*?) (\d+) (\d+)"; /// Input pattern


            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Dictionary<string, int>> singers = new Dictionary<string, Dictionary<string, int>>();
            while (input[0] != "End")
            {
                if (input.Length > 3 && input.Length <= 6)
                {
                    bool correctPrice = false;
                    bool correctAmount = false;
                    int ticketsAmount = 0;
                    int ticketsPrice = 0;
                    var name = input[0];
                    var place = input[1];

                    if (place[0] != '@')
                    {
                        name = name + " " + place;
                        place = input[2];
                        if (input[3][0] >= '1' && input[3][0] <= '9')
                        {
                            correctPrice = int.TryParse(input[3], out ticketsPrice);
                            correctAmount = int.TryParse(input[4], out ticketsAmount);

                        }
                        else
                        {
                            place = place + " " + input[3];
                            correctPrice = int.TryParse(input[4], out ticketsPrice);
                            correctAmount = int.TryParse(input[5], out ticketsAmount);
                        }

                    }
                    else
                    {
                        place = input[1];
                        if (input[2][0] >= '1' && input[2][0] <= '9')
                        {
                            correctPrice = int.TryParse(input[2], out ticketsPrice);
                            correctAmount = int.TryParse(input[3], out ticketsAmount);
                        }
                        else
                        {
                            place = place + " " + input[2];
                            correctPrice = int.TryParse(input[3], out ticketsPrice);
                            correctAmount = int.TryParse(input[4], out ticketsAmount);
                        }
                    }
                    if (correctAmount == true && correctPrice == true)
                    {

                        int money = ticketsPrice * ticketsAmount;

                        if (!singers.ContainsKey(place))
                        {
                            singers.Add(place, new Dictionary<string, int>());

                        }
                        if (!singers[place].ContainsKey(name))
                        {
                            singers[place].Add(name, money);
                        }
                        else
                        {
                            singers[place][name] = singers[place][name] + money;
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }
            foreach (var item in singers)
            {
                string curort = item.Key.Substring(1);
                Console.WriteLine(curort);
                foreach (var singer in item.Value.OrderByDescending(x => x.Value))
                {

                    Console.WriteLine("#  " + singer.Key + " -> " + singer.Value);
                }

            }

        }
    }
}