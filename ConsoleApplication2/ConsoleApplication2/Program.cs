using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000000; i++)
                for (int j = i - 1; j > 0 && j < i; j--)
                    if (IsPent(NthPent(i) + NthPent(j)))
                        if (IsPent(Math.Abs(NthPent(i) - NthPent(j))))
                            Console.Out.WriteLine(Math.Abs(NthPent(i) - NthPent(j)));
        }
        static List<int> UpToNthPent(int n)
        {
            List<int> retVal = new List<int>();
            for (int i = 1; i <= n; i++)
                retVal.Add(NthPent(i));
            return retVal;
        }
        static int NthPent(int n)
        {
            return n * (3 * n - 1) / 2;
        }
        static bool IsPent(int n)
        {
            int test = (1 + (int)Math.Sqrt(1 + 24 * n)) / 6;
            return NthPent(test) == n;
        }
    }
}
