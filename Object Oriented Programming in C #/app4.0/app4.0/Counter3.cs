using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4._0
{
    class Counter3
    {
        private int its_value;
        public Counter3()
        {
            this.its_value = 0;
        }
        ~Counter3()
        {
            //
        }
        public Counter3(int initial_value)
        {
            this.its_value = initial_value;
        }
        public int Get_Its_Value()
        {
            return this.its_value;
        }
        public void Set_Its_Value(int x)
        {
            this.its_value = x;
        }
        public static Counter3 operator +(Counter3 i, Counter3 rhs)
        {
            return new Counter3
            {
                its_value = i.its_value + rhs.Get_Its_Value()
            };
        }
    }
}
