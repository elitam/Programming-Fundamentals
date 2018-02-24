using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___EditMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            var isEnd = false;

            while (!isEnd)
            {
                string[] command = Console.ReadLine().Split(' ');

                var action = command[0];

                switch (action)
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        var replaceIndex = int.Parse(command[1]);
                        var replaceWord = command[2];

                        if (replaceIndex >= 0 && replaceIndex < arr.Length - 1)
                        {
                            arr[replaceIndex] = replaceWord;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "END":
                        isEnd = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
