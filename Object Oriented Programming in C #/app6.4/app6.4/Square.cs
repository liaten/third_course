using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._4
{
    public class Square : Rectangle
    {
        public Square(int len)
            : base(len, len) { }

        public Square(int len, int width)
            : base(len, width)
        {
            if (Get_Lenght() != Get_Width())
            {
                Console.Write("not a square\n");
            }
        }
        ~Square() { }
        override public long Get_Perim() { return 4 * Get_Lenght(); }
    }
}
