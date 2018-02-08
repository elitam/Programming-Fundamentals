using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Hexagonal_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int converted = Convert.ToInt32(num, 16);
            Console.WriteLine(converted);
        }
    }
}
