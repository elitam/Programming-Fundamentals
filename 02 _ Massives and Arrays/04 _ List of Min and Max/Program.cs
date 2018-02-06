using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___List_of_Min_and_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            int minElement = int.MaxValue;
            int maxElement = int.MinValue;
            minElement = GetMinElement(nums, minElement);
            maxElement = GetMaxElement(nums, maxElement);
            var result = new List<int>();

            foreach (var currNum in nums)
            {
                if (currNum == minElement || currNum == maxElement)
                {
                    result.Add(currNum);
                }

            }
            result.Sort();
            Console.WriteLine(string.Join(" ", result));

        }

        private static int GetMaxElement(List<int> nums, int maxElement)
        {
            foreach (var currNum in nums)
            {
                if (currNum > maxElement)
                {
                    maxElement = currNum;
                }
            }

            return maxElement;
        }

        private static int GetMinElement(List<int> nums, int minElement)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                int currNum = nums[i];
                if (currNum < minElement)
                {
                    minElement = currNum;
                }
            }

            return minElement;
        }
    }
}
