using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._4
{
    public class Circle : Shape
    {
        private int its_radius;
        public Circle(int Radius)
        {
            this.its_radius = Radius;
        }
        ~Circle() { }
        public override long Get_Area() { return (long)(3.1415926 * its_radius * its_radius); }
        public override long Get_Perim() { return (long)(2 * 3.1415926 * its_radius); }
        public override void Draw()
        {
            Console.Write("Circle draw here\n");
        }
    }
}
