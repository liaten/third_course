using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._1
{
    public class Horse
    {
        public void Gallop() { Console.Write("Gallopping...\n"); }
        public virtual void Fly() { Console.Write("Horses can't fly!!\n"); }
        private int its_age;
    }
}
