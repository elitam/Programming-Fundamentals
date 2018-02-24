using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Storage
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split().ToArray();
            var quantity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var price = Console.ReadLine().Split().Select(double.Parse).ToArray();


            var isDone = false;
            while (!isDone)
            {
                var currProduct = Console.ReadLine();

                if (currProduct == "done")
                {
                    break;
                }
                var index = Array.IndexOf(products, currProduct);
                Console.WriteLine($"{currProduct} costs: {price[index]}; Available quantity: {quantity[index]}");
            }

        }
    }
}
