using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    class Program
    {
        static int[] hash = new int[73400];
        static void Main(string[] args)
        {
            int count = 0;
            for (DateTime a = new DateTime(1901, 1, 1); a < new DateTime(2000, 12, 31); a = a.AddDays(1))
            {
                if (a.Day == 1 && a.DayOfWeek == DayOfWeek.Sunday)
                    count++;
            }
            Console.Out.WriteLine(count);
            Console.In.Read();
        }

    }
}
