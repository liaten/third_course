using System;

namespace app7._3
{
    public class Rational
    {
        private int its_numerator;  // числитель
        private int its_denominator;    // знаменатель
        private int GCF;    // НОД (наибольший общий делитель, greatest common factor)
        public Rational(int num, int den)
        {
            this.its_denominator = den;
            bool num_was_negative;
            if (num < 0)
            {
                num_was_negative = true;
                this.its_numerator = num * (-1);
            }
            else
            {
                num_was_negative = false;
                this.its_numerator = num;
            }
            this.GCF = Get_GCF(its_numerator, its_denominator);
            while (GCF != 1)
            {
                this.its_numerator /= GCF;
                this.its_denominator /= GCF;
                this.GCF = Get_GCF(this.its_numerator, this.its_denominator);
            }
            if (num_was_negative)
            {
                this.its_numerator = num;
            }
        }
        public Rational Add(Rational rat)
        {
            if (this.its_denominator == rat.its_denominator)
            {
                return new Rational
                 (
                     this.its_numerator + rat.its_numerator,
                     this.its_denominator
                 );
            }
            else
            {
                return new Rational
               (
                    (this.its_numerator*rat.its_denominator)+(rat.its_numerator*this.its_denominator),
                    (this.its_denominator*rat.its_denominator)
               );
            }
        }
        public Rational Substract(Rational rat)
        {
            if (this.its_denominator == rat.its_denominator)
            {
                return new Rational
                 (
                     this.its_numerator - rat.its_numerator,
                     this.its_denominator
                 );
            }
            else
            {
                return new Rational
               (
                    (this.its_numerator * rat.its_denominator) - (rat.its_numerator * this.its_denominator ),
                    (this.its_denominator * rat.its_denominator)
               );
            }
        }
        public Rational Multiple(Rational rat)
        {
            return new Rational
                (
                    (this.its_numerator*rat.its_numerator),
                    (this.its_denominator*rat.its_denominator)
                );
        }
        public Rational Divide(Rational rat)
        {
            return new Rational
                (
                    (this.its_numerator * rat.its_denominator),
                    (this.its_denominator * rat.its_numerator)
                );
        }
        private static int Get_GCF(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a | b;
        }
        public string Get()
        {
            return $"{this.its_numerator} / {this.its_denominator}";
        }
        public double Get_Float()
        {
            double num = this.its_numerator;
            double den = this.its_denominator;
            double result = num / den;
            return Math.Round(result, 4);
        }
        public void Print()
        {
            Console.WriteLine(this.Get());
        }
        public void Print_Float()
        {
            Console.WriteLine(this.Get_Float());
        }
    }
}
