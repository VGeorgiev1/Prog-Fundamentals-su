using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, char> mapped = new Dictionary<char, char>();
            string line1 = input[0];
            string line2 = input[1];
            bool exhch = true;
            int b = 0;
            if (line1.Length == line2.Length)
            {
                for (int i = 0; i < line1.Length; i++)
                {
                    if (!mapped.ContainsKey(line1[i]))
                    {
                        
                        mapped[line1[i]] = line2[i];
                    }
                    else
                    {
                        if (mapped[line1[i]] != line2[i])
                        {
                            exhch = false;
                        }  
                    }
                }
               
            }
            else
            {
                if (line1.Length > line2.Length)
                {
                    for ( b = 0; b < line1.Length; b++)
                    {
                        if (!mapped.ContainsKey(line1[b]))
                        {

                            mapped[line1[b]] = line2[b];
                        }
                    }
                    for ( ;  b< line2.Length; b++)
                    {
                        if (!mapped.ContainsKey(line2[b]))
                        {
                            exhch = false;
                        }
                    }

                }
                else
                {
                    for (b = 0; b < line1.Length; b++)
                    {
                        if (!mapped.ContainsKey(line1[b]))
                        {

                            mapped[line1[b]] = line2[b];
                        }
                    }
                    for (; b < line2.Length; b++)
                    {
                        if (!mapped.ContainsValue(line2[b]))
                        {
                            exhch = false;
                        }
                    }

                }
            }
            Console.Write(exhch);
                        
        }
    }
}
