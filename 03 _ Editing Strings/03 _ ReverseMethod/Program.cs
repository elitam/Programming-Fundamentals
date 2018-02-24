using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ReverseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();
            Console.WriteLine(ReverseMe(text));
        }

        private static string ReverseMe(List<char> text)
        {
            var result = new List<char>();

            for (int i = text.Count - 1; i >= 0; i--)
            {
                result.Add(text[i]);
            }
            return string.Join("", result);
        }
    }
}
