using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace RedoneStudentsGroups
{
    class Town
    {
        public string Name { get; set; }

        public int Seats { get; set; }

        public List<Student> stud { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime reg { get; set; }
    }
    class Group
    {
        public string Town { get; set; }
        public List<Student> stds {get;set;}
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> asd = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                asd.Add("Pesho");
            }
            string nameOfTown = string.Empty;
            string input = Console.ReadLine();
            List<Town> towns = new List<Town>();
            int index = -1;
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    string[] splited = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    Town curTown = new Town();
                    string townName = splited[0].Trim();
                    nameOfTown = townName;
                    string[] People = splited[1].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                    int seats = int.Parse(People[0]);
                    curTown.Name = townName;
                    curTown.Seats = seats;
                    curTown.stud = new List<Student>();
                    towns.Add(curTown);
                    index++;
                }
                else
                {
                    string[] split1 = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student curStud = new Student();
                    string name = split1[0].Trim();
                    string email = split1[1].Trim();
                    DateTime regDate = DateTime.ParseExact(split1[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    curStud.Name = name;
                    curStud.email = email;
                    curStud.reg = regDate;
                    towns[index].stud.Add(curStud);
                }
                input = Console.ReadLine();

            }
            towns = towns.OrderBy(x => x.Name).ToList();
            List<Group> groups = new List<Group>();
            for (int i = 0; i < towns.Count; i++)
            {
                
                var studs = towns[i].stud.OrderBy(x => x.reg).ThenBy(x => x.Name).ThenBy(x => x.email).ToList();
                while (studs.Any())
                {
                    Group curGroup = new Group();
                    curGroup.Town = towns[i].Name;
                    curGroup.stds = studs.Take(towns[i].Seats).ToList();
                    studs = studs.Skip(towns[i].Seats).ToList();
                    groups.Add(curGroup);
                }
                
                
                
            }
            Console.WriteLine("Created " + groups.Count + " groups in " + towns.Count + " towns:");
            List<string> emails = new List<string>();
            for (int i = 0; i < groups.Count; i++)
            {
                emails = new List<string>();
                for (int b = 0; b < groups[i].stds.Count; b++)
                {
                    emails.Add(groups[i].stds[b].email);
                }
                Console.WriteLine(groups[i].Town + " => "+string.Join(", ",emails));
                emails = null;
            }
        }

       
            
            
        
    }
}
