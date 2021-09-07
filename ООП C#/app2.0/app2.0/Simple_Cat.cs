using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._0
{
    class Simple_Cat
    {
        private int its_age;
        public Simple_Cat()     // конструктор
        {
            this.its_age = 2;
        }
        ~Simple_Cat()   // деструктор
        {
            ;
        }
        public int Get_Age()
        {
            return this.its_age;
        }
        public void Set_Age(int age)
        {
            this.its_age = age;
        }
    }
}
