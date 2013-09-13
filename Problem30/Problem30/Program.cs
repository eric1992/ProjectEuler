using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem30
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 2; i < 10000000; i++)
                if (SumDigitToPow(i, 5) == i)
                    sum += i;
            Console.Out.WriteLine(sum);
            Console.In.Read();
        }
        static long SumDigitToPow(int i, int Pow)
        {
            long sum = 0;
            for (int div = i; div > 0; div /= 10)
                sum += (long)Math.Pow(div % 10, Pow);
            return sum;
        }
    }
}
