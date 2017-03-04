using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string SecondsName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            double id = double.Parse(Console.ReadLine());
            int uen = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: " + firstname);
            Console.WriteLine("Last name: " + SecondsName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + uen);
        }
    }
}
