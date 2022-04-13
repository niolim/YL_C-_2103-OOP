using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{

    internal class Rn
    {
        private int _numerator;
        private int _denominator;

        public Rn(int numerator, int denominator)
        {

            _numerator = numerator;
            _denominator = denominator;
        }


        public static Rn operator *(Rn a, Rn b)
        {
            return new Rn(a._numerator * b._numerator, a._denominator * b._denominator);
        }

        public Rn Reverse()
        {
            return new Rn(_denominator, _numerator);
        }


        public static Rn operator /(Rn a, Rn b)
        {
            return a * b.Reverse();
        }

        public static Rn operator +(Rn a, Rn b)
        {
            if (a._denominator == b._denominator)
            { return new Rn(a._numerator + b._numerator, b._denominator); }
            else
                return new Rn((a._denominator * b._numerator) + (b._denominator * a._numerator), a._denominator * b._denominator);
        }

        public static Rn operator -(Rn a, Rn b)
        {
            if (a._denominator == b._denominator)
            { return new Rn(a._numerator - b._numerator, b._denominator); }
            else
                return new Rn((b._denominator * a._numerator) - (a._denominator * b._numerator), a._denominator * b._denominator);
        }


        private static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static int NOK(int a, int b)
        {
            return a * b / NOD(a, b);
        }

        public Rn Reduce()
        {
            Rn result = this;
            int gcd = NOD(_numerator, _denominator);
            result._numerator /= gcd;
            result._denominator /= gcd;
            return result;
        }


        private int CompareTo(Rn that)
        {
            if (this.Equals(that))
            {
                return 0;
            }
            Rn a = this.Reduce();
            Rn b = that.Reduce();
            if (a._numerator * b._denominator > b._numerator * a._denominator)
            {
                return 1;
            }
            return -1;
        }

        public static bool operator >(Rn a, Rn b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <(Rn a, Rn b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator >=(Rn a, Rn b)
        {
            return a.CompareTo(b) >= 0;
        }

        public static bool operator <=(Rn a, Rn b)
        {
            return a.CompareTo(b) <= 0;
        }

        public bool Equals(Rn that)
        {
            Rn a = this.Reduce();
            Rn b = that.Reduce();
            return a._numerator == b._numerator &&
            a._denominator == b._denominator;

        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is Rn)
            {
                result = this.Equals(obj as Rn);
            }
            return result;
        }

        public override int GetHashCode()
        {
            return (this._numerator * this._numerator + this._denominator * this._denominator);
        }


        public static bool operator ==(Rn a, Rn b)
        {

            Object aAsObj = a as Object;
            Object bAsObj = b as Object;
            if (aAsObj == null || bAsObj == null)
            {
                return aAsObj == bAsObj;
            }
            return a.Equals(b);
        }

        public static bool operator !=(Rn a, Rn b)
        {
            return !(a == b);
        }



        public override string ToString()
        {

            return $"{_numerator}/{_denominator}";

        }


    }

}
