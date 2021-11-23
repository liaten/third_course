using System;

namespace app7._2
{
    public class Dog : Animal
    {
        public Dog()
        {
            // dog constructor
        }
        ~Dog()
        {
            // dog destructor
        }
        public override void Print()
        {
            Console.Write("Dog print");
        }
        public override bool IsEgg()
        {
            return false;
        }
    }
}
