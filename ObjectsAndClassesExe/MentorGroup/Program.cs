using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace MentorGroup
{
    public class Students
    {
       
        public List<string> comments { get; set; }
        
        public List<DateTime> attendance { get; set; } 

        public bool made { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesDates = Console.ReadLine().Split(new char[] { ' ', ',' });
            List<string> group = new List<string>();
            SortedList<string,Students> studs = new SortedList<string,Students>();
            while (namesDates[0] != "end")
            {
                string name = namesDates[0];
                group.Add(name);

                Students  currentStudent= new Students();
                bool index = studs.ContainsKey(name);
                if (index == false)
                {
                    
                    currentStudent.attendance = new List<DateTime>();
                    for (int i = 1; i < namesDates.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(namesDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        currentStudent.attendance.Add(date);

                    }
                    studs.Add(name,currentStudent);
                }
                else
                {
                    for (int i = 1; i < namesDates.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(namesDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        studs[name].attendance.Add(date);

                    }
                }
                namesDates = Console.ReadLine().Split(new char[] { ' ', ',' });
            }
            string[] namesComments = Console.ReadLine().Split(new char[] { '-' });

            while (namesComments[0] != "end of comments")
            {
                string namec = namesComments[0];
                string comment = namesComments[1];
                if (group.Contains(namec))
                {
                    if (studs[namec].made == false)
                    {
                        studs[namec].comments = new List<string>();


                        studs[namec].comments.Add(comment);
                        studs[namec].made = true;
                    }
                    else
                    {
                        studs[namec].comments.Add(comment);
                    }
                }
                 namesComments = Console.ReadLine().Split(new char[] { '-' });
            }
            foreach (var item in studs.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Comments:");
                if (item.Value.comments != null)
                {
                    foreach (var comment in item.Value.comments)
                    {
                        Console.WriteLine("- " + comment);
                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in item.Value.attendance.OrderBy(x => x))
                {
                    Console.WriteLine("-- " + date.ToString("dd/MM/yyyy"));
                }
            }

            }
        }
    }

