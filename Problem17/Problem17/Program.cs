using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Program
    {
        static int[] table = new int[92];
        
	    
        static void Main(string[] args)
        {
            table[1] = 3;
            table[2] = 3;
            table[3] = 5;
            table[4] = 4;
            table[5] = 4;
            table[6] = 3;
            table[7] = 5;
            table[8] = 5;
            table[9] = 3;
            table[10] = 3;
            table[11] = 6;
            table[12] = 6;
            table[13] = 8;
            table[14] = 8;
            table[15] = 7;
            table[16] = 7;
            table[17] = 9;
            table[18] = 9;
            table[19] = 8;
            table[20] = 6;
            table[30] = 6;
            table[40] = 6;
            table[50] = 5;
            table[60] = 5;
            table[70] = 7;
            table[80] = 6;
            table[90] = 6;
            int count = 0;
            for (int i = 1; i <= 1000; i++)
                count += length(i);
            Console.Out.WriteLine(count);
            Console.In.Read();
        }
        static int length(int i)
        {
            if (i == 1000)
                return 11;
            int ones = i % 10;
            int tens = (i / 10) % 10;
            int hundreds = (i / 100) % 10;
            int thousands = (1 / 1000) % 10;
            int retVal = 0;
            if (hundreds == 0)
            {
                int temp = ones + 10 * tens;
                if (temp < 92 && table[temp] > 0)
                    return table[temp];
                return table[10 * tens] + table[ones];
            }
            if (tens == 0 && ones == 0)
                return table[hundreds] + "hundredand".Length;
            return table[hundreds] + "hundredand".Length;

        }
    }
}
