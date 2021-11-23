using System;

namespace app7._2
{
    public class Platypus : Animal
    {
        public Platypus()
        {
            // platypus constructor
        }
        ~Platypus()
        {
            // platypus destructor
        }
        public override void Print()
        {
            Console.Write("Platypus print");
        }
        public override bool IsEgg()
        {
            return true;
        }
    }
}
