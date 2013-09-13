using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem36
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 1000000; i++)
                if (Is10Pal(i) && Is2Pal(i))
                    sum += i;
            Console.Out.WriteLine(sum);
            Console.In.ReadLine();
        }
        static bool Is10Pal(int i)
        {
            List<int> digits = new List<int>();
            for (int copy = i; copy > 0; copy /= 10)
                digits.Add(copy % 10);
            for (int lo = 0, hi = digits.Count - 1; hi >= lo; lo++, hi--)
                if (digits[lo] != digits[hi])
                    return false;
            return true;

        }
        static bool Is2Pal(int i)
        {
            List<int> digits = new List<int>();
            for (int copy = i; copy > 0; copy /= 2)
                digits.Add(copy % 2);
            for (int lo = 0, hi = digits.Count - 1; hi >= lo; lo++, hi--)
                if (digits[lo] != digits[hi])
                    return false;
            return true;
        }
    }
}
