using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItMasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                if(IsItPalindrom(i)==true && SumOfdigits(i)==true && EvenDigit(i) == true)
                {
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                i++;
            } while (i <= n);

        }

        private static bool EvenDigit(int n)
        {
            do
            {
                if ((n % 10) % 2 == 0)
                {
                    return true;
                }
                n = n / 10;

            } while (n != 0);
            return false;
        }

        private static bool SumOfdigits(int n)
       {
            int sum = 0;
            do
            {
                sum =sum+n % 10;
                n = n / 10;

            } while (n != 0);
            if (sum % 7==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsItPalindrom(int n)
        {
            string pal = n.ToString();
            int i = 0;
            int j = pal.Length - 1;
            do
            {
                if (pal[i] != pal[j])
                {
                    return false;
                }
                i++;
                j--;
            } while (i <= j);
            return true;
        }
    }
}
