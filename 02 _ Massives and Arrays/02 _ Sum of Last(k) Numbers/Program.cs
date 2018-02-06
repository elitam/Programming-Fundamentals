using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Sum_of_Last_k__Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            nums[0]=1;
            for (int i = 1; i < n; i++)
            {
                var sum = 0;
                for (int j = 1; j <= k; j++)
                {
                    sum += i - j >= 0 ? nums[i - j] : 0;
                }
                nums[i] = sum;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
