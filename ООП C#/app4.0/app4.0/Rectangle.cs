using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4._0
{
    class Rectangle
    {
        private int its_width;
        private int its_height;

        public Rectangle(int width, int height)
        {
            this.its_height = height;
            this.its_width = width;
        }
        ~Rectangle()
        {
            ;
        }
        public void Draw()
        {
            Draw(its_width, its_height);
        }
        public void Draw(int w, int h)
        {
            for(int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
