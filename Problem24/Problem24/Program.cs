using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> temp = new List<int>(3628800);
            for (int i = 3628800; i > 0; i--)
                temp.Add(i);
            temp = temp.OrderBy(g => g).ToList();
        }
    }
}
