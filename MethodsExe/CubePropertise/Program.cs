using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubePropertise
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            if (type == "face")
            {
                Console.WriteLine(string.Format("{0:0.00}",Math.Round(cubeFace(a,type),2)));
            }
            else if (type == "volume")
            {
                Console.WriteLine(string.Format("{0:0.00}", Math.Round(cubeVolume(a, type), 2)));
            }
            else if (type == "space")
            {
                Console.WriteLine(string.Format("{0:0.00}", Math.Round(cubeSpace(a, type), 2)));
            }
            else if (type == "area")
            {
                Console.WriteLine(string.Format("{0:0.00}", Math.Round(cubeArea(a, type), 2)));
            }
        }

        private static double cubeArea(double a, string type)
        {
            double area = 6 * (a * a);
            return area;
        }

        private static double cubeSpace(double a, string type)
        {
            double space = Math.Sqrt((a * a) + (a * a) + (a*a));
            return space;
        }

        private static double cubeVolume(double a, string type)
        {
            double volume = Math.Pow(a,3);
            return volume;
        }

        private static double cubeFace(double a, string type)
        {
            double face = Math.Sqrt((a*a)+(a*a));
            return face;
        }
    }
}
