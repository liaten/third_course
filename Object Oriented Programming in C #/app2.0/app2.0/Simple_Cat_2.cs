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
        private int its_years;
        private int its_months;
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
        public void Set_Age(double age)
        {
            this.its_age = (int) age;
            this.its_years = (int) age;
            this.its_months = (int) ((age - (int)age) * 10 / 12);
        }
        public void Set_Age(int years, int months)
        {
            this.its_years = years;
            this.its_months = months;
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
