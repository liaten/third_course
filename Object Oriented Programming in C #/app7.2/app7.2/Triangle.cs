using System;

namespace app7._2
{
    public class Triangle : Shape
    {
        private float its_side_1, its_side_2, its_side_3;
        public Triangle(float s1, float s2, float s3)
        {
            this.its_side_1 = s1;
            this.its_side_2 = s2;
            this.its_side_3 = s3;
        }
        public override float Perimeter()
        {
            return (float)(its_side_1+its_side_2+its_side_3);
        }
        public override float Area()
        {
            float sp = this.Perimeter() / 2;
            return (float)
                (
                    Math.Sqrt
                    (
                        sp*(sp-its_side_1)*(sp-its_side_2)*(sp-its_side_3)
                    )
                );
        }
        public override void Print()
        {
            Console.Write("Rectangle print\n");
        }
    }
}
