using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem74
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 1000000; i++)
                if (ChainFact(i).Count == 60)
                    count++;
            Console.Out.WriteLine(count);
            Console.In.ReadLine();
        }
        static List<int> ChainFact(int i)
        {
            List<int> chain = new List<int>();
            chain.Add(i);
            for (int copy = DigitsFact(i); !chain.Contains(copy); copy = DigitsFact(copy))
                chain.Add(copy);
            return chain;
            
        }
        static int DigitsFact(int i)
        {
            int sum = 0;
            for (int copy = i; copy > 0; copy /= 10)
                sum += Fact(copy % 10);
            return sum;
        }
        static int Fact(int i)
        {
            int prod = 1;
            for (int copy = i; copy > 1; copy--)
                prod *= copy;
            return prod;
        }

    }
}
