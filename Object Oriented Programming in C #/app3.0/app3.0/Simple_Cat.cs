using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3._0
{
    class Simple_Cat
    {
        private int its_age;
        private int its_weight;
        public Simple_Cat(int age, int weight)
        {
            this.its_age = age;
            this.its_weight = weight;
        }
        ~Simple_Cat()
        {
            ;
        }
        public int Get_Age() { return this.its_age; }
        public void Set_Age(int age) { this.its_age = age; }
        public int Get_Weight() { return this.its_weight; }
        public void Set_Weight(int weight) { this.its_weight = weight; }
    }
}
