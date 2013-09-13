using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem49
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Primes = PrimesUnder(9999);
            List<int> GPrimes = PrimesUnder(20000);
            int i2 = 0;
            int i3 = 0;
            for(int i = Primes.Count - 1; Math.Floor(Math.Log10(Primes[i])) == 3; i--)
            {
                i2 = Primes[i] + 3330;
                i3 = Primes[i] + 6660;
                if (GPrimes.Contains(Primes[i]) && GPrimes.Contains(i2) && GPrimes.Contains(i3) && Perm(Primes[i], i2) && Perm(Primes[i], i3))
                {
                    Console.Out.WriteLine( Primes[i].ToString() + i2.ToString() + i3.ToString());
                }
            }
            Console.In.ReadLine();
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
        static bool Perm(int i, int j)
        {
            List<int> digitsI = new List<int>();
            List<int> digitsJ = new List<int>();
            for (int copy = i; copy > 0; copy /= 10)
                digitsI.Add(copy % 10);
            for (int copy = j; copy > 0; copy /= 10)
                digitsJ.Add(copy % 10);
            if (digitsI.Count != digitsJ.Count)
                return false;
            digitsI = digitsI.OrderBy(g => g).ToList();
            digitsJ = digitsJ.OrderBy(g => g).ToList();
            for (int it = 0; it < digitsJ.Count; it++)
                if (digitsI[it] != digitsJ[it])
                    return false;
            return true;
        }
    }
}
