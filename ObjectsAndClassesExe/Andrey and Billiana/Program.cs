using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_and_Billiard
{
    class Customer
    {

        public SortedList<string,int> order { get; set; }

        public double Bill { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> menu = new Dictionary<string, double>();
            
            for (int i = 0; i < n; i++)
            {
                string[] inventory = Console.ReadLine().Split('-');
                string item = inventory[0];
                double value = double.Parse(inventory[1]);
                if (!menu.ContainsKey(item))
                {
                    menu.Add(item, value);
                }
                else
                {
                    menu[item] = value;
                }

            }
            string[] orders = Console.ReadLine().Split(new char[] { '-', ','});
            SortedList<string,Customer> Everything = new SortedList<string,Customer>();
            while(orders[0]!="end of clients")
            {
                string name = orders[0];
                string thing = orders[1];
                int quantity = int.Parse(orders[2]);
                Customer currCust = new Customer();
                if (menu.ContainsKey(thing))
                {
                    if (!Everything.ContainsKey(name))
                    {
                        currCust.order = new SortedList<string, int>();
                        currCust.order.Add(thing,quantity);
                        currCust.Bill = menu[thing] * quantity;
                        Everything.Add(name, currCust);
                    }
                    else
                    {
                        if (Everything[name].order.ContainsKey(thing))
                        {
                            Everything[name].order[thing] += quantity;
                        }
                        else
                        {
                            Everything[name].order.Add(thing, quantity);
                        }
                        Everything[name].Bill += menu[thing] * quantity;
                    }
                    
                    
                }
                orders = Console.ReadLine().Split(new char[] { '-', ',' });
            }
            double totalBill = 0;
            foreach (var item in Everything.OrderBy(x => x.Key).ThenByDescending(x => x.Value.order.Values))
            {
                Console.WriteLine(item.Key);
                foreach (var thingi in item.Value.order)
                {
                    Console.WriteLine("-- " + thingi.Key+" - "+thingi.Value);
                }
                Console.WriteLine("Bill: " + string.Format("{0:F2}",item.Value.Bill));
                totalBill += item.Value.Bill;

            }
            Console.WriteLine("Total bill:" + string.Format("{0:F2}",totalBill));
           
        }
    }
}


