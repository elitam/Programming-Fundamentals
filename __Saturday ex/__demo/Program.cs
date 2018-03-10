using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double>();
            products.Add("domati", 5.50);
            products.Add("krastavici", 5.50);
            products.Add("sprcialnoto zeue", 4.20);

            foreach (var item in products.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} na cena {item.Value}");
            }

        }
    }
}
