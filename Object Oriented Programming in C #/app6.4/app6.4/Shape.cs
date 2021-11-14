using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._4
{
    public class Shape
    {
        public Shape() { }
        ~Shape() { }
        public virtual long Get_Area() { return -1; }
        public virtual long Get_Perim() { return -1; }
        public virtual void Draw() { }
    }
}
