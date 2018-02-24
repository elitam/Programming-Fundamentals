using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr =
                {
            }

        }

        private static void FillTheMatrix()
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

        }

        private static void Declaration()
        {
            int[,] matrix =
                        {
                { 2, 3, 4 },
                { 5, 6, 7 },
                { 8, 9, 10}
            };
        }
    }
}
