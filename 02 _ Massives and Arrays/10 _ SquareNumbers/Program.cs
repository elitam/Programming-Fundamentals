using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var num in numbers)
            {
                var numSqrt = Math.Sqrt(num);
                if (numSqrt == Math.Round(numSqrt))
                {
                    result.Add(num);
                }
            }

            // descending / ascending sort 
            result.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
