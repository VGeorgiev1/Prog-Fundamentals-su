using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());
        
        for (int i = 0; i < n - 1; i++)
        {
            double c = double.Parse(Console.ReadLine());
            double div = Proc(last, c);
           
          bool isSignificantDifference = imaliDif(div, granica);
            Get(c, last, div, isSignificantDifference);
            

            last = c;
        }
    }

    private static void Get(double c, double last, double razlika, bool etherTrueOrFalse)
    {
        
        if (razlika == 0)
        {
             Console.WriteLine("NO CHANGE: {0}", c);
        }
        else if (!etherTrueOrFalse)
        {
            Console.WriteLine("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            Console.WriteLine("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
            Console.WriteLine("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
        
    }


    private static bool imaliDif(double isDiff, double granica)
    {
        if (Math.Abs(isDiff) >= granica)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double l, double c)
    {
        double r = ((c - l) / l)*100;
        return r;
    }
}
