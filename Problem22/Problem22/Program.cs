using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem22
{
    class Program
    {
        static Dictionary<string, int> alph = new Dictionary<string, int>
        {
            {"a",1},
            {"b",2},
            {"c",3},
            {"d",4},
            {"e",5},
            {"f",6},
            {"g",7},
            {"h",8},
            {"i",9},
            {"j",10},
            {"k",11},
            {"l",12},
            {"m",13},
            {"n",14},
            {"o",15},
            {"p",16},
            {"q",17},
            {"r",18},
            {"s",19},
            {"t",20},
            {"u",21},
            {"v",22},
            {"w",23},
            {"x",24},
            {"y",25},
            {"z",26}
        };
        static void Main(string[] args)
        {
            string input = File.ReadAllText("names.txt");
            List<string> fin = input.Split(new string[] { "\",\""}, StringSplitOptions.None).ToList();
            fin[0] = fin[0].Substring(1);
            fin[fin.Count - 1] = fin[fin.Count - 1].Substring(0, fin[fin.Count - 1].Length - 2);
            List<string> fin2 = fin.OrderBy(g => g).ToList();
            long retscore = 0;
            for (long i = 0; i < fin2.Count; i++)
            {
                long tScore = (i + 1) * score(fin2[(int)i]);
                retscore += tScore;
            }
            Console.Out.WriteLine(retscore);

        }
        static long score(string a)
        {
            if (a.Equals(""))
                return 0;
            a = a.ToLower();
            long count = 0;
            foreach(char b in a)
            {
                count += alph[b.ToString()];
            }
            return count;
        }
    }
}
