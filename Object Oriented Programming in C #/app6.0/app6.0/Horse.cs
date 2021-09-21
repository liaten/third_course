using System;
using System.Collections.Generic;
using System.Text;

namespace app6._0
{
    class Horse
    {
        private int its_age;
        public void Gallop()
        {
            Console.WriteLine("Gallopping...");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Horses can't fly.");
        }
    }
}
