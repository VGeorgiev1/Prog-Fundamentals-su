using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace CountWorkinDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(DateTime.ParseExact($"01-01-{startDate.Year}","dd-MM-yyyy",CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"03-03-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"01-05-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"06-05-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"24-05-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"06-09-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"22-09-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"01-10-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"24-12-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"25-12-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"26-12-{startDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"01-01-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"03-03-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"01-05-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"06-05-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"24-05-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"06-09-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"22-09-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"01-10-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"24-12-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"25-12-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact($"26-12-{endDate.Year}", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            int count = 0;
            
            
            for (; startDate <= endDate; startDate=startDate.AddDays(1))
            {
                
                if (holidays.Contains(startDate) || startDate.DayOfWeek==DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                {

                }
                else
                {
                    count++;
                }

            }
            Console.WriteLine(count);

        }
    }
}
