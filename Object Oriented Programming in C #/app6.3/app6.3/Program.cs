using System;

namespace app6._3
{
    enum Type
    {
        HORSE, PEGAS
    };
    class Program
    {
        const int num = 2;
        static void Main(string[] args)
        {
            Horse[] Ranch = new Horse[num];
            Bird[] Aviary = new Bird[num];
            Horse P_Horse;
            Bird P_Bird;
            int choice, i;
            for (i = 0; i < num; i++)
            {
                Console.Write("\n (1) -- horse (2) -- pegasus\n");
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
            for (i = 0; i < num; i++)
            {
                Console.Write("\n (1) -- bird (2) -- pegasus\n");
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 2)
                {
                    P_Bird = new Pegasus();
                }
                else
                {
                    P_Bird = new Bird();
                }
                Aviary[i] = P_Bird;
            }
            Console.WriteLine();
            for (i = 0; i < num; i++)
            {
                Console.Write($"\n ranch[{i}]: ");
                Ranch[i].Whinny();
            }
            for (i = 0; i < num; i++)
            {
                Console.Write($"\n aviary[{i}]: ");
                Aviary[i].Chirp();
                Aviary[i].Fly();
            }
            Console.ReadKey();
        }
    }
}
