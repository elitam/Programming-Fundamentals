using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Merge_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();

            var result = string.Join(" ", input)
                .Split(' ')
                .Where(x => x != "")
                .ToList();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
