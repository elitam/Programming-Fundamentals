using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SheIsNotTheOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine().Split('@').ToList();
            if (email[0].Length >= email[1].Length)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one!");
            }

        }
    }
}
