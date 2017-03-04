using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal numb = 0;
            decimal sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string curWord = input[i];
                for (int b = 0; b < curWord.Length; b++)
                {
                    if (curWord[b] >= '0' && curWord[b] <= '9')
                    {
                        numb = numb * 10 + (curWord[b] - '0');
                    }
  
                }
                if(curWord[0]>='A' && curWord[0] <= 'Z')
                {
                    numb = numb / (curWord[0] - 'A'+1);

                }
                else
                {
                    numb = numb * (curWord[0] - 'a'+1);
                }
                if(curWord[curWord.Length-1]>='A' && curWord[curWord.Length - 1] <= 'Z')
                {
                    numb = numb - (curWord[curWord.Length - 1] - 'A'+1);
                }
                else
                {
                    numb = numb + (curWord[curWord.Length - 1] - 'a'+1);
                }
                sum = sum + numb;
                numb = 0;
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
