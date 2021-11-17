using System;

namespace app6._3
{
    public class Horse
    {
        public Horse() { Console.Write("Horse constructor\n"); }

        public Horse(Pegasus peg)
        {
        }

        ~Horse() { Console.Write("Horse destructor\n"); }
        public virtual void Whinny() { Console.Write("Whinny...\n"); }
        private int its_age;

        public static implicit operator Horse(Pegasus peg)
        {
            return new(peg);
        }
    }
}
