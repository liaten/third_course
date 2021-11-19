using System;

namespace app7._4
{
    public class Date
    {
        private int its_year;
        private int its_month;
        private int its_day;
        public Date()
        {
            // Конструктор класса Дата

            // Задаёт значения текущего дня приватным переменным класса
            this.its_year = DateTime.Today.Year;
            this.its_month = DateTime.Today.Month;
            this.its_day = DateTime.Today.Day;
        }
        public Date(int day, int month, int year)
        {
            // Перегрузка конструктора класса Дата

            // Задаёт значения приватным переменным класса из аргументов
            this.its_year = year;
            this.its_month = month;
            this.its_day = day;
        }
        public static Date operator ++(Date old_date)
        {
            int new_day, new_month, new_year;
            new_day = old_date.its_day + 1;
            new_month = old_date.its_month;
            new_year = old_date.its_year;
            if (new_day == old_date.GetDaysByMonthYear())
            {
                new_day = 1;
                new_month = old_date.its_month + 1;
            }
            if (new_month == 13)
            {
                new_month = 1;
                new_year = old_date.its_year + 1;
            }
            return new Date
            {
                its_day = new_day,
                its_month = new_month,
                its_year = new_year
            };
        }
        public static Date operator --(Date old_date)
        {
            int new_day, new_month, new_year;
            new_day = old_date.its_day - 1;
            new_month = old_date.its_month;
            new_year = old_date.its_year;
            if (new_day == 0)
            {
                new_month = old_date.its_month - 1;
                if (new_month == 0)
                {
                    new_month = 12;
                    new_year = old_date.its_year - 1;
                }
                new_day = old_date.GetDaysByMonthYear(new_month, new_year);
            }
            return new Date
            {
                its_day = new_day,
                its_month = new_month,
                its_year = new_year
            };
        }
        public static Date operator +(Date old_date, int n)
        {
            int new_day, new_month, new_year;
            new_day = old_date.Get_Day();
            if ((new_day + n) < old_date.GetDaysByMonthYear())
            {
                new_day += n;
                n = 0;
                new_month = old_date.its_month;
                new_year = old_date.its_year;
            }
            else
            {
                n -= old_date.GetDaysByMonthYear() - new_day + 1;
                new_day = 1;
                new_month = old_date.its_month + 1;
                if (new_month == 13)
                {
                    new_month = 1;
                    new_year = old_date.its_year + 1;
                }
                else
                {
                    new_year = old_date.its_year;
                }
            }
            if (n != 0)
            {
                return new Date
                {
                    its_day = new_day,
                    its_month = new_month,
                    its_year = new_year
                } + n;
            }
            else
            {
                return new Date
                {
                    its_day = new_day,
                    its_month = new_month,
                    its_year = new_year
                };
            }
        }
        ~Date()
        {
            // Деструктор класса Дата
        }
        // возвращает количество дней в месяце и годе этого класса
        public int GetDaysByMonthYear()
        {
            if (this.its_month > 7)
            {
                // проверка второй половины года
                // 8 -> 31, 9 -30, 10 -> 31, 11 -> 30, 12 -> 31
                return 31 - (this.its_month % 2);
            }
            else
            {
                /* проверка первой половины года
                * 1 -> 31, 2 -> 28/29, 3 -> 31, 4 -> 30,
                * 5 -> 31, 6 -> 30, 7 -> 31
                */
                if (this.its_month == 2)
                {
                    // 28 дней в обычном году и 29 дней в високосные годы
                    if (this.its_year % 4 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else
                {
                    return 30 + (this.its_month % 2);
                }
            }
        }
        // возвращает количество дней в определенном месяце определенного года
        public int GetDaysByMonthYear(int month, int year)
        {
            if (month > 7)
            {
                // проверка второй половины года
                // 8 -> 31, 9 -30, 10 -> 31, 11 -> 30, 12 -> 31
                return 31 - (month % 2);
            }
            else
            {
                /* проверка первой половины года
                * 1 -> 31, 2 -> 28/29, 3 -> 31, 4 -> 30,
                * 5 -> 31, 6 -> 30, 7 -> 31
                */
                if (month == 2)
                {
                    // 28 дней в обычном году и 29 дней в високосные годы
                    if (year % 4 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else
                {
                    return 30 + (month % 2);
                }
            }
        }
        public int Get_Day()
        {
            return this.its_day;
        }
        public int Get_Month()
        {
            return this.its_month;
        }
        public int Get_Year()
        {
            return this.its_year;
        }
        public string Get_Date()
        {
            return this.its_day + "." + this.its_month + "." + this.its_year;
        }
        public void Set_Date(int day, int month, int year)
        {
            this.its_day = day;
            this.its_month = month;
            this.its_year = year;
        }
    }
}
