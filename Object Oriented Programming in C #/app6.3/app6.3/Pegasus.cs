using System;

namespace app6._3
{
    public class Pegasus
    {
        public void Whinny() { Console.Write("Whinny...\n"); }
        public void Fly() { Console.Write("I can fly!\n"); }
        public void Chirp() { Whinny(); }
        public Pegasus() { Console.Write("Pegasus constructor\n"); }
        ~Pegasus() { Console.Write("Pegasus destructor\n"); }
        private int its_weight;
        private int its_age;
    }
}
