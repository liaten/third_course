using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app5._1
{
    enum Breed
    {
        golden,
        cairn,
        dandie,
        shetland,
        doberman,
        lab
    }
    class Mammal
    {
        protected int its_age;
        protected int its_weight;
        public Mammal()
        {
            this.its_age = 2;
            this.its_weight = 5;
        }
        ~Mammal()
        {
        }
        public int Get_Age()
        {
            return this.its_age;
        }
        public void Set_Age(int age)
        {
            this.its_age = age;
        }
        public int Get_Weigt()
        {
            return this.its_weight;
        }
        public void Set_Weight(int weight)
        {
            this.its_weight = weight;
        }
        public void Speak()
        {
            Console.WriteLine("Mammal sound");
        }
        public void Sleep()
        {
            Console.WriteLine("Mammal sleep");
        }
    }
    class Dog : Mammal
    {
        private Breed its_breed;
        public Dog()
        {
            this.its_breed = Breed.golden;
        }
        public Dog(Breed br)
        {
            this.its_breed = br;
        }
        ~Dog()
        {
        }
        public Breed Get_Breed()
        {
            return this.its_breed;
        }
        public void Set_Breed(Breed br)
        {
            this.its_breed = br;
        }
        public void Wag_Tail()
        {
            Console.WriteLine("Tail wagging");
        }
        public void Beg_For_Food()
        {
            Console.WriteLine("Begging for food");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 5.1
            Dog Fido = new Dog();
            Fido.Speak();
            Fido.Wag_Tail();
            Console.WriteLine("Fido is " + Fido.Get_Age() + " years old.");
            // Задание 5.2
            // объявление с перегрузкой
            Dog Archie = new Dog(Breed.dandie);
            // демонстрация перегрузки
            Console.WriteLine("Archie's breed is " + Archie.Get_Breed());

            Console.Write("Press any key to close: ");
            Console.ReadKey();
        }
    }
}
