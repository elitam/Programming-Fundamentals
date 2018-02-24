using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___ArrayToNumberConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var fuckingNum = nums[0];
            var condensed = new List<int>();

            do
            {
                condensed.Clear();
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    condensed.Add(nums[i] + nums[i + 1]);
                }
                nums = condensed.ToList();

            } while (condensed.Count > 1);
            Console.WriteLine(condensed.Count == 0 ? fuckingNum : condensed[0]);
        }
    }
}
