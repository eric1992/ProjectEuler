using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem46
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> temp = PrimesUnder(1000000);
            for (int i = 33; i < 1000000; i++)
                if (!MeetsCrit(i, temp))
                    Console.Out.WriteLine(i);
        }
        static bool MeetsCrit(int i, List<int> primes)
        {
            int diff;
            int sqrtTest;
            foreach (int curPrim in primes)
            {
                if (curPrim > i)
                    return false;
                diff = i - curPrim;
                diff /= 2;
                sqrtTest = (int)Math.Sqrt(diff);
                if (diff == sqrtTest * sqrtTest)
                    return true;
            }
            return false;
        }
        static List<int> PrimesUnder(int i)
        {
            List<int> retList = new List<int>();
            retList.AddRange(new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23 });
            bool PosPrime = true;
            for (int PriTest = 31; PriTest <= i; PriTest += 2, PosPrime = true)
            {
                for (int d = 0; retList[d] <= Math.Sqrt(PriTest) && PosPrime; d++)
                    if (PriTest % retList[d] == 0)
                        PosPrime = false;
                if (PosPrime)
                    retList.Add(PriTest);
            }
            return retList;
        }
    }
}
