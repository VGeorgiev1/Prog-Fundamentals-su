using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotograph
{
    class Program
    {
        static void Main(string[] args)
        {
            int pics = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double goodPicsProc = double.Parse(Console.ReadLine());
            goodPicsProc = Math.Ceiling(goodPicsProc)/100;
            int uploadTime = int.Parse(Console.ReadLine());
            double goodPics = Math.Ceiling(goodPicsProc * pics);
            double filterTimeNeeded = pics * filterTime;
            double uploadTimeNeeded = uploadTime * goodPics;
            TimeSpan t = TimeSpan.FromSeconds(filterTimeNeeded + uploadTimeNeeded);
            string anser = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                                                        t.Days,
                                                        t.Hours,
                                                        t.Minutes,
                                                        t.Seconds);
            Console.WriteLine(anser);



        }
    }
}
