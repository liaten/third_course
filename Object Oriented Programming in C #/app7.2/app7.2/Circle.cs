using System;

namespace app7._2
{
    public class Circle : Shape
    {
        private float its_radius;
        public Circle(float Radius)
        {
            this.its_radius = Radius;
        }
        public override float Perimeter()
        {
            return (float)(2 * Math.PI * its_radius);
        }
        public override float Area()
        {
            return (float)(Math.PI * its_radius * its_radius);
        }
        public override void Print()
        {
            Console.Write("Circle print\n");
        }
    }
}
