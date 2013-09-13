using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem40
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = new List<int>();
            for(int i = 0; digits.Count < 1000000; i++)
                for (int digit = (int)Math.Pow(10, (int) Math.Floor(Math.Log10(i))); digit > 0; digit /= 10)
                    digits.Add((i / digit) % 10);
            Console.Out.WriteLine(digits[0] * digits[9] * digits[99] * digits[999] * digits[9999] * digits[99999] * digits[999999]);
            Console.In.ReadLine();
        }
    }
}
