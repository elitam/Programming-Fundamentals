using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Beer 2.20 110                // Beer: $2.20 * 100 = $220.00
            //    IceTea 1.50 50               // IceTea: $1.50 * 50 = $75.00
            //    NukaCola 3.30 80             // NukaCola: $3.30 * 80 = $264.00
            //    Water 1.00 500               // Water: $1.00 * 500 = $500.00
            //    stocked                      // ------------------------------
            //                                 // Grand Total: $1059.00

            var products = new Dictionary<string, double[]>();

            while (true)
            {
                var command = Console.ReadLine().Split().ToList();
                if (command[0] == "stocked")
                {
                    break;
                }

                var product = command[0];
                var price = double.Parse(command[1]);
                var quantity = double.Parse(command[2]);
                double[] numbers = new double[] { price, quantity };

                if (products.ContainsKey(product))
                {
                    products[product] = numbers;
                }
                else
                {
                    products.Add(product, numbers);
                }
            }

            var grandTotal = 0.0;
            foreach (var item in products)
            {
                var price = item.Value[0];
                var quantity = item.Value[1];
                var multiply = price * quantity;
                grandTotal += multiply;
                Console.WriteLine(  $"{item.Key}: ${price} * {quantity} = ${multiply}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
