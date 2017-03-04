using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObj
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = "Hello";
            string f2 = "World";
            object a = (f1 +" "+ f2);
            string final = (string)a;
            Console.WriteLine(final);

        }
    }
}
