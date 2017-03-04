using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCOnvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            float dist = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.#######}", (dist / (hours * 3600 + minutes * 60 + seconds)));
            Console.WriteLine("{0:0.#######}", (dist/1000)/(((minutes*60+seconds)/3600) + hours));
            Console.WriteLine("{0:0.#######}", (dist / 1609) / (((minutes * 60 + seconds) / 3600) + hours));
        }
    }
}
