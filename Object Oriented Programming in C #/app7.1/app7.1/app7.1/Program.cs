using System;
using System.Collections.Generic;
using System.Linq;

namespace app7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Занятие 7.1. Классы\n");
            bool quit = false;
            int answer = 0;
            List<Complex> CNumbers = new List<Complex>();
            CNumbers.Add(new Complex(12.5, 15.4));
            CNumbers.Add(new Complex(18.22, 20.77));
            while (!quit)
            {
                Console.Write("(1) - добавить новое комплексное число(КЧ)\n" +
                    "(2) - удалить КЧ\n" +
                    "(3) - сложить два КЧ\n" +
                    "(4) - вычесть из одного КЧ - другое КЧ\n" +
                    "(5) - умножить два КЧ\n" +
                    "(6) - печать КЧ на экран\n" +
                    "(0) - завершить выполнение программы\n:");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Введите значение в диапазоне 0..6\n");
                    continue;
                }
                switch (answer)
                {
                    // выход
                    case 0:
                        quit = true;
                        break;
                    // добавление
                    case 1:
                        double RealPart;
                        double ImaginaryPart;
                        Console.Write("Введите RealPart: ");
                        try
                        {
                            RealPart = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Введено не число");
                            break;
                        }
                        Console.Write("Введите ImaginaryPart: ");
                        try
                        {
                            ImaginaryPart = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Введено не число");
                            break;
                        }
                        CNumbers.Add(new Complex(RealPart, ImaginaryPart));
                        break;
                    // удаление
                    case 2:
                        if (CNumbers.Count() == 0)
                        {
                            Console.Write("Нет комплексных чисел для удаления\n");
                        }
                        else
                        {
                            Console.Write($"Выберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1}\n:");
                            int result;
                            try
                            {
                                result = Convert.ToInt32(Console.ReadLine());
                                if (result >= 0 && result <= CNumbers.Count() - 1)
                                {
                                    CNumbers.RemoveAt(result);
                                    Console.Write($"КЧ {1} удалено\n");
                                }
                                else
                                {
                                    Console.Write("Число не в диапазоне\n");
                                }
                            }
                            catch
                            {
                                Console.Write("Введено не число\n");
                            }
                        }
                        break;
                    // сложение
                    case 3:
                        if (CNumbers.Count() == 0)
                        {
                            Console.Write("Нет комплексных чисел для Сложения\n");
                        }
                        else
                        {
                            Console.Write($"Выберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1} в качестве слагаемого\n:");
                            int result;
                            try
                            {
                                result = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Write("Введено не число\n");
                            }
                        }
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        if (CNumbers.Count() == 0)
                        {
                            Console.Write("Нет комплексных чисел для вывода\n");
                        }
                        else
                        {
                            if (CNumbers.Count() > 1)
                            {
                                Console.Write($"Выберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1}\n:");
                                int result;
                                try
                                {
                                    result = Convert.ToInt32(Console.ReadLine());
                                    if (result >= 0 && result <= CNumbers.Count() - 1)
                                    {
                                        Console.Write($"CNumbers[{result}] = ");
                                        CNumbers[result].Write();
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.Write("Число не в диапазоне\n");
                                    }
                                }
                                catch
                                {
                                    Console.Write("Введено не число\n");
                                }
                            }
                            else
                            {
                                Console.Write($"CNumbers[0] = ");
                                CNumbers[0].Write();
                                Console.WriteLine();
                            }
                        }
                        break;
                    default:
                        Console.Write("Введите значение в диапазоне 0..6\n");
                        continue;

                }
            }
        }
    }
}
