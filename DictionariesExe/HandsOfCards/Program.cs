using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> personHand = new Dictionary<string, List<string>>();
            char[] separators =
            {
                ',',':',
            };
            string[] input = Console.ReadLine().Trim().Split(separators);
            while (input[0] != "JOKER")
            {
                var name = input[0];
                
                if (!personHand.ContainsKey(input[0]))
                {
                    personHand.Add(name, new List<string>());
                }
                for (int i = 1; i < input.Length; i++)
                {
                    if (!personHand[name].Contains(input[i]))
                    {
                        personHand[name].Add(input[i]);
                    }
                }
                input = Console.ReadLine().Trim().Split(separators);

            }
            int sum=0;
            int c = 0;
            int cardPower = 0;
            foreach (var item in personHand)
            {
                Console.Write(item.Key + ": ");
                foreach (var card in item.Value)
                {
                    char[] c1 = card.ToCharArray();
                    if (c1[1]=='1' && c1[2]=='0')
                    {
                        c = 10;
                    }
                    else if(c1[1] >= '2' && c1[1] <= '9')
                    {
                        c = c1[1] - '0';
                    }
                    else if(c1[1]=='J')
                    {
                        c = 11;
                    }
                    else if (c1[1] == 'Q')
                    {
                        c = 12;
                    }
                    else if (c1[1] == 'K')
                    {
                        c = 13;
                    }
                    else if (c1[1] == 'A')
                    {
                        c = 14;
                    }

                    if(c1[1] == '1' && c1[2] == '0')
                    {
                        if (c1[3] == 'S')
                        {
                            cardPower = 4;
                        }
                        else if (c1[3] == 'H')
                        {
                            cardPower = 3;
                        }
                        else if (c1[3] == 'D')
                        {
                            cardPower = 2;
                        }
                        else if (c1[3] == 'C')
                        {
                            cardPower = 1;
                        }
                    }
                    else
                    {
                        if (c1[2] == 'S')
                        {
                            cardPower = 4;
                        }
                        else if (c1[2] == 'H')
                        {
                            cardPower = 3;
                        }
                        else if (c1[2] == 'D')
                        {
                            cardPower = 2;
                        }
                        else if (c1[2] == 'C')
                        {
                            cardPower = 1;
                        }
                    }
                    sum = sum+cardPower * c;

                    c = 0;
                    cardPower = 0;

                }
                Console.WriteLine(sum);
                sum = 0;

            }

        }
    }
}
