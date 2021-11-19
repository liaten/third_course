using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.1:");
            Rectangle rect = new Rectangle(30,5);
            Console.WriteLine("Draw");
            rect.Draw();
            Console.WriteLine("Draw");
            rect.Draw(10, 4);

            Console.WriteLine("\nЗадание 4.2:");
            /*
             * Под понятием «перегрузка» понимается использование
             * одного и того же имени метода несколько раз при его
             * объявлении в классе. Если вызывается перегруженный
             * метод, то из нескольких объявленных методов
             * компилятор автоматически определяет нужный метод
             * по его параметрам, которые указываются при вызове.
             */
            Rectangle2 rect1 = new Rectangle2();
            Console.WriteLine("rect1 width: " + rect1.Get_Width());
            Console.WriteLine("rect1 length: " + rect1.Get_Length());
            Console.Write("enter a width: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a length: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Rectangle2 rect2 = new Rectangle2(a, b);
            Console.WriteLine("rect2 width: " + rect2.Get_Width());
            Console.WriteLine("rect2 length: " + rect2.Get_Length());

            Console.WriteLine("\nЗадание 4.3:");
            Counter i = new Counter();
            Console.WriteLine("Value of counter is " + i.Get_Its_Value());
            i.increment();
            Console.WriteLine("Value of counter is " + i.Get_Its_Value());
            ++i;
            Console.WriteLine("Value of counter is " + i.Get_Its_Value());

            Console.WriteLine("\nЗадание 4.4:");
            Counter2 i2 = new Counter2();
            Console.WriteLine("Value of counter is " + i2.Get_Its_Value());
            i2++;
            Console.WriteLine("Value of counter is " + i2.Get_Its_Value());
            ++i2;
            Console.WriteLine("Value of counter is " + i2.Get_Its_Value());

            Counter2 a2 = new Counter2();
            a2 = ++i2;
            Console.WriteLine("Value of a is " + a2.Get_Its_Value());
            Console.WriteLine("Value of counter is " + i2.Get_Its_Value());

            a2 = i2++;
            Console.WriteLine("Value of a is " + a2.Get_Its_Value());
            Console.WriteLine("Value of counter is " + i2.Get_Its_Value());

            Console.WriteLine("\nЗадание 4.5:");
            int a3 = 2;
            Counter3 var1 = new Counter3(a3);
            Counter3 var2 = new Counter3(5);
            Counter3 var3;
            var3 = var1 + var2;
            Console.WriteLine("var1 = " + var1.Get_Its_Value());
            Console.WriteLine("var2 = " + var2.Get_Its_Value());
            Console.WriteLine("var3 = " + var3.Get_Its_Value());
            Console.ReadKey();
        }
    }
}
