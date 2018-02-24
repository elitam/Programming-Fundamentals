using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___GiveMeTheMiddleNums
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 5 6 8 5 2 4 7 5
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();

            if (nums.Count == 1)
            {
                result.Add(nums[0]);
            }
            else if (nums.Count % 2 == 0)
            {
                result = nums.Skip(nums.Count / 2 - 1).Take(2).ToList();
            }
            else if (nums.Count % 2 == 1)
            {
                result = nums.Skip(nums.Count / 2 - 1).Take(3).ToList();
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
