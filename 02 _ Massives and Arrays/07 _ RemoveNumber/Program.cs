using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___RemoveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            int lastElement = numbers.Last();

            numbers.RemoveAll(x => x == lastElement);

            /*
            while (numbers.Contains(lastElement))
            {
                numbers.Remove(lastElement);
            }
            */
            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
