using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point first = new Point();
            first.x = firstPoint[0];
            first.y = firstPoint[1];
            Point second = new Point();
            second.x = secondPoint[0];
            second.y = secondPoint[1];
            Console.WriteLine(string.Format("{0:F3}", CalcDistance(first, second)));

        }

        private static double CalcDistance(Point first,Point second)
        {
            double diffx = Math.Abs(first.x - second.x);
            double diffy = Math.Abs(first.y - second.y);
            double distance = Math.Sqrt(Math.Abs((diffx * diffx) + (diffy * diffy)));
            return distance;

        }
    }
    class Point
    {
        public double x { get; set; }

        public double y { get; set; }
       
    }
}
