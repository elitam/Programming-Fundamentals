using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___NumsAndLettersCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().Where(x => x != "").ToList();
            //var totalSum = 0;

            foreach (var word in words)
            {
                char firstLetter = word[0];
                char lastLetter = word.Last();
                int num = int.Parse(word.Substring(1, word.Count() - 2));
                var currentSum = 0;
                if (char.IsUpper(firstLetter))
                {
                    currentSum += num / (firstLetter - 97);
                }
            }


        }
    }
}
