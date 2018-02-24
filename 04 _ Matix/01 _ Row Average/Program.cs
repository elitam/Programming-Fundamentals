using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Row_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[r, c];

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    matrix1[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < r; row++)
            {
                double sum = 0;
                for (int col = 0; col < c; col++)
                {
                    sum += matrix1[row, col];
                    Console.Write(matrix1[row, col] + " ");
                }
                Console.WriteLine(sum / matrix1.GetLength(1));
                Console.WriteLine();
            }
        }
    }
}
