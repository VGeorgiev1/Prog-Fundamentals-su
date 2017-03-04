using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, decimal>> filesDir = new Dictionary<string, Dictionary<string, decimal>>();
            List<string> Roots = new List<string>();
            Dictionary<string, decimal> filteredfiles = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string root = input[0].Trim();
                string filename = input[input.Length - 2].Trim();
                decimal size = decimal.Parse(input[input.Length - 1]);
                if (!filesDir.ContainsKey(root))
                {
                    filesDir[root] = new Dictionary<string, decimal>();

                }
                if (!filesDir[root].ContainsKey(filename))
                {
                    filesDir[root].Add(filename, size);
                }
                else
                {
                    filesDir[root][filename] = size;
                }

            }
            string[] searched = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string extension = "." + searched[0].Trim();
            string folder = searched[2].Trim();
            if (filesDir.ContainsKey(folder))
            {
                foreach (var item in filesDir[folder].Keys)
                {
                    Roots.Add(item);
                }
                for (int i = 0; i < filesDir[folder].Count; i++)
                {
                    string nameAndExt = Roots[i];
                    if (nameAndExt.Contains(extension))
                    {
                        filteredfiles.Add(nameAndExt, filesDir[folder][Roots[i]]);
                    }
                }
            }
            if (filteredfiles.Keys.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in filteredfiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine(item.Key + " - " + item.Value + " KB");
                }
            }
        }
    }
}