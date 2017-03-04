using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectagnleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(2 * (width + height),1));
            Console.WriteLine(Math.Round(width*height,2));
            Console.WriteLine(Math.Round(Math.Sqrt(width*width+height*height),13));
        }
    }
}
