using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        bool hasMatch = false;
        string matchedString;


        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump+i;

                if (endIndex >= text.Length-1)
                {
                    endIndex = text.Length-1;
                    do
                    {
                        Console.Write(text[i]);
                        i++;
                    } while (i <= endIndex);
                    
                    Console.WriteLine();
                }
                else
                {
                    do
                    {
                        Console.Write(text[i]);
                        i++;
                        
                    } while (i <= endIndex);
                    i--;
                    Console.WriteLine();
                }

                
                
                
            }
        }

        if (hasMatch==false)
        {
            Console.WriteLine("no");
        }
    }
}
