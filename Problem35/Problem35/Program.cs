using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem35
{
    class Program
    {
        static List<int> PUM = PrimesUnder(1000000);
        static void Main(string[] args)
        {
            int count = 0;
            foreach (int i in PUM)
            {
                if (IsCircular(i))
                    count++;
            }
        }
        static bool IsCircular(int i)
        {
            if(i > 1000000)
                return false;
            int iCopy = i;
            int digit = (i <= 9) ? 1 : (i <= 99) ? 2 : (i <= 999) ? 3 : (i <= 9999) ? 4 : (i <= 99999) ? 5 : (i <= 999999) ? 6 : 7;
            int lead;
            do
            {
                lead = iCopy % 10;
                iCopy /= 10;
                iCopy += lead * (int)Math.Pow(10,(digit - 1));
                if(!PUM.Contains(iCopy))
                    return false;
            }while(iCopy != i);
            return true;
        }
        static List<int> PrimesUnder(int i)
        {
            List<int> retList = new List<int>();
            retList.AddRange(new List<int>(){2,3,5,7,11,13,17,19,23}); 
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
