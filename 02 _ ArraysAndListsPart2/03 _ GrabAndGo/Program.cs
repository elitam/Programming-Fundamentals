using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var theNum = int.Parse(Console.ReadLine());
            if (nums.Contains(theNum))
            {
                var lastIndex = nums.LastIndexOf(theNum);
                nums.RemoveRange(lastIndex, nums.Count - lastIndex );
                Console.WriteLine(nums.Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
