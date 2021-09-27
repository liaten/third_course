using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._0
{
    class Horse3
    {
        private int its_age;
        public Horse3()
        {
            Console.WriteLine("Horse constructor");
        }
        ~Horse3()
        {
            Console.WriteLine("Horse destructor");
        }
    }
}
