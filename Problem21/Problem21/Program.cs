using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem21
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 10000; i++)
            {
                if (d(d(i)) == i && i != d(i))
                    count += i;
            }
        }
        static int d(int a)
        {
            if (a == 1 || a == 0)
                return 0;
            int retVal = 1;
            for (int i = 2; i < a; i++)
                if (a % i == 0)
                    retVal += i;
            return retVal;
        }
    }
}
