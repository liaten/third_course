using System;

namespace app6._1
{

    class Program
    {
        const int Number_Of_Horses = 5;
        static void Main()
        {
            Console.WriteLine("Занятие 6.1");
            Horse[] Ranch = new Horse[Number_Of_Horses];
            Horse P_Horse;
            int choice, i;
            for (i = 0; i < Number_Of_Horses; i++)
            {
                Console.Write("(1) - horse  (2) - pegas\n");
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
                Ranch[i].Fly();
            }
            Console.ReadKey();
        }
    }
}
