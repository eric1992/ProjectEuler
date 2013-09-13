using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UInt64> values = new List<UInt64>();
            UInt64 temp = 0;
            for (int i = 2; i <= 100; i++)
                for (int j = 2; j <= 100; j++)
                {
                    temp = (UInt64)Math.Pow(i, j);
                    if (!values.Contains(temp))
                        values.Add(temp);
                    else
                        temp = 0;
                }
            Console.Out.WriteLine(values.Count);
            Console.In.Read();
        }
    }
}
