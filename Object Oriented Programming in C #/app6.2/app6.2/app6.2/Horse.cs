using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._2
{
    public class Horse
    {
        public virtual void Gallop()
        {
            Console.Write("Gallopping...\n");
        }
        private int its_age;
        ~Horse() { }
    }
}
