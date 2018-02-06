using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int lenght = 1;
            int bestStart = 0;
            int bestLenght = 0;
            var lastNum = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                var currNum = nums[i];
                if (lastNum == currNum)
                {
                    lenght++;
                    start = i-lenght;
                }
                else
                {
                    lenght = 1;
                    start = i;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    bestStart = i - start ;
                }
                lastNum = currNum;
            }
            var result = new List<int>();
            result = nums.Skip(bestStart).Take(bestLenght).ToList();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
