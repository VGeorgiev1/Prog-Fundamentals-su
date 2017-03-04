using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string team = string.Empty;
            string[] encrypted = Console.ReadLine().Split();
            Dictionary<string, long> goals = new Dictionary<string, long>();
            Dictionary<string, int> league = new Dictionary<string, int>();
            List<string> curTeams = new List<string>();
            while (encrypted[0] != "final")
            {
                
            
                for (int i = 0; i < encrypted.Length-1; i++)
                {

                    team = encrypted[i].Substring(encrypted[i].IndexOf(key) + key.Length, encrypted[i].LastIndexOf(key) - encrypted[i].IndexOf(key) - key.Length);
                    char[] word = team.ToCharArray();
                    Array.Reverse(word);
                    team = new string(word).ToUpper();
                    curTeams.Add(team);
                }
                    string[] score = encrypted[2].Split(':');
                    long teamAScore = long.Parse(score[0]);
                    long teamBScore = long.Parse(score[1]);
                    int teamAPoints = 0;
                    int teamBPoints = 0;

                    if (teamAScore > teamBScore)
                    {
                        teamAPoints = 3;
                        teamBPoints = 0;
                    }
                    else if (teamBScore > teamAScore)
                    {
                        teamAPoints = 0;
                        teamBPoints = 3;
                    }
                    else
                    {
                        teamBPoints = 1;
                        teamAPoints = 1;
                    }

                if (!league.ContainsKey(curTeams[0]))
                {
                    league[curTeams[0]] = teamAPoints;
                }
                else
                {
                    league[curTeams[0]] += teamAPoints;
                }
                if (!goals.ContainsKey(curTeams[0]))
                {
                    goals[curTeams[0]] = teamAScore;
                }
                else
                {
                   goals[curTeams[0]] += teamAScore;
                }

                if (!league.ContainsKey(curTeams[1]))
                {
                    league[curTeams[1]] = teamBPoints;
                }
                else
                {
                    league[curTeams[1]] += teamBPoints;
                }
                if (!goals.ContainsKey(curTeams[1]))
                {
                    goals[curTeams[1]] = teamBScore;
                }
                else
                {
                    goals[curTeams[1]] += teamBScore;
                }
                curTeams.RemoveRange(0,2);
                encrypted = Console.ReadLine().Split();
            }
            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var item in league.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {

                Console.WriteLine(place+". " + item.Key + " " + item.Value);
                place++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in goals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine("- " + item.Key + " -> " + item.Value);
            }

       }
    }
}

