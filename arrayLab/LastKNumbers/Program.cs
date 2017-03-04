using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int numb = 1;
            int moves = 0;
            int index;
            int[] arr=new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                index = i;
                do
                {
                    
                    numb = numb + arr[i];
                    moves++;
                    i--;
                } while (i >= 0 && moves <= k);
                i = index;
                arr[index] = numb;
                moves = 0;
                numb = 0;
                
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
