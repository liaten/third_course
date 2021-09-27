using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._0
{
    class Pegasus3 : IPegasus
    {
        private int its_weight;
        private int its_age;
        public Pegasus3()
        {
            Console.WriteLine("Pegasus constructor");
        }
        ~Pegasus3()
        {
            Console.WriteLine("Pegasus destructor");
        }
    }
}
