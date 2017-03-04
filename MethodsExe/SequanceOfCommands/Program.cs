using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = new long[sizeOfArray];
        array = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        string[] command = Console.ReadLine().Split(' ');

        while (!command[0].Equals("stop"))
        {
            
            int[] args = new int[2];

            if (command[0].Equals("add") ||
                command[0].Equals("subtract") ||
                command[0].Equals("multiply"))
            {
                
                args[0] = int.Parse(command[1]);
                args[1] = int.Parse(command[2]);

                PerformAction(array, command[0], args);
            }

           else if (command[0] == "rshift")
            {
               array=ArrayShiftRight(array);
            }
            else
            {
                array=ArrayShiftLeft(array);
            }

            PrintArray(array);
            

            command = Console.ReadLine().Split(' ');
            Console.WriteLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
       
        switch (action)
        {

            case "multiply":
                arr[args[0]-1] = arr[args[0]-1] * args[1];
                break;
            case "add":
                arr[args[0]-1] = arr[args[0]-1] + args[1];
                break;
            case "subtract":
                arr[args[0]-1] = arr[args[0]-1] - args[1];
                break;
           
        }
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long current;
        long current2;
        current=array[0];
        array[0] = array[array.Length - 1];
        for (int i =1; i < array.Length; i++)
        {
            current2 = array[i];
            array[i] = current;
            current = current2;
        }
        return array;
        
    }

    private static long[] ArrayShiftLeft(long[] array)
    {

        long current;
        long current2;
        current = array[array.Length-1];
        array[array.Length-1] = array[0];
        for (int i = array.Length-2; i>=0; i--)
        {
            current2 = array[i];
            array[i] = current;
            current = current2;
        }
        return array;
        //3 0 9 333 11
    }

    private static void PrintArray(long[] array)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        
    }
}
