using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1._0
{
    class Cat
    {
        private int its_age;     //возраст
        public int its_weight;   //вес
        public Cat(int initial_age)     //конструктор
        {
            this.its_age = initial_age;     //ссылка на текущий элемент класса
        }
        public void Meow()  //метод
        {
            Console.WriteLine("Meow!");
        }
        public int Get_Age()
        {
            return its_age;
        }
        public void Set_Age(int age)
        {
            its_age = age;
        }
    }
}
