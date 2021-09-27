using System;

namespace app6._0
{
    enum type
    {
        HORSE,
        PEGAS
    }
    class Program
    {
        const int Number_Of_Horses = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6.1:");
            Horse[] Ranch = new Horse[Number_Of_Horses];
            Horse P_Horse = new();
            int choice, i;
            for (i = 0; i < Number_Of_Horses; i++)
            {
                Console.WriteLine("(1) - horse (2) - pegas");
                choice = (int)Convert.ToInt32(Console.ReadLine());
                if(choice == 2)
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

            Console.WriteLine("Задание 6.2:");
            Horse2[] Ranch2 = new Horse2[Number_Of_Horses];
            Horse2 P_Horse2 = new();
            for (i = 0; i < Number_Of_Horses; i++)
            {
                Console.WriteLine("(1) - horse (2) - pegas");
                choice = (int)Convert.ToInt32(Console.ReadLine());
                if (choice == 2)
                {
                    P_Horse2 = new Pegasus2();
                }
                else
                {
                    P_Horse2 = new Horse2();
                }
                Ranch2[i] = P_Horse2;
            }
            for (i = 0; i < Number_Of_Horses; i++)
            {

                Pegasus2 P_Peg = new();
                P_Peg = (Pegasus2)(Ranch2[i] as Pegasus2);
                if(P_Peg is Pegasus2)
                {
                    P_Peg.Fly();
                }
                else
                {
                    Console.WriteLine("Just a horse");
                }
            }
            
            Console.WriteLine("Задание 6.3:");
            const int num = 2;
            Horse3[] Ranch3 = new Horse3[num];
            Bird[] Aviary3 = new Bird[num];
            Horse3 P_Horse3 = new();
            Bird P_Bird3 = new();
            Pegasus3 P_Peg3 = new();
            for (i = 0; i < num; i++)
            {
                Console.Write("\n (1) -- horse (2) -- pegasus\n");
                choice = (int)Convert.ToInt32(Console.ReadLine());
                if(choice == 2)
                {
                    P_Horse3 = Pegasus3;
                }
                else
                {
                    P_Horse3 = Horse3;
                }
                Ranch3[i] = P_Horse3;
            }

            for (i = 0; i < num; i++)
            {
                Console.Write("\n (1) -- bird (2) -- pegasus\n");
                choice = (int)Convert.ToInt32(Console.ReadLine());
                if (choice == 2)
                {
                    P_Bird3 = new Pegasus3();
                }
                else
                {
                    P_Bird3 = new Bird();
                }
                Aviary3[i] = P_Bird3;
            }
            
        }
    }
}