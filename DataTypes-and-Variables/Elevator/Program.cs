using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int p=int.Parse(Console.ReadLine());
            int full;
            if (p > n)
            {
                Console.WriteLine("All the persons fit inside in the elevator.Only one course is needed");
            }
            else
            {
                full = n / p;
                if (full * p == n)
                {
                    Console.WriteLine(full);
                }
                else
                {
                    Console.WriteLine(full+1);
                }

            }
            
        }
    }
}
