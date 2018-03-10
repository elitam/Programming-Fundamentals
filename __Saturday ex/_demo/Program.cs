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
            char[] arr = new char[] { 'a', 'b', 'c', 'd' };

            var builder = new StringBuilder();

            builder.Append(arr, 1, 3);

            Console.WriteLine(builder);
        }
    }
}
