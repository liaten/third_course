using System;
using System.Collections.Generic;

namespace app7._4
{
    public class Program
    {
        public static void Main()
        {
            bool quit = false;
            int answer;
            List<Date> DateList = new List<Date>();
            DateList.Add(new Date(13, 07, 2000));
            while (quit == false)
            {
                Console.Write($"\nДат в системе: {DateList.Count}");
                Console.Write("\n(1) - вывести текущую дату\n");
                Console.Write("(2) - создать новую переменную даты\n");
                Console.Write("(3) - добавить дни к дате\n");
                Console.Write("(0) - выйти\n:");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 0:
                            quit = true;
                            break;
                        case 1:
                            Date newdate = new Date();
                            Console.Write(newdate.Get_Date());
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Write("Введите год\n:");
                            int year;
                            try
                            {
                                year = Convert.ToInt32(Console.ReadLine());
                                if (year < 0)
                                {
                                    Console.Write("Неверный формат ввода");
                                    break;
                                }
                                Console.Write("Введите месяц\n:");
                                int month;
                                try
                                {
                                    month = Convert.ToInt32(Console.ReadLine());
                                    if (month > 12 || month < 1)
                                    {
                                        Console.Write("Неверный формат ввода");
                                        break;
                                    }
                                    Console.Write("Введите день\n:");
                                    int day;
                                    try
                                    {
                                        day = Convert.ToInt32(Console.ReadLine());
                                        Date buf = new Date();
                                        if (day > 0 && day <= buf.GetDaysByMonthYear(month, year))
                                        {
                                            buf = null;
                                            DateList.Add(new Date(day, month, year));
                                        }
                                        else
                                        {
                                            Console.Write("Неверный формат ввода");
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Write("Неверный формат ввода");
                                    }
                                }
                                catch
                                {
                                    Console.Write("Неверный формат ввода");
                                }
                            }
                            catch
                            {
                                Console.Write("Неверный формат ввода");
                            }
                            break;
                        case 3:
                            Console.Write("Выберите дату:\n(1) - текущая дата\n(2) - дата из системы\n:");
                            int result;
                            try
                            {
                                result = Convert.ToInt32(Console.ReadLine());
                                switch (result)
                                {
                                    case 1:
                                        // текущая дата
                                        Date incdate = new Date();
                                        break;
                                    case 2:
                                        // дата из системы
                                        if (DateList.Count == 0)
                                        {
                                            Console.Write("В системе нет дат для использования");
                                        }
                                        else
                                        {
                                            Console.Write($"Выберите ID даты в промежутке между 0 и {DateList.Count - 1}\n:");
                                            int resultid;
                                            try
                                            {
                                                resultid = Convert.ToInt32(Console.ReadLine());
                                                if (resultid >= 0 && resultid <= DateList.Count)
                                                {
                                                    Console.Write($"Выбрана дата DateList[{resultid}] : {DateList[resultid].Get_Date()}");
                                                    Console.Write("\nСколько дней прибавить?\n:");
                                                    int n;
                                                    try
                                                    {
                                                        n = Convert.ToInt32(Console.ReadLine());
                                                        DateList[resultid] += n;
                                                        Console.Write($"Результат: {DateList[resultid].Get_Date()}");
                                                    }
                                                    catch
                                                    {
                                                        Console.Write("Неверный формат ввода");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Write("Неверный формат ввода");
                                                }
                                            }
                                            catch
                                            {
                                                Console.Write("Неверный формат ввода");
                                            }
                                        }
                                        break;
                                    default:
                                        Console.Write("Неверный формат ввода");
                                        break;
                                }
                            }
                            catch
                            {
                                Console.Write("Неверный формат ввода");
                            }
                            break;
                        default:
                            Console.Write("Неверный формат ввода");
                            break;
                    }
                }
                catch
                {
                    //
                }
            }
        }
    }
}
