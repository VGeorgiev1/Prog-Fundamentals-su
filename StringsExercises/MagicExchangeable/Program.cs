using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0].ToLower();
            string second = input[1].ToLower();
            Dictionary<char, char> letters = new Dictionary<char, char>();
            bool exch = true;
            int i = 0;
            if (first.Length == second.Length)
            {
                for (; i < first.Length; i++)
                {
                    if (!letters.ContainsKey(first[i]))
                    {
                        if (!letters.ContainsKey(first[i]))
                        {
                            letters[first[i]] = second[i];
                        }
                        else
                        {
                            exch = false;
                        }
                    }
                    else if (letters[first[i]] != second[i])
                    {
                        exch = false;
                    }
                }
            }
            else
            {
                if (first.Length > second.Length)
                {
                    for (; i < second.Length; i++)
                    {
                        if (!letters.ContainsKey(first[i]))
                        {

                            letters[first[i]] = second[i];
                        }
                        else if (letters[first[i]] != second[i])
                        {
                            exch = false;
                        }
                    }
                    for (; i < first.Length; i++)
                    {
                        if (!letters.ContainsKey(first[i]))
                        {
                            exch = false;
                            break;
                        }
                    }


                }
                else
                {
                    for (; i < first.Length; i++)
                    {
                        if (!letters.ContainsKey(first[i]))
                        {
                            letters[first[i]] = second[i];

                        }
                        else if (letters[first[i]] != second[i])
                        {
                            exch = false;
                        }
                    }
                    for (; i < second.Length; i++)
                    {
                        if (!letters.ContainsValue(second[i]))
                        {
                            exch = false;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(exch.ToString().ToLower());

        }
    }
}

