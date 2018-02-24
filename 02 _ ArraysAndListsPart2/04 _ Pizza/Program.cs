using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split().ToArray();
            var lenght = int.Parse(Console.ReadLine());
            var usedIngredients = new List<string>();

            foreach (var ingredient in ingredients)
            {
                if (ingredient.Length == lenght)
                {
                    usedIngredients.Add(ingredient);
                }
            }
            foreach (var item in usedIngredients)
            {
                Console.WriteLine("Adding: " + item);
            }
            Console.WriteLine($"Made pizza with total of {usedIngredients.Count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", usedIngredients)}.");
        }
    }
}
