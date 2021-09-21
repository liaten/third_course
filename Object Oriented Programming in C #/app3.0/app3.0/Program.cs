using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3._0
{
    class Program
    {
        private static Tuple<int, int> Get_Square_And_Cube(int number)
        {
            return Tuple.Create(number*number, number*number*number);
        }
        public static Simple_Cat_2 f1(Simple_Cat_2 the_cat)
        {
            Console.WriteLine("f1 returning");
            return the_cat;
        }
        public static Simple_Cat_2 f2(Simple_Cat_2 the_cat)
        {
            Console.WriteLine("f2 returning");
            return the_cat;
        }
        public static Simple_Cat_3 f3(Simple_Cat_3 the_cat)
        {
            Console.WriteLine("f3 returning");
            the_cat.Set_Age(7);
            Console.WriteLine("frisky is now " + the_cat.Get_Age() + " years old");
            return the_cat;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1:");
            Simple_Cat frisky = new Simple_Cat(5, 8);
            Simple_Cat r_cat = frisky;
            Console.WriteLine("frisky is " + r_cat.Get_Age() + " years old.");
            Console.WriteLine("frisky is " + r_cat.Get_Weight() + " pounds.");

            Console.WriteLine("\nЗадание 3.2:");
            int num = 5;
            var nn = Program.Get_Square_And_Cube(num);
            Console.WriteLine("Square of number " + num + " is " + nn.Item1);
            Console.WriteLine("Cube of number " + num + " is " + nn.Item2);

            Console.WriteLine("\nЗадание 3.3:");
            Console.WriteLine("Make a cat");
            Simple_Cat_2 frisky2 = new Simple_Cat_2();
            Console.WriteLine("Calling f1");
            f1(frisky2);
            Console.WriteLine("Calling f2");
            f2(frisky2);

            Console.WriteLine("\nЗадание 3.4:");
            Console.WriteLine("Make a cat");
            Simple_Cat_3 frisky3 = new Simple_Cat_3();
            Console.WriteLine("frisky is " + frisky3.Get_Age() + " years old.");
            int age = 5;
            frisky3.Set_Age(age);
            Console.WriteLine("frisky is " + frisky3.Get_Age() + " years old.");
            Console.WriteLine("Calling f3");
            f3(frisky3);
            Console.WriteLine("frisky is " + frisky3.Get_Age() + " years old.");

            Console.ReadKey();
        }
    }
}