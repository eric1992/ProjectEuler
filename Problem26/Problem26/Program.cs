using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem26
{
    class Program
    {
        static void Main(string[] args)
        {
            Quoetient x = new Quoetient();
        }
    }
    public class Quoetient
    {
        public Quoetient()
        {
            _Numerator = 1;
            _Denominator = 1;
            _digits = new List<int[]>();
            GenerateDigits();

        }
        private List<int[]> _digits;
        private int _Numerator;
        public int Numerator
        {
            get
            {
                return _Numerator;
            }
            set
            {
                if (value != _Numerator)
                {
                    _Numerator = value;
                    GenerateDigits();
                }
            }
        }
        private int _Denominator;
        public int Denominator
        {
            get
            {
                return _Denominator;
            }
            set
            {
                if (value != _Numerator)
                {
                    _Numerator = value;
                    GenerateDigits();
                }
            }
        }
        public void GenerateDigits()
        {
            _digits.RemoveAll(g => true);
            for(int index = 0
        }
    }
}
