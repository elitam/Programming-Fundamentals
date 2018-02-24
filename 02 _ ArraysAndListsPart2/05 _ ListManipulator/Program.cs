using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var isEnd = false;
            while (!isEnd)
            {
                var input = Console.ReadLine().Split().ToList();
                var command = input[0];
                switch (command)
                {
                    case "print":
                        isEnd = true;
                        break;
                    case "add":
                        AddMe(nums, input);
                        break;
                    case "addMany":
                        AddMany(nums, input);
                        break;
                    case "contains":
                        ContainingNum(nums, input);
                        break;
                    case "remove":
                        RemoveMe(nums, input);
                        break;
                    case "shift":
                        ShiftMe(nums, input);
                        break;
                    case "sumPairs":  // 1 2 3 4 5 6 7
                        nums = SumPairs(nums);
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        private static List<int> SumPairs(List<int> nums)
        {
            var sumNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1)
                {
                    sumNums.Add(nums[i]);
                }
                else
                {
                    sumNums.Add(nums[i] + nums[i + 1]);
                    i++;
                }
            }
            nums = sumNums;
            return nums;
        }

        private static void ShiftMe(List<int> nums, List<string> input)
        {
            var positions = int.Parse(input[1]);
            for (int i = 0; i < positions; i++)
            {
                var tempNum = nums[0];
                nums.RemoveAt(0);
                nums.Add(tempNum);
            }
        }

        private static void RemoveMe(List<int> nums, List<string> input)
        {
            var index = int.Parse(input[1]);
            nums.RemoveAt(index);
        }

        private static void ContainingNum(List<int> nums, List<string> input)
        {
            var num = int.Parse(input[1]);
            Console.WriteLine(nums.LastIndexOf(num));
        }

        private static void AddMany(List<int> nums, List<string> input)
        {
            var index = int.Parse(input[1]);
            var range = input.GetRange(2, input.Count - 2).Select(int.Parse);
            nums.InsertRange(index, range);
        }

        private static void AddMe(List<int> nums, List<string> input)
        {
            var index = int.Parse(input[1]);
            var element = int.Parse(input[2]);
            nums.Insert(index, element);
        }
    }
}
