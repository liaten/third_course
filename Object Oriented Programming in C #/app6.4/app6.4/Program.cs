using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool fquit = false;
            Shape sp = new Shape();
            while (!fquit)
            {
                Console.Write("(1) - circle (2) - rectangle (3) - square (0) - quit: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        fquit = true;
                        break;
                    case 1:
                        sp = new Circle(4);
                        break;
                    case 2:
                        sp = new Rectangle(4, 6);
                        break;
                    case 3:
                        sp = new Square(5);
                        break;
                    default:
                        Console.Write("enter a number between 0 and 3\n");
                        break;
                }
                if (!fquit)
                {
                    sp.Draw();
                }
                sp = new Shape();
                Console.WriteLine();
            }
            sp = new Rectangle(5, 4);
            sp.Draw();
            Console.ReadKey();
        }
    }
}
