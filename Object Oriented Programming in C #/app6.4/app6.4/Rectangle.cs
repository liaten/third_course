using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._4
{
    public class Rectangle : Shape
    {
        private int its_width;
        private int its_lenght;
        public Rectangle(int len, int width)
        {
            this.its_lenght = len;
            this.its_width = width;
        }
        ~Rectangle() { }
        public override long Get_Area() { return its_lenght * its_width; }
        public override long Get_Perim() { return 2 * (its_lenght + its_width); }
        public virtual int Get_Lenght() { return its_lenght; }
        public virtual int Get_Width() { return its_width; }
        public override void Draw()
        {
            Console.Write("rect\n");
            for (int i = 1; i < its_lenght; i++)
            {
                for (int j = 1; j < its_width; j++)
                {
                    Console.Write("x");
                }
                Console.Write("\n");
            }
        }
    }
}
