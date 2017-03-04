using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] string1 = Console.ReadLine().Split(' ');
            string[] string2 = Console.ReadLine().Split(' ');
            int i = 0;
            int j = 0;
            int countLeft = 0;
            int countRight = 0;
            int smaller = Math.Min(string2.Length, string1.Length);
            string s;
            if (smaller == string2.Length)
            {
                s = "string2";

            }
            else
            {
                s = "string1";
            }
            for (i = 0; i <= smaller-1; i++)
            {
                if (string1[i] == string2[i])
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }
            for (j = smaller-1; j >=0 ; j--)
            {
                if (s == "string1")
                {
                    if (string1[j] == string2[j + (string2.Length - string1.Length)])
                    {
                        countRight++;
                    }
                    else break;
                }
                else
                {
                    if (string2[j] == string1[j + (string1.Length - string2.Length)])
                    {
                        countRight++;
                    }
                    else break;
                }
                
            }
            if (countLeft > countRight)
            {
                Console.WriteLine(countLeft);
            }
            else
            {
                Console.WriteLine(countRight);
            }
        }
    }
}
