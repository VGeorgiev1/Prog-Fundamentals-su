using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrindSub
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().TrimStart(new char[] { '0' });
            string line2 = Console.ReadLine().TrimStart(new char[] { '0' });
            int curSum = 0;
            string bigger = string.Empty;
            string smaller = string.Empty;
            bool carry = false;
            List <int> result= new List<int>();
            if (line.Length == line2.Length)
            {

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    int lineNumb = line[i] - '0';
                    int lineNumb2 = line2[i] - '0';
                    curSum = (lineNumb + lineNumb2);
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
                    curSum = 0;
                    if (carry == true)
                    {
                        curSum = 1;
                    }
                }
            }
           else
            {
                if (line.Length > line2.Length)
               {
                    int dif = line.Length - line2.Length;
                    line2 = new string('0', dif) + line2;
               }
             else
               {
                    int dif = line2.Length - line.Length;
                    line = new string('0', dif) + line;
               }
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    int lineNumb = line[i] - '0';
                    int lineNumb2 = line2[i] - '0';
                    curSum = curSum+(lineNumb + lineNumb2);
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
                    curSum = 0;
                    if (carry == true)
                    {
                        curSum = 1;
                        carry = false;
                    }
                }


            }
            for (int i = result.Count-1; i >=0 ; i--)
            {
                Console.Write(result[i]);
            }
            
        }
    }
}
