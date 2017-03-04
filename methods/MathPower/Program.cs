using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double numb = double.Parse(Console.ReadLine());
            double powerofNumb = double.Parse(Console.ReadLine());
          Console.WriteLine(pow(numb, powerofNumb));
        }

        private static double pow(double numb, double powerofNumb)
        {
            int i = 0;
            double now = 1;
            do
            {
                now =now * numb;
                i++;
            } while (i < powerofNumb);
            return now;
        }
    }
}
