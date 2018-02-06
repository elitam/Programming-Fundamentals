using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] intpit = Console.ReadLine().Split();

            var bomb = int.Parse(intpit[0]);
            var range = int.Parse(intpit[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    var left = Math.Max(i - range, 0);
                    
                    var right = Math.Min(i + range, numbers.Count - 1);
                    
                    var lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());

        }
    }
}
