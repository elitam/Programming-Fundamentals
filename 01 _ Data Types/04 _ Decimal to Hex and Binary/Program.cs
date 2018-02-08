using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Decimal_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var hex = string.Format("{0:x}", num);
            Console.WriteLine(hex);
        }
    }
}
