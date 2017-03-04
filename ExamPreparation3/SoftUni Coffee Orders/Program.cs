using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            decimal totalValue = 0;
            for (int i = 0; i < orders; i++)
            {
                decimal value = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int amount = int.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(date.Year,date.Month);
                decimal price = amount * value * days;
                totalValue += price;
                Console.WriteLine("The price for the coffee is: ${0:F2}", price);
            }
            Console.WriteLine("Total: ${0:F2}", totalValue);
        }
    }
}
