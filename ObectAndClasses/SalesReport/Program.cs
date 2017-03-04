using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> sales = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Sales current = new Sales();

                current.Town = input[0];
                current.product = input[1];
                current.price = double.Parse(input[2]);
                current.quantity =double.Parse(input[3]);
                current.moneymade = current.price * current.quantity;
                if (!sales.ContainsKey(current.Town))
                {
                    sales[current.Town] = current.moneymade;
                }
                else
                {
                    sales[current.Town] += current.moneymade;
                }
            }
            foreach (var item in sales.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key + "->" + string.Format("{0:F2}",item.Value));
            }

        }
    }
    class Sales
    {
        public string Town { get; set; }

        public string product { get; set;}

        public double price { get; set; }

        public double quantity { get; set; }
        public double moneymade { get; set; }
    }
}
