using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var sabrePrice = double.Parse(Console.ReadLine());
            var robePrice = double.Parse(Console.ReadLine());
            var beltPrice = double.Parse(Console.ReadLine());
            var freeBelts = students / 6;

            var allPrice =
                sabrePrice * (students + Math.Ceiling(0.1 * students)) +
                robePrice * students +
                beltPrice * (students - freeBelts);
            if (allPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {allPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(allPrice - money):f2}lv more.");
            }


        }
    }
}
