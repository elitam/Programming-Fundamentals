using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            while (true)
            {
                var resource = Console.ReadLine();

                if (resource != "stop")
                {
                    var quantity = int.Parse(Console.ReadLine());
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quantity;
                    }
                    else
                    {
                        resources.Add(resource, quantity);
                    }
                }
                else
                {
                    break ; 
                }
            }
            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
