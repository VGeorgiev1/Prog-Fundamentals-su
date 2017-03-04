using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstSircle = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] secondSircle = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double x1 = firstSircle[0];
            double y1 = firstSircle[1];
            double x2 = secondSircle[0];
            double y2 = secondSircle[1];
            double r1 = firstSircle[2];
            double r2 = secondSircle[2];
            var diffx = Math.Abs(x1 - x2);
            var diffy = Math.Abs(y1 - y2);
            var distance = Math.Sqrt(diffx * diffx + diffy * diffy);
            if (distance <= r1 + r2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
