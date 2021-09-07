using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._0
{
    class Simple_Cat_2
    {
        private int its_age;
        private int its_weight;
        public Simple_Cat_2()
        {
            this.its_age = 2;
            this.its_weight = 5;
        }
        ~Simple_Cat_2()
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
        public int Get_Weight()
        {
            return this.its_weight;
        }
        public void Set_Weight(int weight)
        {
            this.its_weight = weight;
        }

    }
}
