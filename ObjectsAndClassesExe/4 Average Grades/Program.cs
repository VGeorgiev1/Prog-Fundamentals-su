using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average() {
            
            return Grades.Average();
        } 
        public double avg { get; set; }

            
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> notebook = new List<Student>(); 
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                Student currStudent = new Student();
                currStudent.Name=name;
                currStudent.Grades = new List<double>();
                for (int b =1; b < input.Length; b++)
                {

                    currStudent.Grades.Add(double.Parse(input[b]));
                }
                currStudent.avg = currStudent.Average();
                notebook.Add(currStudent);
            }
            
            foreach (var item in notebook.Where(x => x.avg>=5.00).OrderBy(x => x.Name).ThenByDescending(x => x.avg))
            {
                Console.WriteLine(item.Name + " -> " + string.Format("{0:F2}",item.avg));
            }
        }
    }
}
