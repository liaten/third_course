using System;

namespace app6._3
{
    public class Bird
    {
        public Bird() { Console.Write("Bird constructor\n"); }

        public Bird(Pegasus peg)
        {
            is_pegasus = true;
            Peg = peg;
        }
        ~Bird() { Console.Write("Bird destructor\n"); }
        public virtual void Chirp()
        {
            if (is_pegasus)
            {
                Peg.Whinny();
            }
            else
            {
                Console.Write("Chirp...\n");
            }
        }
        public virtual void Fly() { Console.Write("I can fly!\n"); }
        private int its_weight;
        private bool is_pegasus = false;

        public Pegasus Peg { get; set; }

        public static implicit operator Bird(Pegasus peg)
        {
            return new(peg);
        }
    }
}
