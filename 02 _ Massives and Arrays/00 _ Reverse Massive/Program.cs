using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00___Reverse_Massive
{
    class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = nums.Length;
            int[] reversed = new int[count];
            for (int i = 0; i < count; i++)
            {
                reversed[i] = nums[nums.Length - 1 - i];
            }
            Console.WriteLine(String.Join(" ", reversed));

        }

        private static void Method1()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length / 2; i++)
            {
                int temporary = nums[nums.Length - 1 - i];
                nums[nums.Length - 1 - i] = nums[i];
                nums[i] = temporary;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
