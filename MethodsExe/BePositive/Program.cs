using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            
            var numbers = new List<int>();
            

            foreach (var item in input)
            {
                if (item != "")
                {
                    numbers.Add(int.Parse(item));
                }
                //0 -2 2 -2 3
            }
            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    found = true;
                    Console.Write(currentNum+" ");
                }
                else
                {
                    j = j + 1;
                    if (j < numbers.Count)
                    {
                        currentNum = currentNum + numbers[j];
                    }

                    if (currentNum >= 0)
                    {
                        found = true;
                        Console.Write(currentNum+" ");
          
                    }
                }
                
            }
          
            if (found == false)
            {
                Console.Write("(empty)");
            }
            Console.WriteLine();

        }
    }
}
