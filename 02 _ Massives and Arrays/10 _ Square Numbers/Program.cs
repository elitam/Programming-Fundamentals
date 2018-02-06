using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var num in numbers)
            {
                if(num == Math.Sqrt(num) * Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
