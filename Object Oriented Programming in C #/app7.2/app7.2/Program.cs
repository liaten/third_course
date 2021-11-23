using System;

namespace app7._2
{
    public class Program
    {
        public static void Main()
        {
            bool quit = false;
            int answer1;
            while (quit == false)
            {
                Console.Write("(1) - Формы\n(2) - Животные\n(0) - Выйти\n:");
                try
                {
                    answer1 = Convert.ToInt32(Console.ReadLine());
                    if (answer1 < 0 || answer1 > 2) { Console.Write("Неверный формат ввода\n"); }
                    else
                    {
                        int answer2;
                        switch (answer1)
                        {
                            case 0:
                                quit = true;
                                break;
                            case 1:
                                Console.Write("(1) - Круг\n(2) - Прямоугольник\n(3) - Треугольник\n(0) - Выйти\n:");
                                try
                                {
                                    answer2 = Convert.ToInt32(Console.ReadLine());
                                    if (answer2 < 0 || answer2 > 3) { Console.Write("Неверный формат ввода\n"); }
                                    else
                                    {
                                        switch (answer2)
                                        {
                                            case 0:
                                                quit = true;
                                                break;
                                            case 1:
                                                Console.Write("Создаём круг с радиусом: ");
                                                float rad;
                                                try
                                                {
                                                    rad = float.Parse(Console.ReadLine());
                                                    if (rad > 0)
                                                    {
                                                        Circle circle = new Circle(rad);
                                                        Console.Write("Создан круг с радиусом " + rad + "\n");
                                                        Console.Write($"Его периметр: {Math.Round(circle.Perimeter(), 2)}\n");
                                                        Console.Write($"Его площадь: {Math.Round(circle.Area(), 2)}\n");
                                                        Console.Write("Печать круга: \n");
                                                        circle.Print();
                                                        Console.WriteLine();
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Неверный формат ввода\n");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.Write("Неверный формат ввода\n");
                                                }
                                                break;
                                            case 2:
                                                Console.Write("Создаём прямоугольник с шириной: ");
                                                float a1;
                                                try
                                                {
                                                    a1 = float.Parse(Console.ReadLine());
                                                    if (a1 > 0)
                                                    {
                                                        float a2;
                                                        try
                                                        {
                                                            Console.Write("И высотой: ");
                                                            a2 = float.Parse(Console.ReadLine());
                                                            if (a2 > 0)
                                                            {
                                                                Rectangle rec = new Rectangle(a1, a2);
                                                                Console.Write($"Создан прямоугольник с шириной {a1} и высотой {a2}\n");
                                                                Console.Write($"Его периметр: {Math.Round(rec.Perimeter(), 2)}\n");
                                                                Console.Write($"Его площадь: {Math.Round(rec.Area(), 2)}\n");
                                                                Console.Write("Печать прямоугольника: \n");
                                                                rec.Print();
                                                                Console.WriteLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Неверный формат ввода\n");
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Write("Неверный формат ввода\n");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Неверный формат ввода\n");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.Write("Неверный формат ввода\n");
                                                }
                                                break;
                                            case 3:
                                                Console.Write("Создаём треугольник со сторонами:\nСторона 1: ");
                                                float tr1;
                                                try
                                                {
                                                    tr1 = float.Parse(Console.ReadLine());
                                                    if (tr1 > 0)
                                                    {
                                                        float tr2;
                                                        try
                                                        {
                                                            Console.Write("Сторона 2: ");
                                                            tr2 = float.Parse(Console.ReadLine());
                                                            if (tr2 > 0)
                                                            {
                                                                float tr3;
                                                                try
                                                                {
                                                                    Console.Write("Сторона 3: ");
                                                                    tr3 = float.Parse(Console.ReadLine());
                                                                    if (tr3 > 0)
                                                                    {
                                                                        if (
                                                                            // проверка на существование треугольника по 3 сторонам
                                                                            tr1 + tr2 > tr3 &&
                                                                            tr1 + tr3 > tr2 &&
                                                                            tr3 + tr2 > tr1
                                                                            )
                                                                        {
                                                                            Triangle tr = new Triangle(tr1, tr2, tr3);
                                                                            Console.Write($"Создан треугольник со сторонами: {tr1}, {tr2}, {tr3}\n");
                                                                            Console.Write($"Его периметр: {Math.Round(tr.Perimeter(), 2)}\n");
                                                                            Console.Write($"Его площадь: {Math.Round(tr.Area(), 2)}\n");
                                                                            Console.Write("Печать треугольника: \n");
                                                                            tr.Print();
                                                                            Console.WriteLine();
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.Write("Треугольник с такими сторонами не существует\n");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.Write("Неверный формат ввода\n");
                                                                    }
                                                                }
                                                                catch
                                                                {
                                                                    Console.Write("Неверный формат ввода\n");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Неверный формат ввода\n");
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Write("Неверный формат ввода\n");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Неверный формат ввода\n");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.Write("Неверный формат ввода\n");
                                                }
                                                break;
                                        }
                                    }
                                }
                                catch
                                {
                                    Console.Write("Неверный формат ввода\n");
                                }
                                break;
                            case 2:
                                Console.Write("(1) - Собака\n(2) - Утконос\n(0) - Выйти\n:");
                                answer2 = Convert.ToInt32(Console.ReadLine());
                                if (answer2 < 0 || answer2 > 3) { Console.Write("Неверный формат ввода\n"); }
                                else
                                {
                                    switch (answer2)
                                    {
                                        case 0:
                                            quit = true;
                                            break;
                                        case 1:
                                            Dog d = new Dog();
                                            Console.Write("Вы создали собаку\n");
                                            if (d.IsEgg())
                                            {
                                                Console.Write("Собака - яйцо несущее суещество\n");
                                            }
                                            else
                                            {
                                                Console.Write("Собака - живородящее суещество\n");
                                            }
                                            d.Print();
                                            Console.WriteLine();
                                            break;
                                        case 2:
                                            Platypus p = new Platypus();
                                            Console.Write("Вы создали утконоса\n");
                                            if (p.IsEgg())
                                            {
                                                Console.Write("Утконос - яйцо несущее суещество\n");
                                            }
                                            else
                                            {
                                                Console.Write("Утконос - живородящее суещество\n");
                                            }
                                            p.Print();
                                            Console.WriteLine();
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                }
                catch
                {
                    Console.Write("Неверный формат ввода\n");
                }
            }
        }
    }
}
