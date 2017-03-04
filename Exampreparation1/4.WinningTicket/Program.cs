using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets= Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                string curTicket = tickets[i].Trim();
                if (curTicket.Length < 20 || curTicket.Length>20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    int row = 1;
                    int row2 = 1;
                    string firstHalf = curTicket.Substring(0, curTicket.Length / 2);
                    string secondtHalf = curTicket.Substring(curTicket.Length / 2);
                    char curSymbol = firstHalf[0];
                    int maxrow = 0;
                    int maxrow2 = 0;
                    char winChar=' ';
                    char winChar2 = ' ';
                    
                    for (int b = 1; b < firstHalf.Length; b++)
                    {
                        if ((firstHalf[b]=='@'|| firstHalf[b] == '#' || firstHalf[b] == '$' || firstHalf[b] == '^') && firstHalf[b]==curSymbol)
                        {
                            row++;
                            if (row > maxrow)
                            {
                                maxrow = row;
                                winChar = curSymbol;
                            }
                        }
                        else
                        {
                            row=1;
                            curSymbol = firstHalf[b];
                        }
                    }
                    char curSymbol2 = secondtHalf[0];
                    for (int c = 1; c < secondtHalf.Length; c++)
                    {
                        if (secondtHalf[c] == curSymbol2 && (secondtHalf[c] == '@' || secondtHalf[c] == '#' || secondtHalf[c] == '$' || secondtHalf[c] == '^'))
                        {
                            row2++;
                            if (row2 > maxrow2)
                            {
                                maxrow2 = row2;
                                winChar2 = curSymbol2;
                            }
                        }
                        else
                        {
                            row2 = 1;
                            curSymbol2 = secondtHalf[c];
                        }

                    }
                    if((maxrow<6 || maxrow2 < 6) || (winChar!=winChar2))
                    {
                        Console.WriteLine("ticket \"" + curTicket + "\" - no match");
                    }
                    else
                    {
                        int win = Math.Min(maxrow,maxrow2);
                        if (win == 10)
                        {
                            Console.WriteLine("ticket \"" + curTicket + "\" - " + win + winChar + " Jackpot");
                        }
                        else
                        {
                            Console.WriteLine("ticket \"" + curTicket + "\" - " + win + winChar);
                        }
                    }
                }
            }

        }
    }
}
