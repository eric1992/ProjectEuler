using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem37
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> PrimeUnder = PrimesUnder(1000000);
            int sum = 0;
            foreach (int i in PrimeUnder)
                if (IsTruncatable(i, PrimeUnder))
                {
                    sum += i;
                }
            Console.Out.WriteLine(sum);
            Console.In.Read();
        }
        static bool IsTruncatable(int i, List<int> primes)
        {
            if (new int[] { 2, 3, 5, 7 }.Contains(i))
                return false;
            for (int a = i; a > 0; a /= 10)
                if (!primes.Contains(a))
                    return false;
            for (int a = 10; a <= i; a *= 10)
                if (!primes.Contains(i % a))
                    return false;
            return true;
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
