using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Dictionary<string, double> avgSucces = new Dictionary<string, double>();
            SortedList<string, double> avgSucces = new SortedList<string, double>();
            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Studend currentStudend = new Studend();
                currentStudend.Name = input[0];
                currentStudend.Grades = new List<double>();
                for (int b = 1; b < input.Length; b++)
                {
                    currentStudend.Grades.Add(double.Parse(input[b]));
                }
                currentStudend.Avg = currentStudend.Average();
                if (!avgSucces.ContainsKey(currentStudend.Name))
                {
                    if (currentStudend.Avg >= 5.00)
                    {
                        avgSucces.Add(currentStudend.Name, currentStudend.Avg);
                    }
                }
                
                
            }
            foreach (var item in avgSucces.OrderBy(x => x.Key).ThenByDescending(x => x.Value))
            {    
                    Console.WriteLine(item.Key + " -> " + string.Format("{0:F2}", item.Value));
            }
           
            

        }
    }
    class Studend
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }


        public double Average() {
            return Grades.Average();
        }
        public double Avg { get; set; }
       
    }
}
