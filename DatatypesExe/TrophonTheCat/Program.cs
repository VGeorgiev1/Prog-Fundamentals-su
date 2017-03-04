using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrophonTheCat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int i = 0;
            int j;
            foreach (var numb in input)
            {
                i++;
            }
            int[] price = new int[i];
            i = 0;
            foreach (var numb in input)
            {
                price[i] = int.Parse(numb);
                i++;
            }
            j = i;
            i = 0;
            int startPoint = int.Parse(Console.ReadLine());
            string value = Console.ReadLine();
            string posneg = Console.ReadLine();
            long leftCost=0;
            long rightCost = 0; 
            for  (i = startPoint-1; i>=0; i--)
            {
                if (posneg == "positive")
                {
                    if (value == "cheap")
                    {
                        if (price[i] < price[startPoint] && price[i] > 0)
                        {
                            leftCost = leftCost + price[i];
                        }
                    }
                    else if(value=="expensive")
                    {
                        if (price[i] >= price[startPoint] && price[i] > 0)
                        {
                            leftCost = leftCost + price[i];
                        }
                    }
                }
                else if(posneg=="negative")
                {
                    if (value == "cheap")
                    {
                        if(price[i]<price[startPoint] && price[i] < 0)
                        {
                            leftCost = leftCost + price[i];
                        }
                    }
                    else if(value == "expensive")
                    {
                        if (price[i] >= price[startPoint] && price[i] < 0)
                        {
                            leftCost = leftCost + price[i];
                        }
                    }
                }
                else
                {
                    if (value == "cheap")
                    {
                        if (price[i] < price[startPoint])
                        {
                            leftCost = leftCost + price[i];
                        }
                    }
                    else if (value == "expensive")
                    {
                        if (price[i] >= price[startPoint])
                        {
                            leftCost = leftCost + price[i];
                        }
                    }
                }
            }

            for (i = startPoint + 1; i < j; i++)
            {
                
                if (posneg == "positive")
                {
                    if (value == "cheap")
                    {
                        if (price[i] < price[startPoint] && price[i] > 0)
                        {
                            rightCost = rightCost + price[i];
                        }
                    }
                    else if (value == "expensive")
                    {
                        if (price[i] >= price[startPoint] && price[i] > 0)
                        {
                            rightCost = rightCost + price[i];
                        }
                    }
                }
                else if (posneg == "negative")
                {
                    if (value == "cheap")
                    {
                        if (price[i] < price[startPoint] && price[i] < 0)
                        {
                            rightCost = rightCost + price[i];
                        }
                    }
                    else if (value == "expensive")
                    {
                        if (price[i] >= price[startPoint] && price[i] < 0)
                        {
                            rightCost = rightCost + price[i];
                        }
                    }
                }
                else
                {
                    if (value == "cheap")
                    {
                        if (price[i] < price[startPoint])
                        {
                            rightCost = rightCost + price[i];
                        }
                    }
                    else if (value == "expensive")
                    {
                        if (price[i] >= price[startPoint])
                        {
                            rightCost = rightCost + price[i];
                        }
                    }
                }
            }


             if (rightCost > leftCost)
             {
            Console.WriteLine("Right - "+rightCost);
            }
            else if(leftCost>rightCost)
            {
                Console.WriteLine("Left - "+leftCost);
            }
             else
            {
                Console.WriteLine("Left - " + leftCost);
            }


        }
    }
}
