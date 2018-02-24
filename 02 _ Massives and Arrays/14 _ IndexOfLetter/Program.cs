using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            var input = Console.ReadLine().ToCharArray();

            foreach (char letter in input)
            {
                var index = Array.IndexOf(alphabet, letter);
                Console.WriteLine($"{letter} -> {index}");
            }
        }
    }
}
