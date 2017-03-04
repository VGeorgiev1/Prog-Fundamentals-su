using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        Exchange(input, index);
                        break;
                    case "max":
                        MaxEvenOdd(input,command[1]);
                        break;
                    case "min":
                        MinEvenOdd(input,command[1]);
                        break;
                    case "first":
                        int count = int.Parse(command[1]);
                        FirstEvenOdd(input,count,command[2]);
                        break;
                    case "last":
                        int countt = int.Parse(command[1]);
                        LastEvenOdd(input,countt,command[2]);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine("[" + string.Join(", ", input)+"]");
             

        }

        private static void MinEvenOdd(List<int> input,string command)
        {
            int minindex = 0;
            int curMinEven=int.MaxValue;
            bool found = false;
            if (command == "even")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (input[i] <= curMinEven)
                        {
                            minindex = i;
                            curMinEven = input[i];
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minindex);
                }

            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        if (input[i] < curMinEven)
                        {
                            minindex = i;
                            curMinEven = input[i];
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minindex);
                }
            }

        }

        private static void LastEvenOdd(List<int> input,int count,string command)
        {
            List<int> numbs = new List<int>();
            int found = 0;
            if (count > input.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command == "even")
                {
                    for (int i = input.Count - 1; i >= 0; i--)
                    {
                        if (input[i] % 2 == 0)
                        {
                            numbs.Add(input[i]);
                            found++;
                            if (found == count)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = input.Count - 1; i >= 0; i--)
                    {
                        if (input[i] % 2 != 0)
                        {
                            numbs.Add(input[i]);
                            found++;
                            if (found == count)
                            {
                                break;
                            }
                        }
                    }

                }
                numbs.Reverse();
                Console.WriteLine("[" + string.Join(", ", numbs)+"]");
            }


        }

        private static void FirstEvenOdd(List<int> input,int count,string command)
        {
            
            List<int> numbs = new List<int>();
            int found = 0;
            if (count > input.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command == "even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            numbs.Add(input[i]);
                            found++;
                            if (found == count)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            numbs.Add(input[i]);
                            found++;
                            if (found == count)
                            {
                                break;
                            }
                        }
                    }

                }
                Console.WriteLine("[" + string.Join(", ", numbs) + "]");
            }
        }

        private static void MaxEvenOdd(List<int> input,string command)
        {
            bool found = false;
            int curMaxEven = int.MinValue;
            int maxindex = 0;
            if (command == "even")
            {
                for (int i = 0; i <input.Count; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (input[i] >= curMaxEven)
                        {
                            curMaxEven = input[i];
                            maxindex = i;
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxindex);
                }

            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        if (input[i] >= curMaxEven)
                        {
                            curMaxEven = input[i];
                            maxindex = i;
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxindex);
                }
            }
        }

        private static void Exchange(List<int> input, int index)
        {
            if(index>input.Count-1 || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                List<int> firstPart = new List<int>();
                firstPart = input.Take(index+1).ToList();
                input.RemoveRange(0, index+1);
                input.AddRange(firstPart);

            }
        }
    }
}
