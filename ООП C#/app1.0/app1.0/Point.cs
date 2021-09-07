using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1._0
{
    class Point     // holds x,y coordinates
    {
        public void SetX (int X)
        {
            itsX = X;
        }
        public void SetY (int Y)
        {
            itsY = Y;
        }
        public int GetX()
        {
            return itsX;
        }
        public int GetY()
        {
            return itsY;
        }
        private int itsX;
        private int itsY;
    }
}   // end of Point class declaration
