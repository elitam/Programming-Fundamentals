using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToArray();
            var reversedWord = word.Reverse().ToArray();
            for (int i = 0; i < word.Length -1 ; i++)
            {
                if (word[0] != reversedWord[0])
                {
                    Console.WriteLine("nah");
                    return;
                }

            }
            Console.WriteLine("ya");
        }
    }
}
