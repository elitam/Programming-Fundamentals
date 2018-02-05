using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Edit_Massive
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
                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        var index = int.Parse(command[1]);
                        if (index >= 0 && index < arr.Length - 1)
                        {
                            arr[index] = command[2];
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "END":
                        isEnd = true ;
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
