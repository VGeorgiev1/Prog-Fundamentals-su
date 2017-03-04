using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumb = Console.ReadLine().TrimStart(new char[]{'0'});
            string multi = Console.ReadLine().TrimStart(new char[] { '0' });
            List<int> result = new List<int>();
            if (multi == "")
            {
                multi = "0";
                
            }
            int multiplayer = multi[0] - '0';
            int curSum = 0;
            bool carry = false;
            if (multiplayer != 0)
            {
                for (int i = bigNumb.Length - 1; i >= 0; i--)
                {
                    int lineNumb = bigNumb[i] - '0';

                    curSum = curSum + (lineNumb * multiplayer);
                    if (curSum >= 10)
                    {
                        result.Add((curSum % 10));
                        carry = true;
                        if (i == 0)
                        {
                            result.Add(curSum / 10);
                        }
                    }
                    else
                    {
                        result.Add((curSum));
                    }

                    if (carry == true)
                    {
                        curSum = curSum / 10;
                    }
                    else
                    {
                        curSum = 0;
                    }

                }
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    Console.Write(result[i]);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
           
            
        }
    }
}
