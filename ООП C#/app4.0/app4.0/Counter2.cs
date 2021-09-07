using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4._0
{
    class Counter2
    {
        private int its_value;
        public Counter2()
        {
            this.its_value = 0;
        }
        ~Counter2()
        {
            ;
        }
        public int Get_Its_Value()
        {
            return this.its_value;
        }
        public void Set_Its_Value(int x)
        {
            this.its_value = x;
        }
        public static Counter2 operator ++(Counter2 i)
        {
            return new Counter2
            {
                its_value = i.its_value + 1
            };
        }

        // префиксный и постфиксный операторы определяются одной функцией
    }
}
