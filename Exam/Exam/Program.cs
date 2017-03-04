using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceFor1000 = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double meters = (wingFlaps / 1000) * distanceFor1000;
            double timeinFlight = wingFlaps / 100;
            double timeinRest = (wingFlaps / endurance) * 5;
            double allTime = timeinFlight + timeinRest;
            Console.WriteLine("{0:F2} m.", meters);
            Console.WriteLine("{0} s.", allTime);

        }
    }
}