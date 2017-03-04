using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RoliTheCoder
{
    class EventParticipants
    {
        public string nameofEvent { get; set; }
        public List<string> people { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, EventParticipants> events = new SortedList<int, EventParticipants>();
            string input = Console.ReadLine();
            while (input != "Time for Code")
            {
                string pattern = @"[0-9a-zA-Z]+\s+#[0-9a-zA-Z]+\s*(@[a-zA-Z]+\s*)*";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    string[] parsedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int id = int.Parse(parsedInput[0]);
                    string curName = parsedInput[1].Trim();
                    if (!events.ContainsKey(id))
                    {
                        EventParticipants curEvent = new EventParticipants();
                        curEvent.nameofEvent = curName;
                        curEvent.people = new List<string>();
                        for (int i = 2; i < parsedInput.Length; i++)
                        {
                            if (!curEvent.people.Contains(parsedInput[i]))
                            {
                                curEvent.people.Add(parsedInput[i]);
                            }
                        }
                        events.Add(id, curEvent);

                    }
                    else if (events[id].nameofEvent == curName)
                    {
                        for (int i = 2; i < parsedInput.Length; i++)
                        {
                            if (!events[id].people.Contains(parsedInput[i]))
                            {
                                events[id].people.Add(parsedInput[i].Trim());
                            }
                        }

                    }
                }
                input = Console.ReadLine().Trim();

            }
            foreach (var item in events.Values.OrderByDescending(x => x.people.Count).ThenBy(x => x.nameofEvent))
            {
                Console.WriteLine(item.nameofEvent.Substring(1) + " - " + item.people.Count);
                foreach (var person in item.people.OrderBy(x => x))
                {
                    Console.WriteLine(person);
                }
            }

        }

    }
}

