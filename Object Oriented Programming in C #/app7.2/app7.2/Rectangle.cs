using System;

namespace app7._2
{
    public class Rectangle : Shape
    {
        private float its_width;
        private float its_height;
        public Rectangle(float Width, float Height)
        {
            this.its_width = Width;
            this.its_height = Height;
        }
        public override float Perimeter()
        {
            return (float)(2 * (this.its_height + this.its_width));
        }
        public override float Area()
        {
            return (float)(this.its_width * this.its_height);
        }
        public override void Print()
        {
            Console.Write("Rectangle print\n");
        }
    }
}
