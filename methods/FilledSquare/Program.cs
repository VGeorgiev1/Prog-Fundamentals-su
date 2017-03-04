using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            if (n == 1)
            {
                DrawHeader(n);

            }
            else if(n==2){
                DrawHeader(n);
                DrawBotRow(n);
            }
            else {
                DrawHeader(n);
                DrawMidRow(n);
                DrawBotRow(n);
            }
            
        }

        private static void DrawBotRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        private static void DrawMidRow(int n)
        { int i = 0;
            int midRows = 0;
            do
            {
                Console.Write('-');
                do
                {
                    Console.Write("\\/");
                    i++;
                } while (i < n - 1);
                Console.WriteLine("-");
                midRows++;
                i = 0;
            } while (midRows < n - 2);
        }

        private static void DrawHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
