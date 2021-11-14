using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6._2
{
    enum Type
    {
        HORSE, PEGAS
    }
    class Program
    {
        const int Number_Of_Horses = 5;
        static void Main(string[] args)
        {
            Horse[] Ranch = new Horse[Number_Of_Horses];
            Horse P_Horse;
            int choice, i;
            for (i = 0; i < Number_Of_Horses; i++)
            {
                Console.Write("(1) - Horse  (2) - pegas\n");
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 2)
                {
                    P_Horse = new Pegasus();
                }
                else
                {
                    P_Horse = new Horse();
                }
                Ranch[i] = P_Horse;
            }
            for (i = 0; i < Number_Of_Horses; i++)
            {
                Pegasus P_Peg = Ranch[i] as Pegasus;
                if (P_Peg != null)
                {
                    P_Peg.Fly();
                }
                else
                {
                    Console.Write("Just a horse\n");
                }
            }
            Console.ReadKey();
        }
    }
}
