using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1._0
{
    class Rectangle
    {
        private Point itsUpperLeft = new Point();
        private Point itsUpperRight = new Point();
        private Point itsLowerLeft = new Point();
        private Point itsLowerRight = new Point();
        private int itsTop;
        private int itsLeft;
        private int itsBottom;
        private int itsRight;
        public Rectangle(int Top, int Left, int Bottom, int Right)
        {
            this.itsTop = Top;
            this.itsLeft = Left;
            this.itsBottom = Bottom;
            this.itsRight = Right;

            this.itsUpperLeft.SetX(Left);
            this.itsUpperLeft.SetY(Top);

            this.itsUpperRight.SetX(Right);
            this.itsUpperRight.SetY(Top);
            this.itsLowerLeft.SetX(Left);
            this.itsLowerLeft.SetY(Bottom);

            this.itsLowerRight.SetX(Right);
            this.itsLowerRight.SetY(Bottom);
        }
        public int GetArea()
        {
            int Width = this.itsRight - this.itsLeft;
            int Height = this.itsTop - this.itsBottom;
            return (Width * Height);
        }
        public int GetTop()
        {
            return itsTop;
        }
        public int Getleft()
        {
            return itsLeft;
        }
        public int GetBottom()
        {
            return itsBottom;
        }
        public int GetRight()
        {
            return itsRight;
        }
        public Point GetUpperLeft()
        {
            return itsUpperLeft;
        }
        public Point GetUpperRight()
        {
            return itsUpperRight;
        }
        public Point GetLowerLeft()
        {
            return itsLowerLeft;
        }
        public Point GetLowerRight()
        {
            return itsLowerRight;
        }
        public void SetUpperLeft(Point Location)
        {
            this.itsUpperLeft = Location;
        }
        public void SetLowerLeft(Point Location)
        {
            this.itsLowerLeft = Location;
        }
        public void SetUpperRight(Point Location)
        {
            this.itsUpperRight = Location;
        }
        public void SetLowerRight(Point Location)
        {
            this.itsLowerRight = Location;
        }
        public void SetTop(int Top)
        {
            this.itsTop = Top;
        }
        public void SetLeft(int Left)
        {
            this.itsLeft = Left;
        }
        public void SetRight(int Right)
        {
            this.itsRight = Right;
        }
        public void SetBottom(int Bottom)
        {
            this.itsBottom = Bottom;
        }
        
    }
}
