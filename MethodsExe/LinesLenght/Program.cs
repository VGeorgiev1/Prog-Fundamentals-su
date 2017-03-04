using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            
            if(firstLine(x1, y1, x2, y2)>= SecondLine(x3, y3, x4, y4))
            {
               if(CloserPoint(x1, y1, x2, y2) == "first")
                {
                    Console.Write("(" + x1 + ", " + y1 + ")(" + x2 + ", " + y2 + ")");
                }
               else
                {
                    Console.Write("(" + x2 + ", " + y2 + ")(" + x1 + ", " + y1 + ")");
                }
               
            }
            else
            {
                if (CloserPoint(x3, y3, x4, y4) == "first")
                {
                    Console.Write("(" + x3 + ", " + y3 + ")(" + x4 + ", " + y4 + ")");
                }
                else
                {
                    Console.Write("(" + x4 + ", " + y4 + ")(" + x3 + ", " + y3 + ")");
                }


            }

        }

        private static string CloserPoint(double x1, double y1, double x2, double y2)
        {
            double len = Math.Sqrt((x1*x1) + (y1*y1));
            double len1 = Math.Sqrt((x2 *x2) + (y2*y2));
            if (len <= len1)
            {
                return "first";
            }
            else
            {
                return "second";
            }
        }

        private static double firstLine(double x1, double y1, double x2, double y2)
        {
            double y =((y1)-(y2));
            double x = ((x1) - (x2));
            double len = Math.Sqrt(x * x + y * y);
            return len;
        }
        private static double SecondLine(double x3, double y3, double x4, double y4)
        {
            double y = ((y3) - (y4));
            double x = ((x4) - (x3));
            double len = Math.Sqrt(x * x + y * y);
            return len;
        }
    }
}
