using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4._0
{
    class Counter
    {
        private int its_value;
        public Counter()
        {
            this.its_value = 0;
        }
        ~Counter()
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
        public void increment()
        {
            ++this.its_value;
        }
        public static Counter operator ++(Counter i)
        {
            i.its_value++;
            return i;
        }
    }

}
