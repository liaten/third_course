using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1._0
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.1:");
            Cat frisky = new Cat(7);
            Console.WriteLine("frisky is "+frisky.Get_Age()+" years old.");
            frisky.Set_Age(5);
            frisky.Meow();
            Console.WriteLine("frisky is " + frisky.Get_Age() + " years old.");
            frisky.Meow();
            Console.WriteLine("\nЗадание 1.2:");
            Rectangle MyRectangle = new Rectangle(100, 20, 50, 80);
            int Area = MyRectangle.GetArea();
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Upper Left X Coordinate: " + MyRectangle.GetUpperLeft().GetX());
            Console.Write("Нажмите любую клавишу, чтобы завершить программу: ");
            Console.ReadKey();
        }
    }
}