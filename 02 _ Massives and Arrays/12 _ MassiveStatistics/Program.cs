using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___MassiveStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Min = " + input.Min());
            Console.WriteLine("Max = " + input.Max());
            Console.WriteLine("Sum = " + input.Sum());
            Console.WriteLine("Average = " + input.Average());
        }
    }
}
