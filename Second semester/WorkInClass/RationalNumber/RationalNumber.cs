using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumber
{
    public class RationalNumber
    {
        private long numerator, denominator;

        public RationalNumber(long num, long denom)
        {
            numerator = num;
            denominator = denom;

            Simplify();
        }

        public RationalNumber()
        {
            numerator = 0;
            denominator = 1;
        }

        public static RationalNumber operator + (RationalNumber a, RationalNumber b)
        {
            var gcd = GreatestCommonDivisor(a.denominator, b.denominator);

            var denom = a.denominator * b.denominator;
            var numer = a.numerator * b.denominator + b.numerator * a.denominator;

            var result = new RationalNumber(numer, denom);
            return result;
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            return a + new RationalNumber(-b.numerator, b.denominator);
        }

        public static RationalNumber operator -(RationalNumber a)
        {
            return new RationalNumber(-a.numerator, a.denominator);
        }

        public static bool operator == (RationalNumber a, RationalNumber b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            var diff = a - b;
            return diff.numerator > 0;
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return !(a > b) && a != b;
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a > b || a == b;
        }

   
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return !(a > b);
        }

        public static implicit operator RationalNumber(long a)
        {
            return new RationalNumber(a, 1);
        }

        public static RationalNumber operator*(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.numerator, a.denominator * b.denominator);
        }

        public static RationalNumber operator/(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * a.denominator, a.denominator * b.numerator);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            var other = obj as RationalNumber;

            if (other == null)
            {
                return false;
            }

            return numerator == other.numerator && denominator == other.denominator;
        }

        public override int GetHashCode()
        {
            return string.Format("{0}/{1}", numerator, denominator).GetHashCode();
        }

        public override string ToString()
        {
            if (denominator != 1)
            {
                return string.Format("{0}/{1}", numerator, denominator);
            }

            return numerator.ToString();
        }

        private void Simplify()
        {
            if (numerator == 0 && denominator != 0)
            {
                denominator = 1;
            }

            if (numerator == 0 || denominator == 0)
            {
                return;
            }
            var gcd = GreatestCommonDivisor(numerator, denominator);

            numerator /= gcd;
            denominator /= gcd;

            if (denominator < 0)
            {

            }
        }

        static private long GreatestCommonDivisor(long a, long b)
        {
            if (a == 0 || b == 0)
            {
                throw new InvalidOperationException("GCD of a zero value");
            }

            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
    }
}
