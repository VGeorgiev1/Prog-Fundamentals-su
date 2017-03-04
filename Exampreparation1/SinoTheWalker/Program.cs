using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int secondperStep = int.Parse(Console.ReadLine()) % 86400;
            long timeneeded = (steps * secondperStep);
            TimeSpan timeForAWalk = TimeSpan.FromSeconds(timeneeded);
            time = time + timeForAWalk;
            Console.WriteLine("Time Arrival: " + time.ToString("HH:mm:ss"));
        }
    }
}