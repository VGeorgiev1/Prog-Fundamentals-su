using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] grid = new int[size, size];
            char[] row=new char[100];
            int i = 0;
            int r =0;
            int c = 0;
            int inp = 0;
            int h = 0;
            do{
               row = Console.ReadLine().ToCharArray();
                foreach (var item in row)
                {
                    inp++;
                }

                if (inp < size - 1)
                {
                    h = inp;
                    do
                    {
                        Console.WriteLine(h);
                        row[h] = 'I';
                        h++;
                    } while (h < size - 1);
                }
                
                
                foreach (var numb in row)
                {
                    
                    if (numb=='I' ||numb==' ') 
                    {
                        grid[r, c] = -1;
                    }
                   else if (numb == 'O')
                    {
                        grid[r, c] = 0;
                       
                    }
                    else if (numb == 'S')
                    {
                        grid[r, c] = 1;
                    }
                    else if (numb == 'E')
                    {
                        grid[r, c] = 2;
                    }
                    
                    c++;
                }
                c = 0;
                r++;
                i++;
                inp = 0;
                h = 0;
               
            }while(i< size);
            for (int b = 0; b < size; b++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(string.Format("{0} ", grid[b, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

        }
    }
}
