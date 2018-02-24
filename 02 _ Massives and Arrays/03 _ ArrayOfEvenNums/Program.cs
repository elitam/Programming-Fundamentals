using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ArrayOfEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var curentNum in nums)
            {
                if (curentNum % 2 == 0)
                {
                    result.Add(curentNum);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
