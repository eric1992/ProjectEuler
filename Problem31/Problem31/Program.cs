using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine(Combo(200, 200));
            Console.In.Read();
             
        }

        static int Combo(int value, int lastCoin)
        {
            if (value < 0)
                return 0;
            if (value == 0)
                return 1;
            int count = 0;
            if(lastCoin >= 200)
                count += Combo(value - 200, 200);
            if(lastCoin >= 100)
                count += Combo(value - 100, 100);
            if(lastCoin >= 50)
                count += Combo(value - 50, 50);
            if(lastCoin >= 20)
                count += Combo(value - 20, 20);
            if(lastCoin >= 10)
                count += Combo(value - 10, 10);
            if(lastCoin >= 5)
                count += Combo(value - 5, 5);
            if(lastCoin >= 2)
                count += Combo(value - 2, 2);
            if(lastCoin >= 1)
                count += Combo(value - 1, 1);
            return count;
        }
    }
}
