using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string secondmane = Console.ReadLine();
            string age = Console.ReadLine();
            Console.WriteLine("Hello, " + firstname + " " + secondmane + ". " + " You are " + age + " years old.");
        }
    }
}
