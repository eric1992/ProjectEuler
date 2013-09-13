using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem52
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000000; i++)
                if (EqualDigits(DigitsInOrder(i), DigitsInOrder(2 * i)) &&
                   EqualDigits(DigitsInOrder(i), DigitsInOrder(3 * i)) &&
                   EqualDigits(DigitsInOrder(i), DigitsInOrder(4 * i)) &&
                   EqualDigits(DigitsInOrder(i), DigitsInOrder(5 * i)) &&
                   EqualDigits(DigitsInOrder(i), DigitsInOrder(6 * i)))
                    Console.Out.WriteLine(i);
            Console.In.ReadLine();
        }
        static bool EqualDigits(List<int> i, List<int> j)
        {
            if (i.Count != j.Count)
                return false;
            for (int iter = 0; iter < i.Count; iter++)
                if (i[iter] != j[iter])
                    return false;
            return true;
        }
        static List<int> DigitsInOrder(int i)
        {
            List<int> digits = new List<int>();
            for (int copy = i; copy > 0; copy /= 10)
                digits.Add(copy % 10);
            return digits.OrderBy(g => g).ToList();
        }
    }
}
