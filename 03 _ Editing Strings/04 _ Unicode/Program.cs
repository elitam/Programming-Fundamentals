using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();
            var result = new List<string>();

            for (int i = 0; i < text.Count ; i++)
            {
                var currChar = text[i];
                var ff = "\\u" + ((int)currChar).ToString("X4");
                result.Add(ff);
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
