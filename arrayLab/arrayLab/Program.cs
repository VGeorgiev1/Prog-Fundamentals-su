using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int i = int.Parse(Console.ReadLine());
            if (i > 7 || i <= 0)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(week[i - 1]);
            };

        }
    }
}
