using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {   
            int curTri = 0;
            int nextAdd = 1;
            bool found = false;
            while (!found)
            {
                curTri += nextAdd++;
                if (numDiv(curTri) > 500)
                    found = true;
            }
            Console.Out.WriteLine(curTri);
            Console.In.ReadLine();
        }

        static int numDiv(int input)
        {
            input = Math.Abs(input);
            int count = 2;
            double sqr = Math.Sqrt(input);
            for (int i = 2; i <= sqr; i++)
            {
                if (i == sqr)
                    count++;
                else if (input % i == 0)
                    count += 2;
            }
            return count;
        }
    }
}
