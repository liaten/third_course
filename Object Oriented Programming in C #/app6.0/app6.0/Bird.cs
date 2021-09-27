using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._0
{
    class Bird : IBird
    {
        private int its_weight;
        public Bird()
        {
            Console.WriteLine("Bird constructor");
        }
        ~Bird()
        {
            Console.WriteLine("Bird destructor");
        }
    }
}
