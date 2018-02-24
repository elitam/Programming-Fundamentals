using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___MostMeetedNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 4 2 3 4 4 1 2 4 9 3
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<Int32> unsortedInput = input.ToList();
            input.Sort();
            var counter = 1;
            var maxCounter = 0;
            var mostCommonNum = 0;
            var currNum = int.MinValue;
            foreach (var num in input)
            {
                if (num != currNum)
                {
                    currNum = num;
                    counter = 1;
                }
                else
                {
                    counter++;
                    if (counter >= maxCounter)
                    {
                        if (unsortedInput.IndexOf(mostCommonNum) > unsortedInput.IndexOf(currNum) || counter > maxCounter)
                        {
                            maxCounter = counter;
                            mostCommonNum = num;
                        }

                    }
                }
            }
            Console.WriteLine(mostCommonNum);
        }
    }
}
