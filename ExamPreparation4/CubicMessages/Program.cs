using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ExamPreparation4
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^[0-9]+[A-Za-z]+");
            string input = Console.ReadLine();
            int lengt = int.Parse(Console.ReadLine());
            List<int> startIndexes = new List<int>();
            List<char> message = new List<char>();
            List<int> endingIndexes = new List<int>();
            Dictionary<string, string> words = new Dictionary<string, string>();
            while (input != "Over!")
            {
                bool valid = true;
                string deencrypted = string.Empty;
                if (pattern.IsMatch(input))
                {
                    int i = 0;
                    for (;i<input.Length; i++)
                    {
                        if(input[i]>='0' && input[i] <= '9')
                        {
                            startIndexes.Add(int.Parse(input[i].ToString()));
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (;i<input.Length ; i++)
                    {
                        if((input[i]>='a' && input[i]<='z') || ((input[i] >= 'A' && input[i] <= 'Z')))
                        {
                            message.Add(input[i]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    string msg = new string(message.ToArray());
                    if (message.Count == lengt)
                    {
                        for (;i<input.Length;i++)
                        {
                            if (input[i] >= '0' && input[i] <= '9')
                            {
                                endingIndexes.Add(int.Parse(input[i].ToString()));
                            }
                            if ((input[i] >= 'a' && input[i] <= 'z') || ((input[i] >= 'A' && input[i] <= 'Z')))
                            {
                                valid = false;
                            }


                        }
                        if (valid == true)
                        {
                            
                            for (int b = 0; b < startIndexes.Count; b++)
                            {
                                if (startIndexes[b] >= message.Count)
                                {
                                    deencrypted = deencrypted + " ";
                                }
                                else
                                {
                                    deencrypted = deencrypted + message[startIndexes[b]];
                                }
                            }
                            for (int c = 0; c < endingIndexes.Count; c++)
                            {
                                if (endingIndexes[c] >= message.Count)
                                {
                                    deencrypted = deencrypted + " ";
                                }
                                else
                                {
                                    deencrypted = deencrypted + message[endingIndexes[c]];
                                }
                               
                            }
                            words.Add(msg, deencrypted);
                        }

                    }
                }
                input = Console.ReadLine();
                if (input == "Over!") break;
                lengt = int.Parse(Console.ReadLine());
                startIndexes.RemoveRange(0,startIndexes.Count);
                endingIndexes.RemoveRange(0, endingIndexes.Count);
                message.RemoveRange(0, message.Count);
                deencrypted = string.Empty;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item.Key + " == " + item.Value);
            }
        }
    }
}
