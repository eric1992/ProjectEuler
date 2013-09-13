using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem96
{
    class Program
    {
        static void Main(string[] args)
        {
            Puzzle a = new Puzzle();
            a.SetTo(0, 0, 1);
            a.SetTo(0, 1, 2);
            a.SetTo(0, 2, 3);
            a.EliminateFromHoriz(0, 3);
        }
        
    }
    class Puzzle
    {
        List<int>[,] grid = new List<int>[9, 9];
        public Puzzle()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = new List<int>();
                    grid[i, j].AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                }
        }
        public bool SetTo(int i, int j, int V)
        {
            if (V < 0 || V > 8)
                return false;
            if (i < 0 || i > 8)
                return false;
            if (j < 0 || j > 8)
                return false;
            grid[i, j] = new List<int>();
            grid[i, j].Add(V);
            return true;
        }
        public void Solve()
        {
            bool Solved = IsSolved();
            while (!Solved)
            {                
                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (grid[i, j].Count != 1)
                        {

                        }
                    }
            }
        }
        public void EliminateFromHoriz(int i, int j)
        {
            for(int Col = 0; Col < 9; Col++)
                if (Col != j)
                    if (grid[i, Col].Count == 1)
                        grid[i, j].Remove(grid[i, Col][0]);
        }
        public bool IsSolved()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (grid[i, j].Count != 1)
                        return false;
            return true;
        }
    }
}
