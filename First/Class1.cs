using System;

namespace PracticeC_
{
    internal class TripleNumber
    {
        private int _a;
        private int _b;
        private int _c;

        public TripleNumber()
        {
            _a = 5;
            _b = 5;
            _c = 5;
        }

        public TripleNumber(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public TripleNumber(TripleNumber other)
        {
            _a = other._a;
            _b = other._b;
            _c = other._c;
        }

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int B
        {
            get { return _b; }
            set { _b = value; }
        }

        public int C
        {
            get { return _c; }
            set { _c = value; }
        }

        public int MaxLastDigit()
        {
            int lastA = Math.Abs(_a % 10);
            int lastB = Math.Abs(_b % 10);
            int lastC = Math.Abs(_c % 10);

            if (lastA >= lastB && lastA >= lastC)
            {
                return lastA;
            }
            else if (lastB >= lastA && lastB >= lastC)
            {
                return lastB;
            }
            else
            {
                return lastC;
            }
        }

        public override string ToString()
        {
            return $"A = {_a}, B = {_b}, C = {_c}";
        }
    }
}