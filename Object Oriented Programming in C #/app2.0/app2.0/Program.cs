using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2.1:");
            Simple_Cat frisky = new Simple_Cat();
            Console.WriteLine("frisky is " + frisky.Get_Age() + " years old.");
            frisky.Set_Age(5);
            Console.WriteLine("frisky is " + frisky.Get_Age() + " years old.");
            // удаление объекта происходит автоматически из-за особенностей "сборки мусора" на C#
            Console.WriteLine("Задача 2.2:");
            Simple_Cat_2 frisky2 = new Simple_Cat_2();
            Console.WriteLine("frisky is " + frisky2.Get_Age() + " years old.");
            frisky2.Set_Age(5);
            Console.WriteLine("frisky is " + frisky2.Get_Age() + " years old.");
            Console.Write("Дополнительная задача:\nВведите возраст frisky в формате с плавающей запятой: ");
            double age_double = Convert.ToDouble(Console.ReadLine());
            frisky2.Set_Age(age_double);
            Console.WriteLine("frisky is " + frisky2.Get_Age() + " years old.");
            Console.WriteLine("frisky is {0} full years and {1} months old.", frisky2.Get_Years(), frisky2.Get_Months());
            Console.Write("Нажмите любую клавишу, чтобы завершить программу: ");
            Console.ReadKey();
        }
    }
}