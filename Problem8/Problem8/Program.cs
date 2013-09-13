using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string fin = "";
            for (int i = 0; i < lines.Length; i++)
            {
                fin += lines[i];
            }
            int[] values = new int[fin.Length];
            for (int i = 0; i < fin.Length; i++)
            {
                values[i] = int.Parse(fin.ElementAt(i).ToString());
            }
            int greatest = 0;
            for (int i = 4; i < values.Length; i++)
            {
                int tempCalc = values[i - 4] * values[i -3] * values[i-2] * values[i-1] * values[i];
                if (tempCalc > greatest)
                    greatest = tempCalc;
            }
            System.Console.WriteLine(greatest);
            System.Console.ReadLine();
        }
    }
}
