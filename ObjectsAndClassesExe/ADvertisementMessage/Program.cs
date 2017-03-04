using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases =
            {
               "Excellent product.",
               "Such a great product.", 
               "I always use that product.", 
               "Best product of its category.",
               "Exceptional product.", 
               "I can’t live without this product."

            };
            string[] Events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself",
                "I am very satisfied.",
                "I feel great!"
            };
            string[] Author =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"

            };
            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            Random r = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine(Phrases[r.Next(0, 5)]+" "+Events[r.Next(0,6)]+" "+Author[r.Next(0,7)]+" - "+cities[r.Next(0,4)]);
            }
        }
    }
}
