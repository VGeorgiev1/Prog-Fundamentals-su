using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secongLine = Console.ReadLine();
            int equal = 0;
            //  char[] secondLine = Console.ReadLine().Split(' ');
     
            char[] first =firstLine.ToCharArray();
            char[] second = secongLine.ToCharArray();
            int i = 0;
            
            do
            {
                if (first[i] >= second[i])
                {
                    if (first[i] > second[i])
                    {
                        foreach (var item in second)
                        {
                            if (item != 32)
                            {
                                Console.Write(item);
                            }
                            
                        }
                        Console.WriteLine();
                        foreach (var item in first)
                        {
                            if (item != 32)
                            {
                                Console.Write(item);
                            }
                        }
                        break;
                    }
                    else
                    {
                        equal++;
                    }
                }
                else
                {
                    foreach (var item in first)
                    {
                        if (item != 32)
                        {
                            Console.Write(item);
                        }

                    }
                    Console.WriteLine();
                    foreach (var item in second)
                    {
                        if (item != 32)
                        {
                            Console.Write(item);
                        }
                    }
                    break;
                }
                i++;
            } while (i<Math.Min(first.Length,second.Length));
            if (equal != 0 && first.Length-second.Length!=0)
            {
                if (first.Length > second.Length)
                {
                    foreach (var item in second)
                    {
                        if (item != 32)
                        {
                            Console.Write(item);
                        }

                    }
                    Console.WriteLine();
                    foreach (var item in first)
                    {
                        if (item != 32)
                        {
                            Console.Write(item);
                        }
                    }

                }
                else
                {
                    foreach (var item in first)
                    {
                        if (item != 32)
                        {
                            Console.Write(item);
                        }

                    }
                    Console.WriteLine();
                    foreach (var item in second)
                    {
                        if (item != 32)
                        {
                            Console.Write(item);
                        }
                    }
                }
            }
            else if(equal!=0 && first.Length == second.Length)
            {
                foreach (var item in first)
                {
                    if (item != 32)
                    {
                        Console.Write(item);
                    }

                }
                Console.WriteLine();
                foreach (var item in second)
                {
                    if (item != 32)
                    {
                        Console.Write(item);
                    }
                }
            }
            
            

           
        }
    }
}
