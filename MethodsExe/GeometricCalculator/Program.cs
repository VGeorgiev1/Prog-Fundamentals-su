using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "triangle" || figure == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}",multArea(figure,side, height));
            }
            else if (figure == "square" || figure=="circle")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", multArea(figure,side));
            }
          
        }

        private static double multArea(string figure,double side)
        {
            if (figure == "square")
                return side * side;
            else return Math.PI * side * side;
        }

        private static double multArea(string figure,double side, double height)
        {
            if (figure == "triangle")
                return (side * height) / 2;
            else
                return side * height;
        }
    }
}
