using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Team
    {
       public List<string> members { get; set; }
       public string creator { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedList<string, Team> teams = new SortedList<string, Team>();
            List<string> admins = new List<string>();
            List<string> alreadymembers = new List<string>();
            List<string> disband = new List<string>();
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                string[] teamAndCreator = Console.ReadLine().Split('-');
                Team currTeam = new Team();
                string creator = teamAndCreator[0];
                string nameofTeam = teamAndCreator[1];
                if (!teams.ContainsKey(nameofTeam))
                {
                    if (!admins.Contains(creator))
                    {
                        Console.WriteLine("Team " + nameofTeam + " has been created by " + creator + "!");
                        teams.Add(nameofTeam, new Team());
                        teams[nameofTeam].creator = creator;
                        admins.Add(creator);
                    }
                    else
                    {
                        Console.WriteLine(creator + " cannot create another team!");
                    }
  
                }
                else
                {
                    Console.WriteLine("Team "+nameofTeam + " was already created!");
                }

            }
            string[] assignment = Console.ReadLine().Split(new char[] {'-','>' },StringSplitOptions.RemoveEmptyEntries);
            while(assignment[0]!="end of assignment")
            {
                string person = assignment[0];
                string wantingTeam = assignment[1];
                
       
                    if (teams.ContainsKey(wantingTeam))
                    {
                        if (!alreadymembers.Contains(person) && !admins.Contains(person))
                        {
                            if (teams[wantingTeam].members == null)
                            {
                                teams[wantingTeam].members = new List<string>();
                            }
                            teams[wantingTeam].members.Add(person);
                            alreadymembers.Add(person);
                        }
                        else
                        {
                            Console.WriteLine("Member " + person + " cannot join team " + wantingTeam+"!");
                        }
                    }
                    else
                    {
                            Console.WriteLine("Team "+wantingTeam+" does not exist!");
                    }
                assignment = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in teams.Where(x => x.Value.members!=null).OrderByDescending(x => x.Value.members.Count).ThenBy(x => x.Key))
            {
                

              
                    Console.WriteLine(item.Key);
                    Console.WriteLine("- " + item.Value.creator);

                    foreach (var member in item.Value.members.OrderBy(x => x))
                    {
                        Console.WriteLine("-- " + member);
                    }
                }
                
            
            Console.WriteLine("Teams to disband:");
           
                
                foreach (var team in teams.Where(x => x.Value.members==null).OrderBy(x => x.Key))
                {
                    Console.WriteLine(team.Key);
                }
            

        }
    }
}
