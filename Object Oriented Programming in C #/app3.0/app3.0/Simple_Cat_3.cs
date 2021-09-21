using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3._0
{
    class Simple_Cat_3
    {
        private int its_age;
        public Simple_Cat_3()
        {
            Console.WriteLine("Simple cat constructor");
            this.its_age = 1;
        }
        public Simple_Cat_3(Simple_Cat_3 SC_3)
        {
            Console.WriteLine("Simple cat copy constructor");
        }
        ~Simple_Cat_3()
        {
            Console.WriteLine("Destructor");
        }
        public int Get_Age() {return this.its_age;}
        public void Set_Age(int age) { this.its_age = age; }
}
}
