using System;

namespace app6._0
{
    class Program
    {
        const int Number_Of_Horses = 5;
        static void Main(string[] args)
        {
            Horse[] Ranch = new Horse[Number_Of_Horses];
            Horse P_Horse = new Horse();
            int choice, i;
            for (i = 0; i < Number_Of_Horses; i++)
            {
                Console.WriteLine("(1) - horse (2) - pegas");
                choice = Convert.ToInt32(Console.ReadLine());
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
                // delete ranch[i];
            }
        }
    }
}
