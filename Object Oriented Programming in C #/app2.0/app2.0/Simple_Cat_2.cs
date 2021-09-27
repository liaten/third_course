using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._0
{
    class Simple_Cat_2
    {
        private double its_age;
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
        public double Get_Age()
        {
            return this.its_age;
        }
        public int Get_Years()
        {
            return this.its_years;
        }
        public int Get_Months()
        {
            return this.its_months;
        }
        public void Set_Age(double age)
        {
            this.its_age = age;
            this.its_years = (int) age;
            double months_age = age * 12;
            this.its_months = (int)(months_age - this.its_years * 12);
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
