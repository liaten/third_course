using System;

namespace app7._1
{
    public class Complex
    {
        private double its_real;
        private double its_imaginary;
        public Complex(double Real, double Imaginary)
        {
            this.its_real = Real;
            this.its_imaginary = Imaginary;
        }
        public Complex()
        {
            this.its_real = 0;
            this.its_imaginary = 0;
        }
        ~Complex() { }
        public void Write()
        {
            Console.Write($"({Math.Round(its_real,2)}; {Math.Round(its_imaginary,2)})");
        }
        public Complex Sum(Complex c1, Complex c2)
        {
            return new Complex((c1.its_real + c2.its_real), (c1.its_imaginary + c2.its_imaginary));
        }
        public Complex Subtract(Complex dec, Complex sub)
        {
            return new Complex((dec.its_real - sub.its_real), (dec.its_imaginary - sub.its_imaginary));
        }
        public Complex Multi(Complex f1, Complex f2)
        {
            double new_real = (f1.its_real * f2.its_real) - (f1.its_imaginary * f2.its_imaginary);
            double new_im = (f1.its_real * f2.its_imaginary) + (f2.its_real * f1.its_imaginary);
            return new Complex(new_real, new_im);
        }
    }
}
