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
            var totalSum = 0.00;


            foreach (var word in words)
            {
                var currentSum = 0.00;
                char firstLetter = word[0];
                char lastLetter = word.Last();
                double num = double.Parse(word.Substring(1, word.Count() - 2));

                if (char.IsUpper(firstLetter))
                {
                    currentSum += num / (firstLetter - 64);
                }
                else
                {
                    currentSum += num * (firstLetter - 96);

                }
                if (char.IsUpper(lastLetter))
                {
                    currentSum -= (lastLetter - 64);
                }
                else
                {
                    currentSum += (lastLetter - 96);

                }
                totalSum += currentSum;

            }
            Console.WriteLine($"{totalSum:f2}");


        }
    }
}
