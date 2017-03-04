using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadybugsIndexes
{
    class Program
    {
        private static object filed;

        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0 && x < fieldSize)
               .ToArray();
            int[] filed = new int[fieldSize];
            for (int i = 0; i < indexes.Length; i++)
            {
                int curInd = indexes[i];
                filed[curInd] = 1;
            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                int start = int.Parse(command[0]);
                string direction = command[1];
                int moves = int.Parse(command[2]);
                if (start >= 0 && start < fieldSize)
                {
                    if (direction == "left" && filed[start] == 1)
                    {
                        if (moves < 0)
                        {
                            filed = MoveRight(start, Math.Abs(moves), filed, fieldSize);
                        }
                        else
                        {
                            filed = MoveLeft(start, moves, filed, fieldSize);
                        }
                    }
                    else if (direction == "right" && filed[start] == 1)
                    {
                        if (moves < 0)
                        {
                            filed = MoveLeft(start, Math.Abs(moves), filed, fieldSize);
                        }
                        else
                        {
                            filed = MoveRight(start, moves, filed, fieldSize);
                        }
                    }
                }
                command = Console.ReadLine().Split();

            }

            Console.WriteLine(string.Join(" ", filed));

        }

        private static int[] MoveLeft(int start, int moves, int[] filed, int fieldSize)
        {

            if (start - Math.Abs(moves) < 0)
            {
                filed[start] = 0;
            }
            else
            {

                if (filed[start - moves] == 0)
                {
                    filed[start] = 0;
                    filed[start - moves] = 1;
                }
                else
                {
                    for (int m = start - moves; ; m--)
                    {
                        if (m < 0)
                        {
                            filed[start] = 0;
                            break;
                        }
                        else if (filed[m] == 0)
                        {
                            filed[start] = 0;
                            filed[m] = 1;
                            break;
                        }
                    }
                }
            }
            return filed;

        }
        private static int[] MoveRight(int start, int moves, int[] field, int fieldSize)
        {

            if (start + Math.Abs(moves) >= fieldSize)
            {
                field[start] = 0;
            }
            else
            {

                if (field[start + moves] == 0)
                {
                    field[start] = 0;
                    field[start + moves] = 1;
                }
                else
                {
                    for (int m = start + moves; ; m++)
                    {
                        if (m >= field.Length)
                        {
                            field[start] = 0;
                            break;
                        }
                        else if (field[m] == 0)
                        {
                            field[start] = 0;
                            field[m] = 1;
                            break;
                        }
                    }
                }
            }
            return field;
        }
    }
}
