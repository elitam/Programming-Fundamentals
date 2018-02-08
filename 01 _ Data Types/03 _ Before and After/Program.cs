using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Before_and_After
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Before:
            //      a = 5
            //      b = 10
            //      After:
            //      a = 10
            //      b = 5

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = b;
            Console.WriteLine($"Before:\na = {a} \nb = {b}");
            b = a;
            a = c;
            Console.WriteLine($"After:\na = {a} \nb = {b}");

        }
    }
}
