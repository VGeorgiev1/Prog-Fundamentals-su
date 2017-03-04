using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFunOctoberExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            int lengt = int.Parse(Console.ReadLine());
            int trackcap = int.Parse(Console.ReadLine());
            decimal moneyperkil = decimal.Parse(Console.ReadLine());
            long capRunners = trackcap * days;
            decimal moneyRaised = 0;
            decimal kms = 0;
            if (runners > capRunners)
            {
                kms = (capRunners * laps * lengt) / 1000;
                moneyRaised = kms * moneyperkil;
            }
            else
            {
                kms = (runners * laps * lengt) / 1000;
                moneyRaised = kms * moneyperkil;
            }

            Console.WriteLine("Money raised: " + String.Format("{0:0.00}", moneyRaised));

        }
    }
}