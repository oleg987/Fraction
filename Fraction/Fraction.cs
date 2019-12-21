using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        //private int numerator;
        private int denominator;

        public int Numerator { get; set; }
        public int Denominator 
        { 
            get => denominator; 
            set 
            {
                if (value == 0)
                {
                    throw new Exception("Denominator can`t be zero");
                }
                else if (value < 0)
                {
                    denominator = Math.Abs(value);
                    Numerator *= -1;
                }
                else
                {
                    denominator = value;
                }
            }
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void Sum(Fraction fraction)
        {
            if (Denominator == fraction.Denominator)
            {
                Numerator += fraction.Numerator;
            }
            else
            {
                int commonDenominator = Denominator * fraction.Denominator;
                int commonNumerator = Numerator * fraction.Denominator + fraction.Numerator * Denominator;

                Numerator = commonNumerator;
                Denominator = commonDenominator;
            }
        }

        public void Substract(Fraction fraction)
        {
            if (Denominator == fraction.Denominator)
            {
                Numerator -= fraction.Numerator;
            }
            else
            {
                int commonDenominator = Denominator * fraction.Denominator;
                int commonNumerator = Numerator * fraction.Denominator - fraction.Numerator * Denominator;
                Numerator = commonNumerator;
                Denominator = commonDenominator;
            }
        }

        public void Simplify()
        { }

        public void Multiple(Fraction fraction)
        {
            Numerator *= fraction.Numerator;
            Denominator *= fraction.Denominator;
            fraction.Simplify();
        }

        public Fraction Reverse()
        {
            Fraction fraction = new Fraction(Denominator, Numerator);
            return fraction;
        }

        public void Divide(Fraction fraction)
        {
            Multiple(fraction.Reverse());
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        
        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            fraction1.Sum(fraction2);
            return fraction1;
        }

        public static Fraction operator +(Fraction fraction1, int num)
        {
            fraction1.Sum(new Fraction(num * fraction1.Denominator, fraction1.Denominator));
            return fraction1;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            fraction1.Substract(fraction2);
            return fraction1;
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            fraction1.Multiple(fraction2);
            return fraction1;
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            fraction1.Divide(fraction2);
            return fraction1;
        }
        
    }
}
