using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        ~Complex() { }
        public void Write()
        {
            Console.Write($"({its_real}; {its_imaginary})");
        }
    }
}
