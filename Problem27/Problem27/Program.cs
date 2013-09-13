using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem27
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static bool IsPrime(int i)
        {
            if( i <= 1)
                return false;
            for (int d = 2; d <= Math.Sqrt(i); d++)
                if (i % d == 0)
                    return false;
            return true;
        }
        static List<int> PrimesUnder(int i)
        {
            List<int> retList = new List<int>();
            retList.AddRange(new List<int>(){2,3,5,7,11,13,17,19,23});
            for (int PriTest = 31; PriTest <= i; PriTest++)
            {
                for(int d = 0; retList[d] <= Math.Sqrt(PriTest); d++)
                    if(PriTest % retList[d] == 0)
            }
            return retList;
        }
    }
}
