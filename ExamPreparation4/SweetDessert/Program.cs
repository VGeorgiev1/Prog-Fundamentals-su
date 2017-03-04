using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double banansPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesKilo = double.Parse(Console.ReadLine());
            int neededPortions=0;
            int atLeastPortions = guests / 6;
            if (atLeastPortions * 6 < guests)
            {
                neededPortions=atLeastPortions+1;
            }
            else
            {
                neededPortions = atLeastPortions;
            }
            int neededBananas = neededPortions * 2;
            int neededEggs = neededPortions * 4;
            double neededBerries = neededPortions * 0.2;
            decimal neeededCash = (decimal)(neededBananas * banansPrice + neededEggs * eggsPrice + neededBerries * berriesKilo);
            if (cash >= neeededCash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", neeededCash);

            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", neeededCash - cash);
            }
        }
    }
}
