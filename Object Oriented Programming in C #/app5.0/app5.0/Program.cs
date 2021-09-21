using System;

namespace app5._0
{
    enum breed
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
        private breed its_breed;
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}