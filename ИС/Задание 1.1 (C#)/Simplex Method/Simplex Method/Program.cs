using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplex_Method
{
    class Program
    {
        static void Main(string[] args)
        {
        // https://vscode.ru/wp-content/uploads/2015/11/test-task-simplex.png
                               //D>= x1 + x2
            double[,] table = { {25, -3,  5},   //-3x1 + 5x2 <= 25
                                {30, -2,  5},   //-2x1 + 5x2 <= 30
                                {10,  1,  0},   //  x1       <= 10
                                { 6,  3, -8},   // 3x1 - 8x2 <= 6
                                { 0, -6, -5} }; // 6x1 + 5x2 -> max
                                //x1, x2 >= 0

            double[] result = new double[2];
            double[,] table_result;
            Simplex S = new Simplex(table);
            table_result = S.Calculate(result);

            
            Console.WriteLine("Решенная симплекс-таблица:");
            for (int i = 0; i < table_result.GetLength(0); i++)
            {
                for (int j = 0; j < table_result.GetLength(1); j++)
                    Console.Write(table_result[i, j] + " ");
                Console.WriteLine();
            }
            

            Console.WriteLine();
            Console.WriteLine("Решение:");
            Console.WriteLine("X[1] = " + result[0]);
            Console.WriteLine("X[2] = " + result[1]);
            Console.Write("Press any key to close: ");
            Console.ReadKey();
        }
    }
}
