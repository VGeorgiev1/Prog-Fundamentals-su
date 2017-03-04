using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintfBody();
            PrintfFooter();
        }

        private static void PrintfFooter()
        {
            Console.WriteLine(@"------------------------------
© SoftUni
");
        }
    

        private static void PrintfBody()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________                              ");
        }

        private static void PrintHeader()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------    ");
        }
    }
}
