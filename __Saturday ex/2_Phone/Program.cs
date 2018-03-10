using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            var ukazatel = new SortedDictionary<string, string>();


            while (true)
            {
               var command = Console.ReadLine().Split().ToList();
                switch (command[0])
                {
                    case "END":
                        Console.WriteLine();
                        return;
                    case "A":
                        ukazatel.Add(command[1], command[2]);
                        break;
                    case "S":
                        var name = command[1];
                        Console.WriteLine(ukazatel.ContainsKey(name) ? 
                            $"{name} -> {ukazatel[name]}" : 
                            $"Contact {name} does not exist.");
                        break;
                    default:
                        Console.WriteLine("Wrong");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
