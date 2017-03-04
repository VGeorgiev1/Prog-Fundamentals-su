using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInteruptor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int start=0;
            int count = 0;
            while (command[0] != "end")
            {

                switch (command[0])
                {
                    case "reverse":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (start + count > input.Count || start < 0 || count < 0 || start>=input.Count || count>=input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            Reverse(start, count, input);
                        }             
                                    break;
                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (start + count > input.Count || start < 0 || count < 0 || start >= input.Count || count >= input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            Sort(start, count, input);
                        }
                        break;
                    case "rollLeft":
                        count = int.Parse(command[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            rollLeft(count, input);
                        }
                        break;
                    case "rollRight":
                        count = int.Parse(command[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            rollRight( count, input);
                        }
                        break;

                }
                command = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("["+string.Join(", ", input)+"]");
        }

        private static void rollLeft( int count, List<string> input)
        {
            count = count % input.Count;
            string curStr = string.Empty;
            for (int i=0; i < count; i++)
            {
                curStr = input[0];
                input.RemoveAt(0);
                input.Add(curStr);
            }
        }

        private static void Sort(int start, int count, List<string> input)
        {
            List<string> sorted = input.Skip(start).Take(count).OrderBy(x => x).ToList();
            input.RemoveRange(start, count);
            input.InsertRange(start, sorted);
        }

        private static void Reverse(int start, int count, List<string> input)
        {
            List<string> reversed = input.Skip(start).Take(count).Reverse().ToList();
            input.RemoveRange(start, count);
            input.InsertRange(start, reversed);
        }

        private static void rollRight(int count,List<string> input)
        {
            count = count % input.Count;
            string curStr = string.Empty;
            for (int i = 0; i < count; i++)
            {
                curStr = input[input.Count-1];
                input.RemoveAt(input.Count-1);
                input.Insert(0,curStr);
            }
        }
    }
}
