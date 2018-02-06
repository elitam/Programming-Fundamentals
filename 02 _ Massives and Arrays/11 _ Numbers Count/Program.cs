using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Numbers_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();
            var result = new List<string>();
            int count = 0;
            for (int i = 0; i < numbers.Count ; i++)
            {
                count++;
                if (i == numbers.Count - 1 || numbers[i] != numbers[i + 1])
                {
                    var element = numbers[i];
                    result.Add($"{element} -> {count}");
                    count = 0;
                }
            }
            Console.WriteLine(string.Join("\n", result));

        }
    }
}
