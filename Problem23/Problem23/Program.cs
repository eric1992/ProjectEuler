using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem23
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 395465626;
            List<int> ATable = new List<int>(6965);
            for (int i = 1; i <= 28123; i++)
                if(IsAbundant(i))
                    ATable.Add(i);
            bool summable = false;
            //Every time through incremement and reassume the number can't be written as a sum.
            for (int i = 1; i <= 28123; i++, summable = false)
            {
                for (int a = 0; a < ATable.Count && ATable[a] <= i / 2 && !summable; a++)
                    for (int b = a; b < ATable.Count && ATable[b] <= i - ATable[a] && !summable; b++)
                        if (ATable[a] + ATable[b] == i)
                            summable = true;
                if (summable)
                    sum -= i;
            }
        }
        static bool IsAbundant(int a)
        {
            return d(a) > a;
        }
        static int d(int a)
        {
            if (a == 1 || a == 0)
                return 0;
            int retVal = 1;
            for (int i = 2; i < Math.Sqrt(a); i++)
                if (a % i == 0)
                    retVal += i + (a / i);
            if (a % Math.Sqrt(a) == 0)
                retVal += (int)Math.Sqrt(a);
            return retVal;
        }
    }
}
