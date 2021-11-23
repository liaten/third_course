using System;

namespace app7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational rat1 = new Rational(2000, 150000);
            Rational rat2 = new Rational(154, 784);
            Console.Write("rat1:\n");
            rat1.Print();
            rat1.Print_Float();
            Console.Write("\nrat2:\n");
            rat2.Print();
            rat2.Print_Float();
            Console.Write("\nrat1 + rat2:\n");
            rat1.Add(rat2).Print();
            rat1.Add(rat2).Print_Float();
            Console.Write("\nrat1 - rat2:\n");
            rat1.Substract(rat2).Print();
            rat1.Substract(rat2).Print_Float();
            Console.Write("\nrat1 * rat2:\n");
            rat1.Multiple(rat2).Print();
            rat1.Multiple(rat2).Print_Float();
            Console.Write("\nrat1 * rat2:\n");
            rat1.Divide(rat2).Print();
            rat1.Divide(rat2).Print_Float();
            Console.ReadKey();
        }
    }
}
