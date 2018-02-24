using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Decimal_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = input[0];
            var num = input[1];
            var result = new List<int>();
            while (num > 0)
            {
                var modulNum = num % n;
                result.Add(modulNum);
                num /= n;
            }
            result.Reverse();
            Console.WriteLine(String.Join("",result));
        }
    }
}
