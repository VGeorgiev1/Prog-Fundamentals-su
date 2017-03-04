using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            Dictionary<string, DateTime>  realseDates= new Dictionary<string, DateTime>();
            for (int i = 0; i < n; i++)
            {
               string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string nameofBook = input[0];
                DateTime date = DateTime.ParseExact(input[3],"dd.MM.yyyy",CultureInfo.InvariantCulture);
                if (!realseDates.ContainsKey(nameofBook))
                {
                    realseDates.Add(nameofBook, date);
                }
                else
                {
                    realseDates[nameofBook] = date;
                }
              
                
            }
            DateTime startingDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var item in realseDates.Where(x => x.Value>startingDate).OrderBy(x => x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine(item.Key + " -> " + item.Value.ToString("dd.MM.yyyy"));
            }
        }

    }
}