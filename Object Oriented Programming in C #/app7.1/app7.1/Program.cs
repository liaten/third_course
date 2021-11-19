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
                            Console.Write("Нет комплексных чисел для сложения\n");
                        }
                        else
                        {
                            Console.Write($"Выберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1} в качестве слагаемого 1\n:");
                            int result1;
                            int result2;
                            try
                            {
                                // введено число
                                result1 = Convert.ToInt32(Console.ReadLine());
                                if (result1 >= 0 && result1 <= (CNumbers.Count() - 1))
                                {
                                    // число в промежутке
                                    Console.Write($"Выбрано CNumbers[{result1}] = ");
                                    CNumbers[result1].Write();
                                    Console.Write($"\nВыберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1} в качестве слагаемого 2\n:");
                                    try
                                    {
                                        result2 = Convert.ToInt32(Console.ReadLine());
                                        if (result2 >= 0 && result2 <= (CNumbers.Count() - 1))
                                        {
                                            // число в промежутке
                                            Console.Write($"Выбрано CNumbers[{result2}] = ");
                                            CNumbers[result2].Write();
                                            Complex CSum = new Complex().Sum(CNumbers[result1], CNumbers[result2]);
                                            Console.Write($"\nРезультат суммы CNumbers[{result1}] + CNumbers[{result2}] = ");
                                            CSum.Write();
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            // число не в промежутке
                                            Console.Write("Число не в промежутке\n");
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Write("Введено не число\n");
                                        break;
                                    }
                                }
                                else
                                {
                                    // число не в промежутке
                                    Console.Write("Число не в промежутке\n");
                                    break;
                                }
                            }
                            catch
                            {
                                // введено не число
                                Console.Write("Введено не число\n");
                                break;
                            }
                        }
                        break;
                    // разница
                    case 4:
                        if (CNumbers.Count() == 0)
                        {
                            Console.Write("Нет комплексных чисел для вычитания\n");
                        }
                        else
                        {
                            Console.Write($"Выберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1} в качестве уменьшаемого\n:");
                            int result1;
                            int result2;
                            try
                            {
                                // введено число
                                result1 = Convert.ToInt32(Console.ReadLine());
                                if (result1 >= 0 && result1 <= (CNumbers.Count() - 1))
                                {
                                    // число в промежутке
                                    Console.Write($"Выбрано CNumbers[{result1}] = ");
                                    CNumbers[result1].Write();
                                    Console.Write($"\nВыберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1} в качестве вычитаемого\n:");
                                    try
                                    {
                                        result2 = Convert.ToInt32(Console.ReadLine());
                                        if (result2 >= 0 && result2 <= (CNumbers.Count() - 1))
                                        {
                                            // число в промежутке
                                            Console.Write($"Выбрано CNumbers[{result2}] = ");
                                            CNumbers[result2].Write();
                                            Complex CSub = new Complex().Subtract(CNumbers[result1], CNumbers[result2]);
                                            Console.Write($"\nРезультат разности CNumbers[{result1}] - CNumbers[{result2}] = ");
                                            CSub.Write();
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            // число не в промежутке
                                            Console.Write("Число не в промежутке\n");
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Write("Введено не число\n");
                                        break;
                                    }
                                }
                                else
                                {
                                    // число не в промежутке
                                    Console.Write("Число не в промежутке\n");
                                    break;
                                }
                            }
                            catch
                            {
                                // введено не число
                                Console.Write("Введено не число\n");
                                break;
                            }
                        }
                        break;
                    // умножение
                    case 5:
                        if (CNumbers.Count() == 0)
                        {
                            Console.Write("Нет комплексных чисел для умножения\n");
                        }
                        else
                        {
                            Console.Write($"Выберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1} в качестве множителя 1\n:");
                            int result1;
                            int result2;
                            try
                            {
                                // введено число
                                result1 = Convert.ToInt32(Console.ReadLine());
                                if (result1 >= 0 && result1 <= (CNumbers.Count() - 1))
                                {
                                    // число в промежутке
                                    Console.Write($"Выбрано CNumbers[{result1}] = ");
                                    CNumbers[result1].Write();
                                    Console.Write($"\nВыберите комплексное число в промежутке от 0 до {CNumbers.Count() - 1} в качестве множителя 2\n:");
                                    try
                                    {
                                        result2 = Convert.ToInt32(Console.ReadLine());
                                        if (result2 >= 0 && result2 <= (CNumbers.Count() - 1))
                                        {
                                            // число в промежутке
                                            Console.Write($"Выбрано CNumbers[{result2}] = ");
                                            CNumbers[result2].Write();
                                            Complex CMul = new Complex().Multi(CNumbers[result1], CNumbers[result2]);
                                            Console.Write($"\nРезультат произведения CNumbers[{result1}] * CNumbers[{result2}] = ");
                                            CMul.Write();
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            // число не в промежутке
                                            Console.Write("Число не в промежутке\n");
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Write("Введено не число\n");
                                        break;
                                    }
                                }
                                else
                                {
                                    // число не в промежутке
                                    Console.Write("Число не в промежутке\n");
                                    break;
                                }
                            }
                            catch
                            {
                                // введено не число
                                Console.Write("Введено не число\n");
                                break;
                            }
                        }
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
