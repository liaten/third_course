using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3._0
{
    class Simple_Cat_2
    {
        public Simple_Cat_2()
        {
            Console.WriteLine("Simple cat constructor");
        }
        public Simple_Cat_2(Simple_Cat_2 SC_2)
        {
            Console.WriteLine("Simple cat copy constructor");
        }
        ~Simple_Cat_2() 
        {
            Console.WriteLine("Destructor");
        }
    }
}
