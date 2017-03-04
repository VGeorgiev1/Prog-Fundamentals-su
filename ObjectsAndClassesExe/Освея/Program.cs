using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Освея
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> files = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\', ';'}, StringSplitOptions.RemoveEmptyEntries);
                string root = input[0];
                int size = int.Parse(input[input.Length - 1]);
                string nameOfFile = input[input.Length - 2];
                if (!files.ContainsKey(root))
                {
                    files[root] = new Dictionary<string, int>();
                    files[root][nameOfFile] = size;
                }
                else
                {
                    files[root][nameOfFile] = size;
                }
            }


        }
    }
}
