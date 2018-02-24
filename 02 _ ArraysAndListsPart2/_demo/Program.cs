using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var newNum = int.Parse(Console.ReadLine());

            foreach (var num in nums)
            {
                if (num == newNum)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");

        }
    }
}
