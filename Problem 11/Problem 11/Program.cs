using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int[,] grid = new int[20, 20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    String toParse = input[i].Substring(3 * j, 2);
                    grid[i, j] = int.Parse(toParse);
                }
            }
            int greatest = 0;
            int horzT = 0;
            int vertT = 0;
            int diaLR = 0;
            int diaRL = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 3; j < 20; j++)
                {
                    horzT = grid[i, j] * grid[i, j - 1] * grid[i, j - 2] * grid[i, j - 3];
                    if (horzT > greatest)
                        greatest = horzT;
                }
            }
            for (int i = 3; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    vertT = grid[i, j] * grid[i - 1, j] * grid[i - 2, j] * grid[i - 3, j];
                    if (vertT > greatest)
                        greatest = horzT;
                }
            }
            for (int i = 3; i < 20; i++)
            {
                for (int j = 3; j < 20; j++)
                {
                    diaLR = grid[i, j] * grid[i - 1, j - 1] * grid[i - 2, j - 2] * grid[i - 3, j - 3];
                    if (diaLR > greatest)
                        greatest = horzT;
                }
            }
            for (int i = 3; i < 20; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    horzT = grid[i, j] * grid[i - 1, j + 1] * grid[i - 2, j + 2] * grid[i - 3, j + 3];
                    if (horzT > greatest)
                        greatest = horzT;
                }
            }
            System.Console.Out.WriteLine(greatest);
            System.Console.ReadLine();
        }

    }
}
