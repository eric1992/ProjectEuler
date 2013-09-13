using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Key start, value length

        static int[] hash = new int[3000000];
        static void Main(string[] args)
        {
            int max = 0;
            int temp = 0;
            int answ = 0;
            for (int i = 1; i <= 999999; i++)
            {
                temp = length(i);
                if (temp > max || temp <  0)
                {
                    max = temp;
                    answ = i;
                    Console.Out.WriteLine(answ + " " + max);
                }
            }
            Console.Out.WriteLine(answ + " " + max);
            Console.In.ReadLine();
        }

        static int length(int input)
        {
            if (hash[input] > 0)
                return hash[input];
            int count = 1;
            for (long i = input; i > 1; i = (i % 2 == 0) ? i / 2 : (3 * i) + 1, count++)
            {
                if (i < hash.Length && hash[i] > 0)
                    return count + hash[i];
            }
            hash[input] = count;
            return count;
        }
    }
}
