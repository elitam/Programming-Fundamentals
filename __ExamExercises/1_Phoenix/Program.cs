using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Phoenix
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoenixes = short.Parse(Console.ReadLine());
            for (int i = 0; i < phoenixes; i++)
            {
                var totalLenght = long.Parse(Console.ReadLine());
                double totalWidht = double.Parse(Console.ReadLine());
                var wingLenght = long.Parse(Console.ReadLine());
                double totalYears = Math.Pow(totalLenght, 2) * (totalWidht + 2 * wingLenght);
                Console.WriteLine(totalYears);
            }
        }
    }
}
