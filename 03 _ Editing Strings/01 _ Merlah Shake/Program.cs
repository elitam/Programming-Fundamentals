using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Merlah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key = Console.ReadLine();

            while (true)
            {
                int lastindex = input.LastIndexOf(key);
                int firstindex = input.IndexOf(key);

                if (firstindex != -1 && lastindex != -1 && firstindex != lastindex
                   && key.Length > 0)
                {
                    Console.WriteLine("Shaked it.");
                    input = input.Remove(firstindex, key.Length);
                    lastindex = input.LastIndexOf(key);
                    input = input.Remove(lastindex, key.Length);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }

                int indexToremove = key.Length / 2;
                key = key.Remove(indexToremove, 1);
            }
        }
    }
}
