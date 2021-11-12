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
        {
            new Rectangle(len, len);
        }

        public Square(int len, int width)
        {
            if (this.Get_Lenght() != this.Get_Width())
            {
                Console.Write("Not a square\n");
            }
        }
        ~Square() { }
        long Get_Perim() { return 4 * Get_Lenght(); }
    }
}
