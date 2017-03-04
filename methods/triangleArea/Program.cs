using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
           Console.WriteLine(Area(widht, height));
        }

        private static double Area(double widht, double height)
        {
            return (widht * height) / 2;
        }
    }
}
