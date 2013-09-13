using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem34
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 3; i < 1000000; i++)
                if (i == DigitFactorial(i))
                    sum += i;
            Console.Out.WriteLine(sum);
            Console.In.ReadLine();
        }
        static int[] fact = new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
        static int DigitFactorial(int i)
        {
            int sum = 0;
            for (int copy = i; copy > 0; copy /= 10)
            {
                sum += fact[copy % 10];
            }
            return sum;
        }
    }
}
