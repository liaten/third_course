using System.Text.RegularExpressions;

namespace app7._5._1
{
    public class Program
    {
        public static void Main()
        {
            /* Создайте класс HugeInteger, который использует массив
                из 40 элементов для хранения целых чисел вплоть до очень больших
                целых, содержащих до 40 цифр. Создайте функции элементы для
                ввода, вывода, сложения и вычитания этих чисел. Создайте функции
                элементы для сравнения этих чисел (для реализации операций =,
                <>, <, <=, >, >=). Эти функции-предикаты должны возвращать
                значения Истина (1) или Ложь (0) после выполнения операции
                сравнения. Создайте предикатную функцию isZero (=0). На основе
                упомянутых функций создайте функции для умножения и деления
                таких чисел.
            */
            byte answer = 1;
            List<HugeInteger> list = new List<HugeInteger>();
            while (answer != 0)
            {
                Console.Write("0 - выйти;" +
                    "\n1 - создать длинное целое число;" +
                    "\n2 - посмотреть все числа;" +
                    "\n3 - операции с числами.\n: ");
                try
                {
                    answer = Convert.ToByte(Console.ReadLine());
                    if (answer > 3)
                    {
                        Console.WriteLine("Введено значение больше 3");
                    }
                    else
                    {
                        switch (answer)
                        {
                            case 0:
                                Environment.Exit(0);
                                break;
                            case 1:
                                Console.Write("Введите длинное целое число: ");
                                string hugeinteger = "";
                                hugeinteger += Console.ReadLine();
                                if (hugeinteger == "")
                                {
                                    Console.WriteLine("Значение не введено");
                                }
                                else if (Regex.IsMatch(hugeinteger, @"\D", RegexOptions.IgnoreCase))
                                /* \D : соответствует любому символу, не являющемуся десятичной цифрой */
                                {
                                    Console.WriteLine("При вводе присутствовали нечисловые символы");
                                }
                                else if (hugeinteger.Length > 40)
                                {
                                    Console.Write("Слишком длинное число\n");
                                }
                                else
                                {
                                    HugeInteger newhi = new HugeInteger(hugeinteger);
                                    list.Add(newhi);
                                    Console.WriteLine($"Успешно создано новое большое целое число №{list.Count()}");
                                    newhi.Print();
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                for (int i = 0; i < list.Count(); i++)
                                {
                                    Console.Write($"{i + 1}:");
                                    list[i].Print();
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                Console.Write("1 - арифметические операции" +
                                    "\n2 - операции сравнения\n:");
                                byte answer2 = 0;
                                answer2 = Convert.ToByte(Console.ReadLine());
                                if (answer2 > 2 || answer2 < 1)
                                {
                                    Console.WriteLine("Введено значение не в пределах [1;2]");
                                }
                                else
                                {
                                    switch (answer2)
                                    {
                                        case 1:
                                            Console.Write("1 - сложение" +
                                                "\n2 - вычитание" +
                                                "\n3 - умножение" +
                                                "\n4 - деление\n:");
                                            byte answer2_1 = 0;
                                            answer2_1 = Convert.ToByte(Console.ReadLine());
                                            if (answer2_1 > 4 || answer2_1 < 1)
                                            {
                                                Console.WriteLine("Введено значение не в пределах [1;4]");
                                            }
                                            else
                                            {
                                                switch (answer2_1)
                                                {
                                                    case 1:
                                                        Console.Write("Выберите первое слагаемое: ");
                                                        byte sum1 = 0;
                                                        sum1 = Convert.ToByte(Console.ReadLine());
                                                        if (sum1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.Write($"Первое слагаемое - число №{sum1} = {list[sum1 - 1].Get()}");
                                                            Console.Write("\nВыберите второе слагаемое: ");
                                                            byte sum2 = 0;
                                                            sum2 = Convert.ToByte(Console.ReadLine());
                                                            if (sum2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                Console.Write($"Второе слагаемое - число №{sum2} = {list[sum2 - 1].Get()}");
                                                                HugeInteger sum = list[sum1 - 1] + list[sum2 - 1];
                                                                Console.WriteLine($"\nСумма слагаемых №{sum1} и №{sum2} = {sum.Get()}");
                                                            }
                                                        }
                                                        break;
                                                    case 2:
                                                        Console.Write("Выберите уменьшаемое: ");
                                                        byte dif1 = 0;
                                                        dif1 = Convert.ToByte(Console.ReadLine());
                                                        if (dif1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.Write($"Уменьшаемое - число №{dif1} = {list[dif1 - 1].Get()}");
                                                            Console.Write("\nВыберите вычитаемое: ");
                                                            byte dif2 = 0;
                                                            dif2 = Convert.ToByte(Console.ReadLine());
                                                            if (dif2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                Console.Write($"Вычитаемое - число №{dif2} = {list[dif2 - 1].Get()}");
                                                                HugeInteger dif = list[dif1 - 1] - list[dif2 - 1];
                                                                Console.WriteLine($"\nРазность чисел №{dif1} и №{dif2} = {dif.Get()}");
                                                            }
                                                        }
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Данная функция пока что не реализована");
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Данная функция пока что не реализована");
                                                        break;
                                                }
                                            }
                                            break;
                                        case 2:
                                            Console.Write("1 - число 1 > числа 2" +
                                                "\n2 - число 1 < числа 2" +
                                                "\n3 - найти равенство двух чисел" +
                                                "\n4 - найти неравенство двух чисел" +
                                                "\n5 - найти равенство нулю" +
                                                "\n6 - Число 1 >= числа 2" +
                                                "\n7 - Число 1 <= числа 2\n:");
                                            byte answer2_2 = 0;
                                            answer2_2 = Convert.ToByte(Console.ReadLine());
                                            if (answer2_2 > 7 || answer2_2 < 1)
                                            {
                                                Console.WriteLine("Введено значение не в пределах [1;7]");
                                            }
                                            else
                                            {
                                                switch (answer2_2)
                                                {
                                                    case 1:
                                                        Console.Write("Выберите первое число для проверки: ");
                                                        byte sr1_1 = 0;
                                                        sr1_1 = Convert.ToByte(Console.ReadLine());
                                                        if (sr1_1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Выбрано число №{sr1_1} = {list[sr1_1-1].Get()}");
                                                            Console.Write("Выберите второе число для проверки: ");
                                                            byte sr1_2 = 0;
                                                            sr1_2 = Convert.ToByte(Console.ReadLine());
                                                            if (sr1_2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Выбрано число №{sr1_2} = {list[sr1_2-1].Get()}");
                                                                if (list[sr1_1-1] > list[sr1_2-1])
                                                                {
                                                                    Console.WriteLine($"Число №{sr1_1} > числа №{sr1_2}");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Число №{sr1_1} не > числа №{sr1_2}");
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 2:
                                                        Console.Write("Выберите первое число для проверки: ");
                                                        byte sr2_1 = 0;
                                                        sr2_1 = Convert.ToByte(Console.ReadLine());
                                                        if (sr2_1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Выбрано число №{sr2_1} = {list[sr2_1-1].Get()}");
                                                            Console.Write("Выберите второе число для проверки: ");
                                                            byte sr2_2 = 0;
                                                            sr2_2 = Convert.ToByte(Console.ReadLine());
                                                            if (sr2_2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                if (list[sr2_1 - 1] > list[sr2_2-1])
                                                                {
                                                                    Console.WriteLine($"Число №{sr2_1} < числа №{sr2_2}");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Выбрано число №{sr2_2} = {list[sr2_2 - 1].Get()}");
                                                                    Console.WriteLine($"Число №{sr2_1} не < числа №{sr2_2}");
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 3:
                                                        Console.Write("Выберите первое число для проверки равенства: ");
                                                        byte sr3_1 = 0;
                                                        sr3_1 = Convert.ToByte(Console.ReadLine());
                                                        if (sr3_1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Выбрано число №{sr3_1} = {list[sr3_1 - 1].Get()}");
                                                            Console.Write("Выберите второе число для проверки равенства: ");
                                                            byte sr3_2 = 0;
                                                            sr3_2 = Convert.ToByte(Console.ReadLine());
                                                            if (sr3_2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Выбрано число №{sr3_2} = {list[sr3_2 - 1].Get()}");
                                                                if (list[sr3_1 - 1] == list[sr3_2 - 1])
                                                                {
                                                                    Console.WriteLine($"Число №{sr3_1} = числу №{sr3_2}");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Число №{sr3_1} <> числу №{sr3_2}");
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 4:
                                                        Console.Write("Выберите первое число для проверки неравенства: ");
                                                        byte sr4_1 = 0;
                                                        sr4_1 = Convert.ToByte(Console.ReadLine());
                                                        if (sr4_1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Выбрано число №{sr4_1} = {list[sr4_1 - 1].Get()}");
                                                            Console.Write("Выберите второе число для проверки неравенства: ");
                                                            byte sr4_2 = 0;
                                                            sr4_2 = Convert.ToByte(Console.ReadLine());
                                                            if (sr4_2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Выбрано число №{sr4_2} = {list[sr4_2 - 1].Get()}");
                                                                if (list[sr4_1 - 1] != list[sr4_2 - 1])
                                                                {
                                                                    Console.WriteLine($"Число №{sr4_1} <> числу №{sr4_2}");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Число №{sr4_1} = числу №{sr4_2}");
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 5:
                                                        Console.Write("Выберите число для проверки равенства 0: ");
                                                        byte sr5_1 = 0;
                                                        sr5_1 = Convert.ToByte(Console.ReadLine());
                                                        if (sr5_1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Выбрано число №{sr5_1} = {list[sr5_1 - 1].Get()}");
                                                            if (list[sr5_1 - 1].isZero())
                                                            {
                                                                Console.WriteLine($"Выбранное число №{sr5_1} равно 0");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Выбранное число №{sr5_1} не равно 0");
                                                            }
                                                        }
                                                        break;
                                                    case 6:
                                                        Console.Write("Выберите первое число для проверки: ");
                                                        byte sr6_1 = 0;
                                                        sr6_1 = Convert.ToByte(Console.ReadLine());
                                                        if (sr6_1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Выбрано число №{sr6_1} = {list[sr6_1 - 1].Get()}");
                                                            Console.Write("Выберите второе число для проверки: ");
                                                            byte sr6_2 = 0;
                                                            sr6_2 = Convert.ToByte(Console.ReadLine());
                                                            if (sr6_2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Выбрано число №{sr6_2} = {list[sr6_2 - 1].Get()}");
                                                                if (list[sr6_1 - 1] >= list[sr6_2 - 1])
                                                                {
                                                                    Console.WriteLine($"Число №{sr6_1} >= числа №{sr6_2}");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Число №{sr6_1} < числа №{sr6_2}");
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 7:
                                                        Console.Write("Выберите первое число для проверки: ");
                                                        byte sr7_1 = 0;
                                                        sr7_1 = Convert.ToByte(Console.ReadLine());
                                                        if (sr7_1 > list.Count())
                                                        {
                                                            Console.WriteLine("Такого числа нет в списке");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Выбрано число №{sr7_1} = {list[sr7_1 - 1].Get()}");
                                                            Console.Write("Выберите второе число для проверки: ");
                                                            byte sr7_2 = 0;
                                                            sr7_2 = Convert.ToByte(Console.ReadLine());
                                                            if (sr7_2 > list.Count())
                                                            {
                                                                Console.WriteLine("Такого числа нет в списке");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Выбрано число №{sr7_2} = {list[sr7_2 - 1].Get()}");
                                                                if (list[sr7_1 - 1] <= list[sr7_2 - 1])
                                                                {
                                                                    Console.WriteLine($"Число №{sr7_1} <= числа №{sr7_2}");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Число №{sr7_1} > числа №{sr7_2}");
                                                                }
                                                            }
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                }
                catch (FormatException Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
                catch (OverflowException Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
            }
        }
    }
}